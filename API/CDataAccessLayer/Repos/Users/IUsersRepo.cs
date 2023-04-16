
using CDataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos
{
    public interface IUsersRepo
    {
        public Task<IEnumerable<AppUser>> GetAllUsersFromRepo();
    }
}
