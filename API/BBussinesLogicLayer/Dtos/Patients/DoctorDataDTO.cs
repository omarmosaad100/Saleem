using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Patients
{
    public class DoctorDataDTO
    {
        public string Name { get; set; }

        public Specialization Specialization { get; set; }

        public Gender Gender { get; set; }

    }
}
