using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Doctor
{
    public class DisplayedAppointmentDto
    {
        public DateTime Date { get; set; }

        public string Comment { get; set; } = string.Empty;

        public string DId { get; set; }

        public HashSet<string> DescribedDrugs { get; set; }
        public HashSet<string> DiagnosedIssues { get; set; }

        public Specialization Specialization { get; set; }
    }
}


