using AutoMapper;
using BBussinesLogicLayer.Dtos.Admin;
using BBussinesLogicLayer.Dtos.Doctor;
using BBussinesLogicLayer.Dtos.Patients;
using BBussinesLogicLayer.Managers.Patient;
using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using CDataAccessLayer.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Doctor
{
    public class DoctorManager: IDoctorManager
    {
        private readonly IDoctorRepo _doctorRepo;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public DoctorManager(IDoctorRepo doctorRepo, IMapper mapper, DataContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager) 
        {
            _doctorRepo = doctorRepo;
            _mapper = mapper;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public int AddAppointment(AppointmentDto appointmentDto)
        {
            //AppointmentDetails newAppointment = _mapper.Map<AppointmentDetails>(appointmentDto);


            AppointmentDetails newAppointment = new AppointmentDetails
            {
                Id = appointmentDto.Id,
                Date = appointmentDto.Date,
                Comment = appointmentDto.Comment,
                PId = appointmentDto.PId,
                DId = appointmentDto.DId,
                Specialization = appointmentDto.Specialization,
                DescribedDrugs = appointmentDto.DescribedDrugs.Select(id => _context.Drugs.FirstOrDefault(p => p.Id == id)).ToList(),
                DiagnosedIssues = appointmentDto.DiagnosedIssues.Select(id => _context.Issues.FirstOrDefault(p => p.Id == id)).ToList(),

            };

            return _doctorRepo.AddAppointment(newAppointment);
        }

        public HashSet<DisplayedAppointmentDto> GetAppointmentsByNid(string nid)
        {
            var appointments = _doctorRepo.GetAppointmentsByNid(nid);

            HashSet<DisplayedAppointmentDto> displayedAppointments = new();

            foreach (var app in appointments)
            {
                DisplayedAppointmentDto newDisplayedApp = new()
                {
                    Date = app.Date,
                    Comment = app.Comment,
                    DoctorName = _context.Doctors.FirstOrDefault(d => d.Id == app.DId).Name,
                    DescribedDrugs = app.DescribedDrugs.Select(drug => _context.Drugs.FirstOrDefault(d => d.Id == drug.Id).Name).ToHashSet(),
                    DiagnosedIssues = app.DiagnosedIssues.Select(issue => _context.Issues.FirstOrDefault(i => i.Id == issue.Id).Name).ToHashSet(),
                    Specialization = app.Specialization,

                };

                displayedAppointments.Add(newDisplayedApp);
            }

            return displayedAppointments;

        }

        public DoctorProfileDto GetDoctorProfileById(string did)
        {
            var doctor = _doctorRepo.GetDoctorProfileById(did);

            return _mapper.Map<DoctorProfileDto>(doctor);
        }


        public bool DeleteIssueByPidAndIssueName(string pid, string name)
        {
            return _doctorRepo.DeleteIssueByPidAndIssueName(pid, name);
        }

        public DrugDto GetDrugRecommendation(string issueName, string pid)
        {
            var drug = _doctorRepo.GetDrugRecommendation(issueName, pid);

            return _mapper.Map<DrugDto>(drug);
        }

        public HashSet<DisplayedIssueDto> GetAllIssues()
        {
            var issues = _doctorRepo.GetAllIssues();

            var displayedIssues = new HashSet<DisplayedIssueDto>();


            foreach (var issue in issues)
            {
                var newDisplayedIssue = _mapper.Map<DisplayedIssueDto>(issue);
                displayedIssues.Add(newDisplayedIssue);
            }

            return displayedIssues;
        }

        public string GetPidByNid(string nid)
        {
            return _doctorRepo.GetPidByNid(nid);
        }

        public HashSet<DisplayedIssueDto> GetIssuesByPid(string pid)
        {

            var issues = _doctorRepo.GetIssuesByPid(pid);

            var displayedIssues = new HashSet<DisplayedIssueDto>();

            foreach (var issue in issues)
            {
                var newDisplayedIssue = _mapper.Map<DisplayedIssueDto>(issue);
                displayedIssues.Add(newDisplayedIssue);
            }

            return displayedIssues;
        }

        async Task<IdentityResult> IDoctorManager.CreateAccountAsync(DoctorRegisterDto doctorRegisterDto)
        {


            var NationalIdSelcted = _doctorRepo.GetNational(doctorRegisterDto.NationalID);
            IdentityResult result2 = new();
            if (NationalIdSelcted == null)
            {
                var errors = new List<IdentityError>();
                errors.Add(new IdentityError { Code = "National Id", Description = "This National ID don’t exist in our Database" });
                return IdentityResult.Failed(errors.ToArray());
            }
            //I want to check if this nationalID match Lisence , so I will get the  Lisence by national ID
            var theRequiredLisence = _doctorRepo.GetLicense(NationalIdSelcted.Id);

            if (doctorRegisterDto.License != theRequiredLisence)
            {
                var errors = new List<IdentityError>();
                errors.Add(new IdentityError { Code = "License", Description = "This License dosn't math the national id" });
                return IdentityResult.Failed(errors.ToArray());

            }

            var doctorIdentityToAdd = new IdentityUser()
            {
                UserName = doctorRegisterDto.NationalID,
                Email = doctorRegisterDto.Email,
                PhoneNumber = doctorRegisterDto.Mobile
            };

            IdentityResult result = await _userManager.CreateAsync(doctorIdentityToAdd, doctorRegisterDto.Password);
            if (!result.Succeeded)
            {
                return result;
            }

            var roleExists = await _roleManager.RoleExistsAsync(UserRoles.Doctor);
            if (!roleExists)
            {
                var newRole = new IdentityRole(UserRoles.Doctor);
                await _roleManager.CreateAsync(newRole);
            }

            await _userManager.AddToRoleAsync(doctorIdentityToAdd, UserRoles.Doctor);

            CDataAccessLayer.Data.Models.Doctor doctorToAdd = new()
            {
                Id = doctorIdentityToAdd.Id,
                User = doctorIdentityToAdd,
                LicenseId= doctorRegisterDto.License,
                Specialization=doctorRegisterDto.Specialization,
                Name = doctorRegisterDto.Name,
                Gender = doctorRegisterDto.Gender
            };
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, doctorToAdd.Id),
            new Claim(ClaimTypes.Role, UserRoles.Doctor)
        };

            await _userManager.AddClaimsAsync(doctorIdentityToAdd, claims);
            //_dbContext.patients.Add(patientToAdd);
            //await _dbContext.SaveChangesAsync();
            _doctorRepo.AddNewDoctor(doctorToAdd);
            return result;
        }


    }
}
