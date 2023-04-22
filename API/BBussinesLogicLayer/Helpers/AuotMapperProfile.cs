﻿using AutoMapper;
using BBussinesLogicLayer.Dtos.Admin;
using BBussinesLogicLayer.Dtos.Patients;
using CDataAccessLayer.Data.Models;
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


            // Mapping in Patient 
            CreateMap<Patient, PatientDTO>();

            CreateMap<AppointmentDetails, AppointmentDetailsDTO>();
        }
    }
}
