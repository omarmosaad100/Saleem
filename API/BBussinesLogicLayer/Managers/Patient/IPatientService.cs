using BBussinesLogicLayer.Dtos.Patients;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Patient
{
    public interface IPatientService
    {
        Task<IdentityResult> CreateAccountAsync(PatientRegisterDto patientRegisterDto);
    }
}
