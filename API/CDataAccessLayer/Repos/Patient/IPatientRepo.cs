using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CDataAccessLayer.Repos.Patient
{
    public interface IPatientRepo
    {
        public ICollection<National> GetAllNationals();
        public National? GetNational(string Id);

        public Data.Models.Patient? GetPatientDetails(string Id);

        public Data.Models.Patient? EditProrfile(string Id, Data.Models.Patient newPatientData);


        public int AddNewPatient(Data.Models.Patient patient);

        public HashSet<PatientsDrugs> GetPatientDrugs(string Id);

        // get Doctor Details + Specialization of Doctor
        public HashSet<Data.Models.AppointmentDetails> GetVisitedDoctorsInfo(string patientId);

        // get Appointment Details
        public Data.Models.AppointmentDetails? GetAppointmentDetailsOfSpecificDoc(string patientId, string doctorId);


        public int? RateDoctor(string patientId , string doctorId , decimal rating);

        public HashSet<AppointmentDetails>? GetAllAppointments(string patientId);

    
    }
}
