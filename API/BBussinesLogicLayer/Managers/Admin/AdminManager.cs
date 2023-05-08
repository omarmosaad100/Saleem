using AutoMapper;
using BBussinesLogicLayer.Dtos;
using BBussinesLogicLayer.Dtos.Admin;
using BBussinesLogicLayer.Dtos.Patients;
using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using CDataAccessLayer.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Admin
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminRepo _AdminRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminManager(IAdminRepo adminRepo,
            IMapper mapper,
            UserManager<IdentityUser> userManager,
            IConfiguration configuration,
            RoleManager<IdentityRole> roleManager)
        {
            _AdminRepo = adminRepo;
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _roleManager = roleManager;
        }

        #region Drugs
        public int AddNewDrug(NewDrugDto drugDto)
        {
            Drug NewDrug = new Drug();
            NewDrug.Name = drugDto.Name;
            NewDrug.Id = Guid.NewGuid();
            NewDrug.TakingMethod = drugDto.Method;

            HashSet<Issue> issues = _AdminRepo.GetIssueList();

            if (drugDto.TreatedIssuesIds?.Length > 0)
            {
                var TreatedIssues = issues.Where(i => drugDto.TreatedIssuesIds.Contains(i.Id)).ToList();
                NewDrug.TreatedIssues = TreatedIssues;
            }
            if (drugDto.ConflictedIssuesIds?.Length > 0)
            {
                var ConflictedIssues = issues.Where(i => drugDto.ConflictedIssuesIds.Contains(i.Id)).ToList();
                NewDrug.ConflictedIssues = ConflictedIssues;
            }

            return _AdminRepo.AddDrug(NewDrug);
        }

        public HashSet<DrugsDto> GetDrugList()
        {
            var allDrugs = _AdminRepo.GetDrugList();

            return _mapper.Map<HashSet<DrugsDto>>(allDrugs);
        }

        public DrugsDto? GetDrug(Guid id)
        {
            var drug = _AdminRepo.GedDrug(id);

            if (drug == null)
                return null;
            return _mapper.Map<DrugsDto>(drug);

        }

        public int DeleteDrug(Guid id)
        {
            return _AdminRepo.DeleteDrug(id);
        }

        public int UpdateDrug(NewDrugDto drug, Guid id)
        {
            Drug NewDrug = new Drug();
            NewDrug.Id = id;
            NewDrug.Name = drug.Name;
            NewDrug.TakingMethod = drug.Method;

            NewDrug.TreatedIssues = new Collection<Issue>();
            NewDrug.ConflictedIssues = new Collection<Issue>();

            if (drug.TreatedIssuesIds != null || drug.ConflictedIssuesIds != null)
            {
                HashSet<Issue> issues = _AdminRepo.GetIssueList();

                if (drug.TreatedIssuesIds?.Length > 0)
                {
                    var TreatedIssues = issues.Where(i => drug.TreatedIssuesIds.Contains(i.Id)).ToList();
                    NewDrug.TreatedIssues = TreatedIssues;
                }
                if (drug.ConflictedIssuesIds?.Length > 0)
                {
                    var ConflictedIssues = issues.Where(i => drug.ConflictedIssuesIds.Contains(i.Id)).ToList();
                    NewDrug.ConflictedIssues = ConflictedIssues;
                }
            }

            return _AdminRepo.UpdateDrug(NewDrug);
        }
        #endregion

        #region Issues
        public int AddIssue(IssueDto issueName)
        {
            if (issueName == null)
                return 0;

            Issue newIssue = new();

            newIssue.Id = Guid.NewGuid();
            newIssue.Name = issueName.Name;

            return _AdminRepo.AddIssue(newIssue);

        }
        #endregion

        #region Licenses
        public int AddLicense(LicenseDto licenseDto)
        {
            if (licenseDto == null)
                return 0;

            License newLicense = new();

            newLicense.Id = Guid.NewGuid();
            newLicense.NationalId = licenseDto.NationalId;

            return _AdminRepo.AddLicense(newLicense);
        }


        public HashSet<IssueDto> GetAllIssues()
        {
            var Issues = _AdminRepo.GetAllIssues();
            return _mapper.Map<HashSet<IssueDto>>(Issues);
        }
        #endregion

        #region Doctors
        public HashSet<DoctorDto> GetAllDoctors()
        {
            var allDoctors = _AdminRepo.GetAllDoctors();

            return _mapper.Map<HashSet<DoctorDto>>(allDoctors);
        }

        public int DeleteDoctor(string id)
        {
            return _AdminRepo.DeleteDoctor(id);
        }


        #endregion

        #region authentication

        public async Task<IdentityResult> Register(AdminLoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.username);

            if (user != null)
            {
                var errors = new List<IdentityError>();
                errors.Add(new IdentityError { Code = "Username", Description = "This username already exists" });
                return IdentityResult.Failed(errors.ToArray());
            }

            var AdminIdentity = new IdentityUser()
            {
                UserName = loginDto.username,
            };

            IdentityResult result = await _userManager.CreateAsync(AdminIdentity, loginDto.password);

            if (!result.Succeeded)
            {
                return result;
            }

            var roleExists = await _roleManager.RoleExistsAsync(UserRoles.Admin);

            if (!roleExists)
            {
                var AdminRole = new IdentityRole(UserRoles.Admin);
                await _roleManager.CreateAsync(AdminRole);
            }

            await _userManager.AddToRoleAsync(AdminIdentity, UserRoles.Admin);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name , AdminIdentity.UserName),
                new Claim(ClaimTypes.Role, UserRoles.Admin)
            };

            await _userManager.AddClaimsAsync(AdminIdentity, claims);

            return result;
        }
        public async Task<ActionResult<AdminTokenDto>> Login(AdminLoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.username);

            if (user == null)
            {
                return null;  // not found
            }

            var isAuthenticated = await _userManager.CheckPasswordAsync(user, loginDto.password);

            if (!isAuthenticated)
            {
                return null; // wrong password
            }

            var claimsList = await _userManager.GetClaimsAsync(user);

            #region Token works
            var secretKeyString = _configuration.GetValue<string>("SecretKey") ?? string.Empty;
            var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
            var secretKey = new SymmetricSecurityKey(secretKeyInBytes);

            //Combination SecretKey, HashingAlgorithm
            var siginingCreedentials = new SigningCredentials(secretKey,
                SecurityAlgorithms.HmacSha256Signature);

            var expiry = DateTime.Now.AddDays(4);

            var token = new JwtSecurityToken(
                claims: claimsList,
                expires: expiry,
                signingCredentials: siginingCreedentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenString = tokenHandler.WriteToken(token);
            #endregion

            var role = await _userManager.GetRolesAsync(user);

            return new AdminTokenDto(tokenString , expiry , role[0]);
        }

       
        #endregion
    }
}


//Mapping the hard way
//public HashSet<AllDrugDto> das()
//{
//    HashSet<AllDrugDto> allDrugs = new HashSet<AllDrugDto>();
//    foreach (var drug in _AdminRepo.GetDrugList())
//    {
//        HashSet<DrugTreatedIssuesDto> DTI = new();
//        for (int i = 0; i < drug.TreatedIssues.Count; i++)
//        {
//            var Id = drug.TreatedIssues.ElementAt(i).Id;
//            var Name = drug.TreatedIssues.ElementAt(i).Name;
//            DTI.Add(new DrugTreatedIssuesDto(Id, Name));
//        }
//        HashSet<DrugConflicedIssuesDto> DCI = new();
//        for (int i = 0; i < drug.ConflictedIssues.Count; i++)
//        {
//            var Id = drug.ConflictedIssues.ElementAt(i).Id;
//            var Name = drug.ConflictedIssues.ElementAt(i).Name;
//            DCI.Add(new DrugConflicedIssuesDto(Id, Name));
//        }
//        allDrugs.Add(new AllDrugDto(drug.Id, drug.Name, drug.TakingMethod, DTI, DCI));
//    }
//    return allDrugs;
//}

