﻿using BBussinesLogicLayer.Dtos.Patients;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BBussinesLogicLayer.Managers.Patient
{
    public interface IPatientService
    {
        Task<IdentityResult> CreateAccountAsync(PatientRegisterDto patientRegisterDto);

        public PatientDTO? GetPatientDetails(string id);

        public PatientDTO? EditProrfile(string Id, EditProfileDTO newPatientData);

        public HashSet<PatientDrugsDTO>? GetPatientDrugs(string id);

        public HashSet<DoctorDataDTO> GetVisitedDoctorsInfo(string patientId);

        public AppointmentDetailsDTO? GetAppointmentDetailsOfSpecificDoc(string patientId, string DocID);

        public int? RateDoctor(string patientId, string doctorId, decimal rating);

    }
}
