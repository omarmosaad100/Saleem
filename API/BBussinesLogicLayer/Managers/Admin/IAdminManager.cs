using BBussinesLogicLayer.Dtos;
using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Admin
{
    public interface IAdminManager
    {
        public int AddNewDrug(DrugDto drug);

        
    }
}
