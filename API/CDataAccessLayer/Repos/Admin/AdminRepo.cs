﻿using CDataAccessLayer.Data;
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

        public Drug? GedDrug(Guid id)
        {
            return _context.Drugs
                .Include(d => d.ConflictedIssues)
                .Include(d => d.TreatedIssues)
                .FirstOrDefault(d => d.Id == id);
        }

        public int DeleteDrug(Guid id)
        {
            var drug = _context.Drugs.FirstOrDefault(d => d.Id == id);

            if (drug == null)
            {
                return 0;
            }

            _context.Drugs.Remove(drug);
            return _context.SaveChanges();
        }

        public int UpdateDrug(Drug newDrug)
        {
            var OldDrug = _context.Drugs.FirstOrDefault(d => d.Id == newDrug.Id);
            if(OldDrug == null)
            {
                return 0;
            }

            OldDrug.Name = newDrug.Name;
            OldDrug.TakingMethod = newDrug.TakingMethod;
            OldDrug.TreatedIssues = newDrug.TreatedIssues;
            OldDrug.ConflictedIssues = newDrug.ConflictedIssues;

            _context.Drugs.Update(OldDrug);
            return _context.SaveChanges();
        }
    }
}
