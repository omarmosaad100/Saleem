using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos
{
    public record NewDrugDto(Guid Id, string Name,
        DrugTakingMethod Method, Guid[] TreatedIssuesIds, Guid[] ConflictedIssuesIds);
}
