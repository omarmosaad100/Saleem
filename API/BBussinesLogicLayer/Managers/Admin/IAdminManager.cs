﻿using BBussinesLogicLayer.Dtos;
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

        public HashSet<AllDrugsDto> GetDrugList();

        public int AddIssue(IssueDto issueDto);
        public int AddLicense(LicenseDto licenseDto);
    }
}
