using CDataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos
{
    public class UsersRepo : IUsersRepo 
    {
        private readonly DataContext _context;

        public UsersRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AppUser>> GetAllUsersFromRepo()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
