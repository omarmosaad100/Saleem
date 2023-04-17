using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Data.Models
{
    public class Issue
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        [InverseProperty("TreatedIssues")]
        public virtual ICollection<Drug> TreatmentDrugs { get; set; } = new HashSet<Drug>();
        
        [InverseProperty("ConflictedIssues")]
        public virtual ICollection<Drug> ConflictingDrugs { get; set; } = new HashSet<Drug>();
        
        [InverseProperty("DiagnosedIssues")]
        public virtual ICollection<AppointmentDetails> Appointments { get; set; } = new HashSet<AppointmentDetails>();

        [InverseProperty("Issues")]
        public virtual ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();
    }
}
