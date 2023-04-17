using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos
{
    public interface IAdminRepo
    {
        public int AddDrug(Drug drug);

        public HashSet<Issue> GetIssueList();
    }
}
