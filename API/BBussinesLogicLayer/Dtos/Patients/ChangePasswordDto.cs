using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Patients
{
    public class ChangePasswordDto
    {
        public string oldPassword { get; set; }
        public string newPassword { get; set; }

    }
}
