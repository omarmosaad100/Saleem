using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CDataAccessLayer.Data.Models
{
    public class Drug
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DrugTakingMethod TakingMethod { get; set; }

        [InverseProperty("TreatmentDrugs")]
        public virtual ICollection<Issue> TreatedIssues { get; set; } = new HashSet<Issue>();
        [JsonIgnore]
        [InverseProperty("ConflictingDrugs")]
        public virtual ICollection<Issue> ConflictedIssues { get; set; } = new HashSet<Issue>();
        [JsonIgnore]
        [InverseProperty("DescribedDrugs")]
        public virtual ICollection<AppointmentDetails> Appointments { get; set; } = new HashSet<AppointmentDetails>();
        [JsonIgnore]
        public virtual ICollection<PatientsDrugs> Patients { get; set; } = new HashSet<PatientsDrugs>();

    }
}
