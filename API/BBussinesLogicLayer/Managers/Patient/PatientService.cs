using AutoMapper;
using BBussinesLogicLayer.Dtos.Admin;
using BBussinesLogicLayer.Dtos.Patients;
using BBussinesLogicLayer.Managers.Patient;
using CDataAccessLayer.Data.Models;
using CDataAccessLayer.Repos.Patient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
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
        //private readonly DataContext _dbContext;
        private readonly IPatientRepo _patientRepo;
        private readonly IMapper _mapper;

        public PatientService(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IPatientRepo patientRepo,
            IMapper mapper

         )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _patientRepo = patientRepo;
            _mapper = mapper;
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
                Id = patientIdentityToAdd.Id,
                User = patientIdentityToAdd,
                NationalId = patientRegisterDto.NationalID,
                Name = patientRegisterDto.Name,
                Age = patientRegisterDto.Age,
                Gender = patientRegisterDto.Gender
            };
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, patientToAdd.Id),
            new Claim(ClaimTypes.Role, UserRoles.Patient)
        };

            await _userManager.AddClaimsAsync(patientIdentityToAdd, claims);
            //_dbContext.patients.Add(patientToAdd);
            //await _dbContext.SaveChangesAsync();
            _patientRepo.AddNewPatient(patientToAdd);
            return result;
        }

        public PatientDTO? GetPatientDetails(string id)
        {
            CDataAccessLayer.Data.Models.Patient? patientData = _patientRepo.GetPatientDetails(id);
            if (patientData is null)
            {
                return null;
            }
            return _mapper.Map<PatientDTO>(patientData);

        }

        public PatientDTO? EditProrfile(string Id,  EditProfileDTO newPatientDataDTO)
        {
            CDataAccessLayer.Data.Models.Patient newPatientData = new()
            {
                Name = newPatientDataDTO.Name,
                Age = newPatientDataDTO.Age,
                Gender = newPatientDataDTO.Gender
            };
            CDataAccessLayer.Data.Models.Patient? patientData = _patientRepo.EditProrfile(Id , newPatientData);
            if (patientData is null)
            {
                return null;
            }
            return _mapper.Map<PatientDTO>(patientData);
        }
        public HashSet<PatientDrugsDTO> GetPatientDrugs(string id)
        {
            HashSet<PatientsDrugs> patientDrugs = _patientRepo.GetPatientDrugs(id);

            HashSet<PatientDrugsDTO> patientDrugsDto = new HashSet<PatientDrugsDTO>();

            foreach (PatientsDrugs drugs in patientDrugs)
            {
                patientDrugsDto.Add(
                    new PatientDrugsDTO
                    {
                        Dosage = drugs.Dosage,
                        StartDate = drugs.StartDate,
                        EndDate = drugs.EndDate,
                        Name = drugs.Drug.Name,
                        TimesPerDay = drugs.TimesPerDay,
                        DrugId= drugs.DrugId
                    }
                );
            }
           return patientDrugsDto;
            

        }


        public HashSet<DoctorDataDTO>? GetVisitedDoctorsInfo(string patientId)
        {
            HashSet<AppointmentDetails> DoctorsInfo = _patientRepo.GetVisitedDoctorsInfo(patientId);

            HashSet<DoctorDataDTO> DoctorsInfoDto = new HashSet<DoctorDataDTO>();

            foreach (AppointmentDetails appointment in DoctorsInfo)
            {
                DoctorsInfoDto.Add(
                    new DoctorDataDTO
                    {
                        Id = appointment.Id.ToString(),
                        Name = appointment.Doctor.Name,
                        Gender = appointment.Doctor.Gender,
                        Specialization = appointment.Doctor.Specialization,
                        AppointmentDate = appointment.Date

                    }
                );
            }
            return DoctorsInfoDto;
        }

        public AppointmentDetailsDTO? GetAppointmentDetailsOfSpecificDoc(string AppointmentId , string Patientid)
        {
            AppointmentDetails? appointmentDetails = _patientRepo.GetAppointmentDetailsOfSpecificDoc(AppointmentId , Patientid);

            if(appointmentDetails is null)
            {
                return null;
            }
            return _mapper.Map<AppointmentDetailsDTO>(appointmentDetails);      
        }


        public int? RateDoctor(string patientId, string doctorId, decimal rating)
        {
            return _patientRepo.RateDoctor(patientId, doctorId, rating);
        }


        public HashSet<PatientIllnessDTO>? GetAllAppointments(string id)
        {
            var appointment = _patientRepo.GetAllIllnesses(id);
            HashSet<PatientIllnessDTO>? appointmentDetailsDTOs = new HashSet<PatientIllnessDTO>();
            if (appointment != null)
            {
                foreach (var item in appointment)
                {
                    appointmentDetailsDTOs.Add(new PatientIllnessDTO()
                    {
                        Specialization = item.Specialization,
                        DiagnosedIssues = item.DiagnosedIssues,
                    });
                }
            }
            return appointmentDetailsDTOs;
        }
    }
}
