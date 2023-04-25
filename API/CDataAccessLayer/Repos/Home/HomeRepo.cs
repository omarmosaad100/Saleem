using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Repos.Home
{
    public class HomeRepo:IHomeRepo
    {
        public ICollection<string> GetAllSpecializations()
        {
            return new List<string>()
            {
                "Cardiologist",
                "Dermatologist",
                "Endocrinologist",
                "Gastroenterologist",
                "Hematologist",
                "Neurologist",
                "Oncologist",
                "Ophthalmologist",

                "Orthopedist",
                "Otolaryngologist",
                "Pediatrician",
                "Psychiatrist",
                "Pulmonologist",
                "Radiologist",
                "Urologist"

            };
        }

    }
}
