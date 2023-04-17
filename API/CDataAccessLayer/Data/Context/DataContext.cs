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
            //            // Associate Drugs with Issues
            //            builder.Entity<Drug>()
            //.HasMany(d => d.TreatedIssues)
            //.WithMany(i => i.TreatmentDrugs)
            //.UsingEntity(j => j.ToTable("IssuesTreatment")
            //.HasData(
            //    new { DrugsId = new Guid("b23d1c4c-4c4b-4d4b-a4f2-6c4bf6f7c9e1"), IssuesId = new Guid("04f5b7f8-1fb5-4170-9ae1-1f8d9f2adc0d") },
            //    new { DrugsId = new Guid("d3e1a64f-5c5b-44a0-9ab7-5e5d5d5f5d5f"), IssuesId = new Guid("1e719a38-8b9d-4d5f-a0a7-7d8a1e0c72eb") },
            //    new { DrugsId = new Guid("fd599d2f-4e4e-4d8b-9924-0e68b0c874e7"), IssuesId = new Guid("c6f1e40e-83ee-4b6f-a7e3-3aaf2b6f9c6c") },
            //    new { DrugsId = new Guid("fd599d2f-4e4e-4d8b-9924-0e68b0c874e7"), IssuesId = new Guid("04f5b7f8-1fb5-4170-9ae1-1f8d9f2adc0d") },
            //    new { DrugsId = new Guid("fd599d2f-4e4e-4d8b-9924-0e68b0c874e7"), IssuesId = new Guid("c6f1e40e-83ee-4b6f-a7e3-3aaf2b6f9c6c") },
            //    new { DrugsId = new Guid("fd599d2f-4e4e-4d8b-9924-0e68b0c874e7"), IssuesId = new Guid("1e719a38-8b9d-4d5f-a0a7-7d8a1e0c72eb") },
            //    new { DrugsId = new Guid("d3e1a64f-5c5b-44a0-9ab7-5e5d5d5f5d5f"), IssuesId = new Guid("c6f1e40e-83ee-4b6f-a7e3-3aaf2b6f9c6c") },
            //    new { DrugsId = new Guid("b23d1c4c-4c4b-4d4b-a4f2-6c4bf6f7c9e1"), IssuesId = new Guid("c6f1e40e-83ee-4b6f-a7e3-3aaf2b6f9c6c") },
            //    new { DrugsId = new Guid("b23d1c4c-4c4b-4d4b-a4f2-6c4bf6f7c9e1"), IssuesId = new Guid("1e719a38-8b9d-4d5f-a0a7-7d8a1e0c72eb") },
            //    new { DrugsId = new Guid("d3e1a64f-5c5b-44a0-9ab7-5e5d5d5f5d5f"), IssuesId = new Guid("04f5b7f8-1fb5-4170-9ae1-1f8d9f2adc0d") },
            //    new { DrugsId = new Guid("fd599d2f-4e4e-4d8b-9924-0e68b0c874e7"), IssuesId = new Guid("7d7887a6-1c6d-4c87-9ee4-4d4ad4d4ad4d") },
            //    new { DrugsId = new Guid("d3e1a64f-5c5b-44a0-9ab7-5e5d5d5f5d5f"), IssuesId = new Guid("7d7887a6-1c6d-4c87-9ee4-4d4ad4d4ad4d") },
            //    new { DrugsId = new Guid("b23d1c4c-4c4b-4d4b-a4f2-6c4bf6f7c9e1"), IssuesId = new Guid("7d7887a6-1c6d-4c87-9ee4-4d4ad4d4ad4d") }
            //));


        }
        public DbSet<Patient> patients { get; set; }
        public DbSet<AppointmentDetails> AppointmentDetails { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<PatientsDrugs> PatientsDrugs { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

    }
}
