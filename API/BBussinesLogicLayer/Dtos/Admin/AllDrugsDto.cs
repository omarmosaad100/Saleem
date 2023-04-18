using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Admin
{

    public record AllDrugDto(Guid Id, string Name,
    DrugTakingMethod Method, HashSet<DrugTreatedIssuesDto> TreatedIssues,
    HashSet<DrugConflicedIssuesDto> ConflictedIssues);

}
