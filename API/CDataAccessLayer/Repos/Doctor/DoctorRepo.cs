using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

            //remove the issue we wanna cure
            var ToBeCuredIssue = patientIssues.FirstOrDefault(i => i.Name == issueName);

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
            if (leastDrugCounter.Value > 0)
                foreach (var issue in RecommendedDrug.ConflictedIssues)
                    patient.Issues.Add(issue);

            //return the treated issue
            patientIssues.Add(ToBeCuredIssue);

            _context.SaveChanges();

            return RecommendedDrug;

            //make the issues column in db unique
        }
    }
}
