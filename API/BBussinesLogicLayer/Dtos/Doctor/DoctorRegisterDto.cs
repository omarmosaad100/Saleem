using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Doctor
{
    public class DoctorRegisterDto
    {
        [RegularExpression("^[23]\\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\\d|3[01])\\d{7}$")]
        public string NationalID { get; set; } = string.Empty;
        public Guid License { get; set; } 
        public string Mobile { get; set; } = string.Empty;
        public Specialization Specialization { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}
