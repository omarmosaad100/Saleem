using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Home
{
    public interface IHomeManager
    {
        public ICollection<string> GetAllSpecializations();


    }
}
