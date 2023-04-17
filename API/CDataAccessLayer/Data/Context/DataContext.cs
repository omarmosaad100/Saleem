using CDataAccessLayer.Data.Enums;
using CDataAccessLayer.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CDataAccessLayer.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Drug>()
         .HasMany(d => d.TreatedIssues)
         .WithMany(i => i.TreatmentDrugs)
         .UsingEntity(j => j.ToTable("IssuesTreatment"));

            builder.Entity<Drug>()
                .HasMany(d => d.ConflictedIssues)
                .WithMany(i => i.ConflictingDrugs)
                .UsingEntity(j => j.ToTable("Conflicts"));

            builder.Entity<PatientsDrugs>()
                   .HasKey(pd => new { pd.PatientId, pd.DrugId })
                   .HasName("PK_PatientDrugs");

            builder.Entity<Issue>().HasData(
                new Issue { Id = Guid.NewGuid(), Name = "Headache" },
                new Issue { Id = Guid.NewGuid(), Name = "Fever" },
                new Issue { Id = Guid.NewGuid(), Name = "Cough" },
                new Issue { Id = Guid.NewGuid(), Name = "Sore throat" },
                new Issue { Id = Guid.NewGuid(), Name = "Back pain" },
                new Issue { Id = Guid.NewGuid(), Name = "Joint pain" },
                new Issue { Id = Guid.NewGuid(), Name = "Allergies" },
                new Issue { Id = Guid.NewGuid(), Name = "High blood pressure" },
                new Issue { Id = Guid.NewGuid(), Name = "Depression" },
                new Issue { Id = Guid.NewGuid(), Name = "Anxiety" }
            );
            // Add sample Drugs
            builder.Entity<Drug>().HasData(
                new Drug { Id = Guid.NewGuid(), Name = "Ibuprofen", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Paracetamol", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Amoxicillin", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Azithromycin", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Prednisone", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Ventolin", TakingMethod = DrugTakingMethod.Inhalation },
                new Drug { Id = Guid.NewGuid(), Name = "Epinephrine", TakingMethod = DrugTakingMethod.Injection },
                new Drug { Id = Guid.NewGuid(), Name = "Lidocaine", TakingMethod = DrugTakingMethod.External },
                new Drug { Id = Guid.NewGuid(), Name = "Morphine", TakingMethod = DrugTakingMethod.Injection },
                new Drug { Id = Guid.NewGuid(), Name = "Ativan", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Prozac", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Zoloft", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Xanax", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Lorazepam", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Valium", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Codeine", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Methadone", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Oxycodone", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Hydrocodone", TakingMethod = DrugTakingMethod.Oral },
                new Drug { Id = Guid.NewGuid(), Name = "Fentanyl", TakingMethod = DrugTakingMethod.Injection }
            );
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<AppointmentDetails> AppointmentDetails { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<PatientsDrugs> PatientsDrugs { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

    }
}
