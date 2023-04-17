using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Data.Models
{
    public class AppointmentDetails
    {
        [Key]
        public Guid Id { get; set; }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        [Column(TypeName = "decimal(2,1)")]
        public decimal Rating { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [MaxLength(200)]
        public string Comment { get; set; } = string.Empty;

        [ForeignKey(nameof(Patient))]
        public string PId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey(nameof(Doctor))]
        public string DId { get; set; }
        public Doctor Doctor { get; set; }

        [InverseProperty("Appointments")]
        public virtual ICollection<Drug> DescribedDrugs { get; set; } = new HashSet<Drug>();
        [InverseProperty("Appointments")]
        public virtual ICollection<Issue> DiagnosedIssues { get; set; } = new HashSet<Issue>();

    }
}
