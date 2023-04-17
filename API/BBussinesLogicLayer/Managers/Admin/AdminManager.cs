using BBussinesLogicLayer.Dtos;
using CDataAccessLayer.Data.Models;
using CDataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Admin
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminRepo _AdminRepo;

        public AdminManager(IAdminRepo adminRepo)
        {
            _AdminRepo = adminRepo;
        }

        public int AddNewDrug(DrugDto drug)
        {
            Drug drug1 = new Drug();
            drug1.Name = drug.Name;
            drug1.Id = drug.Id;
            drug1.TakingMethod = drug.Method;

            HashSet<Issue> issues = _AdminRepo.GetIssueList();

            var selectedIssues = issues.Where(i=>drug.IssuesIds.Contains(i.Id)).ToList();
            drug1.TreatedIssues = selectedIssues;

           return _AdminRepo.AddDrug(drug1);
        }
    }
}
