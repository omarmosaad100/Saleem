using BBussinesLogicLayer.Dtos.Admin;
using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Patients
{
    public class PatientDrugsDTO
    {
        // Name ,  TakingMethod ==> from Drugs Table
        public string Name { get; set; }

        public Guid DrugId { get; set; }


        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? Dosage { get; set; }

        public int? TimesPerDay { get; set; }



    }
}
