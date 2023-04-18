using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos
{
    public class LicenseDto
    {
        public Guid Id { get; set; }
        public long NationalId { get; set; }
    }
}
