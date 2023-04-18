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

        public HashSet<Drug> GetDrugList();

        public int AddIssue(Issue issue);

        public int AddLicense(License license);

        public Drug? GedDrug(Guid id);

        public int DeleteDrug(Guid id);
        public int UpdateDrug(Drug newDrug);
    }
}
