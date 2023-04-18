using BBussinesLogicLayer.Dtos;
using BBussinesLogicLayer.Dtos.Admin;
using CDataAccessLayer.Data.Models;
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

        public int AddIssue(IssueDto issueDto);

        public int AddLicense(LicenseDto licenseDto);

        public DrugsDto? GetDrug(Guid id);

        public int DeleteDrug(Guid id);
    }
}
