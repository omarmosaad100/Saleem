using CDataAccessLayer.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Data.Models
{
    public class Patient
    {
        public string NationalID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }


        [ForeignKey(nameof(User)), Key]
        public string Id { get; set; }
        public IdentityUser User { get; set; }


        [InverseProperty("Patients")]
        public virtual ICollection<Issue> Issues { get; set; } = new HashSet<Issue>();

        public virtual ICollection<PatientsDrugs> Drugs { get; set; } = new HashSet<PatientsDrugs>();


        public virtual ICollection<AppointmentDetails> Appointments{ get; set; } = new HashSet<AppointmentDetails>();



        [ForeignKey(nameof(NationalId))]
        public long NationalIdId { get; set; }
        public virtual NationalId nationalId { get; set; }
    }
}
