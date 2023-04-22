using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Doctor
{
    public class DoctorDto
    {
        public string Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public Specialization Specialization { get; set; }

        public Gender Gender { get; set; }

        public Guid LicenseId { get; set; } = Guid.Empty;
    }
}
