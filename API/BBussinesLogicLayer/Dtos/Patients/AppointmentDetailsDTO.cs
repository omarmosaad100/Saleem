using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Patients
{
    public class AppointmentDetailsDTO
    {
        public string Name { get; set; }

        public Specialization Specialization { get; set; }

        public Gender Gender { get; set; }

        public virtual ICollection<Drug> DescribedDrugs { get; set; } = new HashSet<Drug>();

        public virtual ICollection<Issue> DiagnosedIssues { get; set; } = new HashSet<Issue>();

    }
}
