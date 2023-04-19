using BBussinesLogicLayer.Dtos.Patients;
using BBussinesLogicLayer.Managers.Patient;
using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using CDataAccessLayer.Repos.Patient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.Metrics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BBussinesLogicLayer.Managers.Patient
{
    public class PatientService : IPatientService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DataContext _dbContext;
        private readonly IPatientRepo _patientRepo;

        public PatientService(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            DataContext dbContext,
            IPatientRepo patientRepo)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
            _patientRepo = patientRepo;
        }


        async Task<IdentityResult> IPatientService.CreateAccountAsync(PatientRegisterDto patientRegisterDto)
        {

            var NationalIdSelcted = _patientRepo.GetNational(patientRegisterDto.NationalID);
            IdentityResult result2 = new();
            if (NationalIdSelcted == null)
            {
                var errors = new List<IdentityError>();
                errors.Add(new IdentityError { Code = "National Id", Description = "This National ID don’t exist in our Database" });
                return IdentityResult.Failed(errors.ToArray());
            }


            var patientIdentityToAdd = new IdentityUser()
            {
                UserName = patientRegisterDto.NationalID,
                Email = patientRegisterDto.Email,
                PhoneNumber = patientRegisterDto.Mobile
            };

            IdentityResult result = await _userManager.CreateAsync(patientIdentityToAdd, patientRegisterDto.Password);
            if (!result.Succeeded)
            {
                return result;
            }

            var roleExists = await _roleManager.RoleExistsAsync(UserRoles.Patient);
            if (!roleExists)
            {
                var newRole = new IdentityRole(UserRoles.Patient);
                await _roleManager.CreateAsync(newRole);
            }

            await _userManager.AddToRoleAsync(patientIdentityToAdd, UserRoles.Patient);

            CDataAccessLayer.Data.Models.Patient patientToAdd = new()
            {
                User = patientIdentityToAdd,
                NationalId = patientRegisterDto.NationalID,
                Name = patientRegisterDto.Name,
                Age = patientRegisterDto.Age,
                Gender = patientRegisterDto.Gender
            };
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, patientToAdd.NationalId),
            new Claim(ClaimTypes.Role, UserRoles.Patient)
        };

            await _userManager.AddClaimsAsync(patientIdentityToAdd, claims);
            _dbContext.patients.Add(patientToAdd);
            await _dbContext.SaveChangesAsync();
            return result;
        }
    }
}
