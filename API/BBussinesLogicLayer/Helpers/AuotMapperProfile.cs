using AutoMapper;
using BBussinesLogicLayer.Dtos.Admin;
using BBussinesLogicLayer.Dtos.Doctor;
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
            CreateMap<Drug, DrugsDto>();
            CreateMap<Issue, DrugConflicedIssuesDto>();
            CreateMap<Issue, DrugTreatedIssuesDto>();
            CreateMap<Doctor, DoctorDto>();

            CreateMap<Drug, DrugDto>()
                .ForMember(dest => dest.ConflictedIssues, opt => opt.MapFrom(src => src.ConflictedIssues.Select(ci => ci.Name).ToHashSet()));
            
            //CreateMap<AppointmentDto, AppointmentDetails>();
        }
    }
}
