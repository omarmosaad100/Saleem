using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;

namespace BBussinesLogicLayer.Dtos.Patients;

public class PatientIllnessDTO
{
    public Specialization Specialization { get; set; }

    public virtual ICollection<Issue> DiagnosedIssues { get; set; } = new HashSet<Issue>();

}