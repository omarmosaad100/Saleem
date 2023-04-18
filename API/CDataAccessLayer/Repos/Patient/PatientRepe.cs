using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos.Patient
{
    public class PatientRepe : IPatientRepo
    {
        private readonly DataContext _context;

        public PatientRepe(DataContext context)
        {
            _context = context;
        }

        public National? GetNational(string Id) => _context.nationalIds.FirstOrDefault(i => i.Id == Id);
        public ICollection<National> GetAllNationals() => _context.nationalIds.ToList();

    }
}
