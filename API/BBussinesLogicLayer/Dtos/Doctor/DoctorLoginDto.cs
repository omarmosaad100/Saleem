using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Doctor
{
    public class DoctorLoginDto
    {
        public string UserNationalId { get; set; }
        public string Password { get; set; }
    }
    public record DoctorTokenDto(string Token, DateTime Expiry, string? Role, string username, string did);

}

