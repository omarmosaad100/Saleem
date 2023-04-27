using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Doctor
{
    public class DrugDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DrugTakingMethod TakingMethod { get; set; }
        public virtual HashSet<string> ConflictedIssues { get; set; }
    }
}
