using BBussinesLogicLayer.Dtos.Admin;
using BBussinesLogicLayer.Dtos.Doctor;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Doctor
{
    public interface IDoctorManager
    {
        public int AddAppointment(AppointmentDto appointmentDto);
        public HashSet<DisplayedAppointmentDto> GetAppointmentsByNid(string nid);
        public DoctorDto GetDoctorProfileById(string did);
        public bool DeleteIssueByPidAndIssueName(string pid, string name);
        public DrugDto GetDrugRecommendation(string issueName, string pid);
    }
}
