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

        public int AddNewDrug(DrugDto drugDto)
        {
            Drug NewDrug = new Drug();
            NewDrug.Name = drugDto.Name;
            NewDrug.Id = drugDto.Id;
            NewDrug.TakingMethod = drugDto.Method;         

            HashSet<Issue> issues = _AdminRepo.GetIssueList();

            var TreatedIssues = issues.Where(i=>drugDto.TreatedIssuesIds.Contains(i.Id)).ToList();
            var ConflictedIssues = issues.Where(i => drugDto.ConflictedIssuesIds.Contains(i.Id)).ToList();
            NewDrug.TreatedIssues = TreatedIssues;
            NewDrug.ConflictedIssues = ConflictedIssues;

           return _AdminRepo.AddDrug(NewDrug);
        }
    }
}
