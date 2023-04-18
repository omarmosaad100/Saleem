using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
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

        public HashSet<Drug> GetDrugList()
        {

            return _context.Drugs
                .Include(d => d.ConflictedIssues)
                .Include(d => d.TreatedIssues)
                .ToHashSet<Drug>();

        }

        public HashSet<Issue> GetIssueList()
        {
            return _context.Issues.ToHashSet<Issue>();
        }


        public int AddIssue(Issue issue)
        {
            if (issue != null)
            {
                _context.Issues.Add(issue);
                return _context.SaveChanges();
            }
            return 0;
        }

        public int AddLicense(License license)
        {
            if (license != null)
            {
                _context.licenses.Add(license);
                return _context.SaveChanges();
            }
            return 0;
        }
    }
}
