using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Admin
{
    public class DrugsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DrugTakingMethod Method { get; set; }
        public HashSet<DrugTreatedIssuesDto> TreatedIssues { get; set; }
        public HashSet<DrugConflicedIssuesDto> ConflictedIssues { get; set; }
    }
}
