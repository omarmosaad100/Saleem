using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Patients
{

    public class EditProfileDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string? ImgPath { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

    }
}
