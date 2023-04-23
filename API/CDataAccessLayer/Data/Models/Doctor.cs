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
    public class Doctor
    {
        [ForeignKey(nameof(User)), Key]
        public string Id { get; set; }
        public IdentityUser User { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EnumDataType(typeof(Specialization))]
        public Specialization Specialization { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }


        [Required]
        [MaxLength(50)]
        [ForeignKey(nameof(License))]
        public Guid LicenseId { get; set; } = Guid.Empty;
        public virtual License License { get; set; }

        public virtual ICollection<AppointmentDetails> Appointments { get; set; } = new HashSet<AppointmentDetails>();

    }
}
