using AutoMapper;
using BBussinesLogicLayer.Dtos.Admin;
using BBussinesLogicLayer.Dtos.Doctor;
using BBussinesLogicLayer.Dtos.Patients;
using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Helpers
{
    public class AuotMapperProfile : Profile
    {
        public AuotMapperProfile()
        {
            CreateMap<Drug, DrugsDto>()
                .ForMember(dest => dest.Method, opt =>
                opt.MapFrom(src => src.TakingMethod));

            CreateMap<Issue, DrugConflicedIssuesDto>();
            CreateMap<Issue, DrugTreatedIssuesDto>();
            CreateMap<Doctor, DoctorDto>();

            CreateMap<Drug, DrugDto>()
                .ForMember(dest => dest.ConflictedIssues, opt => opt.MapFrom(src => src.ConflictedIssues.Select(ci => ci.Name).ToHashSet()));
            
            //CreateMap<AppointmentDto, AppointmentDetails>();

            // Mapping in Patient 
            CreateMap<Patient, PatientDTO>();

            CreateMap<AppointmentDetails, AppointmentDetailsDTO>();
        }
    }
}
