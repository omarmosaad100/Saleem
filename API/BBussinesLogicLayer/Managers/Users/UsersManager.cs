using CDataAccessLayer.Data;
using CDataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers
{
    public class UsersManager : IUsersManager
    {
        private readonly IUsersRepo _usersRepo;

        public UsersManager(IUsersRepo usersRepo)
        {
            _usersRepo = usersRepo;
        }

        public async Task<IEnumerable<AppUser>> getAllUsersFromManager()
        {
            return await _usersRepo.GetAllUsersFromRepo();
        }
    }
}
