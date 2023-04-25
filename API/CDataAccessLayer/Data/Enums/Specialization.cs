using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Data.Enums
{

    public enum Specialization
    {
        [Description("Cardiologist")]
        Cardiologist,
        [Description("Dermatologist")]
        Dermatologist,
        [Description("Endocrinologist")]
        Endocrinologist,
        [Description("Gastroenterologist")]
        Gastroenterologist,
        [Description("Hematologist")]
        Hematologist,
        [Description("Neurologist")]
        Neurologist,
        [Description("Oncologist")]
        Oncologist,
        [Description("Ophthalmologist")]
        Ophthalmologist,
        
        [Description("Orthopedist")]
        Orthopedist,
        [Description("Otolaryngologist")]
        Otolaryngologist,
        [Description("Pediatrician")]
        Pediatrician,
        [Description("Psychiatrist")]
        Psychiatrist,
        [Description("Pulmonologist")]
        Pulmonologist,
        [Description("Radiologist")]
        Radiologist,
        [Description("Urologist")]
        Urologist
    }


}

