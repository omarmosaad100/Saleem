using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos
{
    public class AdminRepo : IAdminRepo
    {

        private readonly DataContext _context;

        public AdminRepo(DataContext context)
        {
            _context = context;
        }

        public int AddDrug(Drug drug)
        {
            if (drug != null)
            {
                _context.Drugs.Add(drug);
               return _context.SaveChanges();
            }
            return 0;
        }

        public HashSet<Issue> GetIssueList()
        {
            return _context.Issues.ToHashSet<Issue>();
        }
    }
}
