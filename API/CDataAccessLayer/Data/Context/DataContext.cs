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
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<AppointmentDetails> AppointmentDetails { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Issue> Issues { get; set; }

    }
}
