using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos
{
    public interface IDoctorRepo
    {
        //public HashSet<AppointmentDetails> GetAppointmentsByNid(int nid);

        //public Doctor GetMyInformation(int did);
        public National? GetNational(string Id);
        public Guid? GetLicense(string Id);

        public int AddAppointment(AppointmentDetails appointmentDetails);

        public HashSet<AppointmentDetails> GetAppointmentsByNid(string nid);

        public Doctor GetDoctorProfileById(string did);

        public bool DeleteIssueByPidAndIssueName(string pid, string name);

        public Drug GetDrugRecommendation(string issueName, string pid);

        public HashSet<Issue> GetAllIssues();

        public string GetPidByNid(string nid);

        public HashSet<Issue> GetIssuesByPid(string pid);
        public int AddNewDoctor(Data.Models.Doctor doctor);

    }
}
