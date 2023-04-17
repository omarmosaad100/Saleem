using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CDataAccessLayer.Data.Models
{
    public class PatientsDrugs
    {
        [ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }
        [InverseProperty("Drugs")]
        public Patient Patient { get; set; }

        [ForeignKey(nameof(Drug))]
        public Guid DrugId { get; set; }
        [InverseProperty("Patients")]
        public Drug Drug { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [MaxLength(50)]
        public string Dosage { get; set; }
        public int TimesPerDay { get; set; }


    }
}
