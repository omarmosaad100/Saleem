using CDataAccessLayer.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos.Home
{
    public interface IHomeRepo
    {
        public ICollection<string> GetAllSpecializations();

    }
}
