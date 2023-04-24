using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Doctor
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }

        public decimal Rating { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; } = string.Empty;

        public string PId { get; set; }

        public string DId { get; set; }
 
        //public virtual ICollection<Drug> DescribedDrugs { get; set; } = new HashSet<Drug>(); //list of drugs id

        //public virtual ICollection<Issue> DiagnosedIssues { get; set; } = new HashSet<Issue>(); //list of issues id

        public HashSet<Guid> DescribedDrugs { get; set; }
        public HashSet<Guid> DiagnosedIssues { get; set; }

        //maybe replace ids with objects in constructor

        public Specialization Specialization { get; set; }

        public AppointmentDto()
        {
            Id = Guid.NewGuid();
        }
    }
}
