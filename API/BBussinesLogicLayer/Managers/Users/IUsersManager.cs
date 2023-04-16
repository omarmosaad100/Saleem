using CDataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers
{
    public interface IUsersManager
    {
        public Task<IEnumerable<AppUser>> getAllUsersFromManager();
    }
}
