using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Patients
{
    public class PatientLoginDto
    {
        public string UserNationalId { get; set; }
        public string Password { get; set; }
    }

    public record TokenDto(string Token, DateTime Expiry , string? Role);

}
