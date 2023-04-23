using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos.Patient
{
    public class PatientRepe : IPatientRepo
    {
        private readonly DataContext _context;

        public PatientRepe(DataContext context)
        {
            _context = context;
        }

        public National? GetNational(string Id) => _context.nationalIds.FirstOrDefault(i => i.Id == Id);
        public ICollection<National> GetAllNationals() => _context.nationalIds.ToList();


        // get patient details 
        public Data.Models.Patient? GetPatientDetails(string Id)
        {
            Data.Models.Patient? patient = _context.patients.Find(Id);
            if (patient == null)
            {
                return null;
            }
            return patient;
        }

        public Data.Models.Patient? EditProrfile(string Id, Data.Models.Patient newPatientData)
        {
            Data.Models.Patient? patient = _context.patients.Find(Id);
            if (patient == null)
            {
                return null;
            }
            patient.Age = newPatientData.Age;
            patient.Name = newPatientData.Name;
            patient.ImgPath = newPatientData.ImgPath;
            patient.Gender = newPatientData.Gender;

            _context.SaveChanges();

            return newPatientData;
        }


        public int AddNewPatient(Data.Models.Patient patient)
        {
            _context.patients.Add(patient);
            return _context.SaveChanges();

        }

        public HashSet<PatientsDrugs> GetPatientDrugs(string PatientId)
        {
            return (
                _context.PatientsDrugs
                .Include(p => p.Drug)
                .Where(p => p.PatientId == PatientId)
                .ToHashSet()
              );
        }



        // get Doctor Details + Specialization of Doctor
        public HashSet<Data.Models.AppointmentDetails> GetVisitedDoctorsInfo(string patientId)
        {
            return _context.Set<Data.Models.AppointmentDetails>()
                .Include(d => d.Doctor)
                .Where(a => a.PId == patientId)
                .ToHashSet();
        }


        public Data.Models.AppointmentDetails? GetAppointmentDetailsOfSpecificDoc(string patientId, string DocID)
        {
            return _context.Set<Data.Models.AppointmentDetails>()
                .Include(d => d.Doctor)
                .Include(d => d.DescribedDrugs)
                .Include(d => d.DiagnosedIssues)
                .Where(a => a.PId == patientId && a.DId == DocID)
                .FirstOrDefault();
        }


        public int? RateDoctor(string patientId, string doctorId, decimal rating)
        {
            AppointmentDetails? appointment = _context.Set<Data.Models.AppointmentDetails>()
                                               .Where(a => a.PId == patientId && a.DId == doctorId)
                                               .FirstOrDefault();
            if (appointment is null)
            {
                return null;
            }

            appointment.Rating = rating;

            return _context.SaveChanges();

        }
        public HashSet<AppointmentDetails>? GetAllAppointments(string patientId)
        {

                

            HashSet<AppointmentDetails>? appointmentDetails = _context.AppointmentDetails
                .Include(p => p.DiagnosedIssues)
                .Where(p => p.PId == patientId)
                .ToHashSet();
            return appointmentDetails; 
        }

    }
}
