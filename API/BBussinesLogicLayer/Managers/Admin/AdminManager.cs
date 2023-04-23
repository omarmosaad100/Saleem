using AutoMapper;
using BBussinesLogicLayer.Dtos;
using BBussinesLogicLayer.Dtos.Admin;
using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using CDataAccessLayer.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        #region Drugs
        public int AddNewDrug(NewDrugDto drugDto)
        {
            Drug NewDrug = new Drug();
            NewDrug.Name = drugDto.Name;
            NewDrug.Id = Guid.NewGuid();
            NewDrug.TakingMethod = drugDto.Method;

            HashSet<Issue> issues = _AdminRepo.GetIssueList();

            if (drugDto.TreatedIssuesIds?.Length > 0)
            {
                var TreatedIssues = issues.Where(i => drugDto.TreatedIssuesIds.Contains(i.Id)).ToList();
                NewDrug.TreatedIssues = TreatedIssues;
            }
            if (drugDto.ConflictedIssuesIds?.Length > 0)
            {
                var ConflictedIssues = issues.Where(i => drugDto.ConflictedIssuesIds.Contains(i.Id)).ToList();
                NewDrug.ConflictedIssues = ConflictedIssues;
            }

            return _AdminRepo.AddDrug(NewDrug);
        }

        public HashSet<DrugsDto> GetDrugList()
        {
            var allDrugs = _AdminRepo.GetDrugList();

            return _mapper.Map<HashSet<DrugsDto>>(allDrugs);
        }

        public DrugsDto? GetDrug(Guid id)
        {
            var drug = _AdminRepo.GedDrug(id);

            if (drug == null)
                return null;
            return _mapper.Map<DrugsDto>(drug);

        }

        public int DeleteDrug(Guid id)
        {
            return _AdminRepo.DeleteDrug(id);
        }

        public int UpdateDrug(NewDrugDto drug, Guid id)
        {
            Drug NewDrug = new Drug();
            NewDrug.Id = id;
            NewDrug.Name = drug.Name;
            NewDrug.TakingMethod = drug.Method;

            NewDrug.TreatedIssues = new Collection<Issue>();
            NewDrug.ConflictedIssues = new Collection<Issue>();

            if (drug.TreatedIssuesIds != null || drug.ConflictedIssuesIds != null)
            {
                HashSet<Issue> issues = _AdminRepo.GetIssueList();

                if (drug.TreatedIssuesIds?.Length > 0)
                {
                    var TreatedIssues = issues.Where(i => drug.TreatedIssuesIds.Contains(i.Id)).ToList();
                    NewDrug.TreatedIssues = TreatedIssues;
                }
                if (drug.ConflictedIssuesIds?.Length > 0)
                {
                    var ConflictedIssues = issues.Where(i => drug.ConflictedIssuesIds.Contains(i.Id)).ToList();
                    NewDrug.ConflictedIssues = ConflictedIssues;
                }
            }

            return _AdminRepo.UpdateDrug(NewDrug);
        }
        #endregion

        #region Issues
        public int AddIssue(string issueName)
        {
            if (issueName == null)
                return 0;

            Issue newIssue = new();

            newIssue.Id = Guid.NewGuid();
            newIssue.Name = issueName;

            return _AdminRepo.AddIssue(newIssue);

        }
        #endregion

        #region Licenses
        public int AddLicense(LicenseDto licenseDto)
        {
            if (licenseDto == null)
                return 0;

            License newLicense = new();

            newLicense.Id = Guid.NewGuid();
            newLicense.NationalId = licenseDto.NationalId;

            return _AdminRepo.AddLicense(newLicense);
        }
        #endregion

        #region Doctors
        public HashSet<DoctorDto> GetAllDoctors()
        {
            var allDoctors = _AdminRepo.GetAllDoctors();

            return _mapper.Map<HashSet<DoctorDto>>(allDoctors);
        }

        public int DeleteDoctor(string id)
        {
            return _AdminRepo.DeleteDoctor(id);
        }
        #endregion
    }
}


//Mapping the hard way
//public HashSet<AllDrugDto> das()
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

