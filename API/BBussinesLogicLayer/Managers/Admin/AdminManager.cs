using AutoMapper;
using BBussinesLogicLayer.Dtos;
using BBussinesLogicLayer.Dtos.Admin;
using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using CDataAccessLayer.Repos;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMapper _mapper;

        public AdminManager(IAdminRepo adminRepo, IMapper mapper)
        {
            _AdminRepo = adminRepo;
            _mapper = mapper;
        }

        public int AddNewDrug(NewDrugDto drugDto)
        {
            Drug NewDrug = new Drug();
            NewDrug.Name = drugDto.Name;
            NewDrug.Id = drugDto.Id;
            NewDrug.TakingMethod = drugDto.Method;

            HashSet<Issue> issues = _AdminRepo.GetIssueList();

            var TreatedIssues = issues.Where(i => drugDto.TreatedIssuesIds.Contains(i.Id)).ToList();
            var ConflictedIssues = issues.Where(i => drugDto.ConflictedIssuesIds.Contains(i.Id)).ToList();
            NewDrug.TreatedIssues = TreatedIssues;
            NewDrug.ConflictedIssues = ConflictedIssues;

            return _AdminRepo.AddDrug(NewDrug);
        }

        public HashSet<AllDrugsDto> GetDrugList()
        {
            var allDrugs = _AdminRepo.GetDrugList();

            return _mapper.Map<HashSet<AllDrugsDto>>(allDrugs);
        }

        public int AddIssue(IssueDto issueDto)
        {
            if (issueDto == null)
                return 0;

            Issue newIssue = new ();

            newIssue.Id = issueDto.Id;
            newIssue.Name = issueDto.Name;

            return _AdminRepo.AddIssue(newIssue);

        }

        public int AddLicense(LicenseDto licenseDto)
        {
            if (licenseDto == null)
                return 0;

            License newLicense = new ();

            newLicense.Id = licenseDto.Id;
            newLicense.NationalIdId = licenseDto.NationalId;

            return _AdminRepo.AddLicense(newLicense);
        }
    }
}


//public HashSet<AllDrugDto> GetDrugList()
//{
//    HashSet<AllDrugDto> allDrugs = new HashSet<AllDrugDto>();
//    foreach (var drug in _AdminRepo.GetDrugList())
//    {
//        HashSet<DrugTreatedIssuesDto> DTI = new();
//        for (int i = 0; i < drug.TreatedIssues.Count; i++)
//        {
//            var Id = drug.TreatedIssues.ElementAt(i).Id;
//            var Name = drug.TreatedIssues.ElementAt(i).Name;
//            DTI.Add(new DrugTreatedIssuesDto(Id, Name));
//        }

//        HashSet<DrugConflicedIssuesDto> DCI = new();
//        for (int i = 0; i < drug.ConflictedIssues.Count; i++)
//        {
//            var Id = drug.ConflictedIssues.ElementAt(i).Id;
//            var Name = drug.ConflictedIssues.ElementAt(i).Name;
//            DCI.Add(new DrugConflicedIssuesDto(Id, Name));
//        }


//        allDrugs.Add(new AllDrugDto(drug.Id, drug.Name, drug.TakingMethod, DTI, DCI));
//    }
//    return allDrugs;
//}