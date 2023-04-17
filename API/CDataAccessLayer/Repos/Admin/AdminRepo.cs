using CDataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos.Admin
{
    public class AdminRepo : IAdminRepo
    {

        private readonly DataContext _context;

        public AdminRepo(DataContext context)
        {
            _context = context;
        }
    }
}
