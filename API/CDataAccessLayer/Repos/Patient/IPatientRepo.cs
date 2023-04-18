using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos.Patient
{
    public interface IPatientRepo
    {
        public ICollection<National> GetAllNationals();
        public National? GetNational(string Id);

    }
}
