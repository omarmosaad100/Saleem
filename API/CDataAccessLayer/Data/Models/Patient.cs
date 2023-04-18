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


        [RegularExpression("^[23]\\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\\d|3[01])\\d{7}$")]

        [ForeignKey(nameof(National))]
        public string NationalId { get; set; }
        public virtual National National { get; set; }
    }
}
