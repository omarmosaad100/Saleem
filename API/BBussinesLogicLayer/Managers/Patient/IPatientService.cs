using BBussinesLogicLayer.Dtos.Patients;
using CDataAccessLayer.Data.Models;
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

        public Task<int?> ChangePassword(string patientId, ChangePasswordDto request);

        public HashSet<PatientDrugsDTO>? GetPatientDrugs(string id);

        public HashSet<DoctorDataDTO>? GetVisitedDoctorsInfo(string patientId);

        public AppointmentDetailsDTO? GetAppointmentDetailsOfSpecificDoc(string AppointmentId, string Patientid);

        public int? RateDoctor(string patientId, string doctorId, decimal rating);

        public HashSet<PatientIllnessDTO>? GetAllIllnesses(string id);




    }
}
