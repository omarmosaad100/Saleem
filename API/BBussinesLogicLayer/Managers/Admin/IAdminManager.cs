using BBussinesLogicLayer.Dtos;
using BBussinesLogicLayer.Dtos.Admin;
using CDataAccessLayer.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Managers.Admin
{
    public interface IAdminManager
    {
        public int AddNewDrug(NewDrugDto drug);

        public HashSet<DrugsDto> GetDrugList();

        public int AddIssue(IssueDto issueName);

        public int AddLicense(LicenseDto licenseDto);

        public DrugsDto? GetDrug(Guid id);

        public int DeleteDrug(Guid id);

        public int UpdateDrug(NewDrugDto drug, Guid id);

        public HashSet<DoctorDto> GetAllDoctors();
        public int DeleteDoctor(string id);
        public HashSet<IssueDto> GetAllIssues();
        public Task<ActionResult<AdminTokenDto>> Login(AdminLoginDto loginDto);
        public Task<IdentityResult> Register(AdminLoginDto loginDto);
    }
}
