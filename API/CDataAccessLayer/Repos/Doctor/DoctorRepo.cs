using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos
{
    public class DoctorRepo: IDoctorRepo
    {
        private readonly DataContext _context;
    
        public DoctorRepo(DataContext context)
        {
            _context = context;
        }
        public int AddAppointment(AppointmentDetails appointmentDetails)
        {
            if (appointmentDetails != null)
            {

                _context.AppointmentDetails.Add(appointmentDetails);

                var patient = _context.patients.Include(p => p.Issues).FirstOrDefault(p => p.Id == appointmentDetails.PId);
                var PatientsDrug = _context.PatientsDrugs;

                var patientIssues = patient?.Issues;
                var patientDrug = patient?.Drugs;

                foreach (var issue in appointmentDetails.DiagnosedIssues)
                {
                    patientIssues?.Add(issue);
                }

                foreach (var drug in appointmentDetails.DescribedDrugs)
                {
                    var newPatientDrugs = new PatientsDrugs
                    {
                        DrugId= drug.Id,
                        Dosage = "1",
                        StartDate = DateTime.Now,
                        EndDate = new DateTime (DateTime.Now.Year , DateTime.Now.Month,DateTime.Now.Day+7),
                        TimesPerDay = 3,
                        PatientId = appointmentDetails.PId
                    };

                    PatientsDrug?.Add(newPatientDrugs);
                }

                return _context.SaveChanges();
            }
            return 0;
        }

        public HashSet<AppointmentDetails> GetAppointmentsByNid(string nid) 
        {
            var patient = _context.patients
            .Include(p => p.Appointments)
                .ThenInclude(a => a.DescribedDrugs)
            .Include(p => p.Appointments)
                .ThenInclude(a => a.DiagnosedIssues)
            .FirstOrDefault(p => p.NationalId == nid);

            return patient.Appointments.ToHashSet();
        }

        public Doctor GetDoctorProfileById(string did)
        {
            return _context.Doctors.FirstOrDefault(d => d.Id == did);
        }

        public bool DeleteIssueByPidAndIssueName(string pid, string name)
        {

            var patients = _context.patients.Include(p => p.Issues).FirstOrDefault(p => p.Id == pid);

            var patientIssues = patients.Issues;

            var Issue = patientIssues.FirstOrDefault(i => i.Name == name);

            var result = patientIssues.Remove(Issue);

            _context.SaveChanges();

            return result;

        }

        public Drug GetDrugRecommendation(string issueName, string pid)
        {

            // the patient we want to cure
            var patient = _context.patients
                .Include(p => p.Issues)
                    .ThenInclude(i => i.TreatmentDrugs)
                        .ThenInclude(td => td.ConflictedIssues)               
                .FirstOrDefault(p => p.Id == pid);

            //patient's issues to avoid conflicting while recommendation
            var patientIssues = patient.Issues;

            var ToBeCuredIssue = _context.Issues
                .Include(i => i.TreatmentDrugs)
                    .ThenInclude(i => i.ConflictedIssues)
                .FirstOrDefault(i => i.Name == issueName);

            //remove the issue we wanna cure
            //var ToBeCuredIssue = patientIssues.FirstOrDefault(i => i.Name == issueName);

            //remove the treated issue temporarily
            patientIssues.Remove(ToBeCuredIssue);

            //create a dictionary of hashsets.. hashset for each issue to be avoided
            HashSet<HashSet<Drug>> ConflictsHashSets = new();


            foreach (var issue in patientIssues)
            {
                HashSet<Drug> conflictingDrugs = new ();
                conflictingDrugs = issue.ConflictingDrugs.ToHashSet();
                ConflictsHashSets.Add(conflictingDrugs);
            }

            //loop over ToBeCuredIssue's treatment drugs, and return the one with least conflicts
            Drug emptyDrug = new Drug();
            KeyValuePair<Drug, int> leastDrugCounter = new(emptyDrug, int.MaxValue);

            foreach (var drug in ToBeCuredIssue.TreatmentDrugs)
            {
                int thisDrugCounter = 0;

                foreach (var row in ConflictsHashSets)
                    if (row.Contains(drug))
                        thisDrugCounter++;


                if (thisDrugCounter < leastDrugCounter.Value)
                    leastDrugCounter = new (drug, thisDrugCounter);
            }

            var RecommendedDrug = leastDrugCounter.Key;

            //if conflicts must exist, add them to the patient's issues
            //come back here, consider removing those lines
            //if (leastDrugCounter.Value > 0)
            //    foreach (var issue in RecommendedDrug.ConflictedIssues)
            //        patient.Issues.Add(issue);


            //return the treated issue
            patientIssues.Add(ToBeCuredIssue);

            _context.SaveChanges();

            return RecommendedDrug;

            //make the issues column in db unique
        }

        public HashSet<Issue> GetAllIssues()
        {
            return _context.Issues.ToHashSet();
        }

        public string GetPidByNid(string nid)
        {
            return _context.patients.FirstOrDefault(p => p.NationalId == nid).Id;
        }

        public HashSet<Issue> GetIssuesByPid(string pid)
        {
            return _context.patients.Include(p => p.Issues).FirstOrDefault(p => p.Id == pid).Issues.ToHashSet();
        }


        public National? GetNational(string Id) => _context.nationalIds.FirstOrDefault(i => i.Id == Id);

        public Guid? GetLicense(string Id)
        {
            var license = _context.licenses.FirstOrDefault(i => i.NationalId == Id);
            if(license != null) return license.Id;
            return null;
        }
        public int AddNewDoctor(Data.Models.Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            return _context.SaveChanges();

        }
    }
}
