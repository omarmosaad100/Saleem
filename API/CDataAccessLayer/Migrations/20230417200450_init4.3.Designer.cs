﻿// <auto-generated />
using System;
using CDataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CDataAccessLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230417200450_init4.3")]
    partial class init43
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppointmentDetailsDrug", b =>
                {
                    b.Property<Guid>("AppointmentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DescribedDrugsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AppointmentsId", "DescribedDrugsId");

                    b.HasIndex("DescribedDrugsId");

                    b.ToTable("AppointmentDetailsDrug");
                });

            modelBuilder.Entity("AppointmentDetailsIssue", b =>
                {
                    b.Property<Guid>("AppointmentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DiagnosedIssuesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AppointmentsId", "DiagnosedIssuesId");

                    b.HasIndex("DiagnosedIssuesId");

                    b.ToTable("AppointmentDetailsIssue");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.AppointmentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(2,1)");

                    b.HasKey("Id");

                    b.HasIndex("DId");

                    b.HasIndex("PId");

                    b.ToTable("AppointmentDetails");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.Doctor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Specialization")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.Drug", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TakingMethod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Drugs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("787a6c6d-58d9-41b7-89db-83a12ff9c35a"),
                            Name = "Ibuprofen",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("371c7ffd-f947-427c-8a3c-5e9afe769eb5"),
                            Name = "Paracetamol",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("e449d4c8-e17d-4ab1-a3c2-95451f698f57"),
                            Name = "Amoxicillin",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("0753c779-f910-4ead-b21b-0a26576644fd"),
                            Name = "Azithromycin",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("e0f4eef9-deed-47b2-8395-019acd27231a"),
                            Name = "Prednisone",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("7b8ce30d-8c6d-4db6-bd95-0260428d9df8"),
                            Name = "Ventolin",
                            TakingMethod = 2
                        },
                        new
                        {
                            Id = new Guid("f2e81009-d13c-4aa4-a7bc-9853d425d9bc"),
                            Name = "Epinephrine",
                            TakingMethod = 1
                        },
                        new
                        {
                            Id = new Guid("1a593f76-98e5-4705-bdd4-a4780adc1b96"),
                            Name = "Lidocaine",
                            TakingMethod = 3
                        },
                        new
                        {
                            Id = new Guid("ff4b386f-511e-4dca-b78d-62f8a6af5959"),
                            Name = "Morphine",
                            TakingMethod = 1
                        },
                        new
                        {
                            Id = new Guid("9cfaef96-5bc9-4562-9e63-e27c0201f8d1"),
                            Name = "Ativan",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("41958159-e275-4653-abac-b4a01629bc67"),
                            Name = "Prozac",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("29dcdbb0-7595-455a-8d51-f1b227127daf"),
                            Name = "Zoloft",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("096ec582-3e3c-4c83-93a2-a21d67b37bef"),
                            Name = "Xanax",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("1eebf3e6-7dc7-438d-afe7-d7d97d69aad0"),
                            Name = "Lorazepam",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("f57ea926-6c8f-4c4e-8908-19ee89bb6375"),
                            Name = "Valium",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("3e095c20-14a6-4f4e-b736-f67ec7ccbd1b"),
                            Name = "Codeine",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("d4b8c723-5c8a-48b2-b411-69c3e1e8a8c1"),
                            Name = "Methadone",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("4b6b4d1d-87b5-4569-9fd9-26753b44fd88"),
                            Name = "Oxycodone",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("c3a829a9-bba9-4a04-85fb-14fa991ddb92"),
                            Name = "Hydrocodone",
                            TakingMethod = 0
                        },
                        new
                        {
                            Id = new Guid("baab02f2-6996-448d-9f24-1a93303971c9"),
                            Name = "Fentanyl",
                            TakingMethod = 1
                        });
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.Issue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Issues");

                    b.HasData(
                        new
                        {
                            Id = new Guid("997f7f94-2997-4d8a-a8cd-c3009faeb7a8"),
                            Name = "Headache"
                        },
                        new
                        {
                            Id = new Guid("3b140f88-f3f5-49bf-8be0-4f42bcfa1a8f"),
                            Name = "Fever"
                        },
                        new
                        {
                            Id = new Guid("f4e7cf3c-02d6-40c9-8cbd-f62c37aebbfe"),
                            Name = "Cough"
                        },
                        new
                        {
                            Id = new Guid("87850ccc-4b32-47b4-9ea4-66b314fe2897"),
                            Name = "Sore throat"
                        },
                        new
                        {
                            Id = new Guid("cfa60675-c4a8-4591-8dd5-a078fbc7bfde"),
                            Name = "Back pain"
                        },
                        new
                        {
                            Id = new Guid("c922d4a1-ab48-43cc-84dc-fcb04a9f42a1"),
                            Name = "Joint pain"
                        },
                        new
                        {
                            Id = new Guid("1967e6a5-30d0-41de-a854-7500ae554719"),
                            Name = "Allergies"
                        },
                        new
                        {
                            Id = new Guid("4ab2b469-63c0-477e-9e86-ef5134cbbe78"),
                            Name = "High blood pressure"
                        },
                        new
                        {
                            Id = new Guid("88aba024-beea-4158-b666-9d2d2e371100"),
                            Name = "Depression"
                        },
                        new
                        {
                            Id = new Guid("6982ed99-f0f5-49b1-9636-b6cdc1e785c5"),
                            Name = "Anxiety"
                        });
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.Patient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.PatientsDrugs", b =>
                {
                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("DrugId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Dosage")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TimesPerDay")
                        .HasColumnType("int");

                    b.HasKey("PatientId", "DrugId")
                        .HasName("PK_PatientDrugs");

                    b.HasIndex("DrugId");

                    b.ToTable("PatientsDrugs");
                });

            modelBuilder.Entity("DrugIssue", b =>
                {
                    b.Property<Guid>("ConflictedIssuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConflictingDrugsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ConflictedIssuesId", "ConflictingDrugsId");

                    b.HasIndex("ConflictingDrugsId");

                    b.ToTable("Conflicts", (string)null);
                });

            modelBuilder.Entity("DrugIssue1", b =>
                {
                    b.Property<Guid>("TreatedIssuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TreatmentDrugsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TreatedIssuesId", "TreatmentDrugsId");

                    b.HasIndex("TreatmentDrugsId");

                    b.ToTable("IssuesTreatment", (string)null);
                });

            modelBuilder.Entity("IssuePatient", b =>
                {
                    b.Property<Guid>("IssuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PatientsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IssuesId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("IssuePatient");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AppointmentDetailsDrug", b =>
                {
                    b.HasOne("CDataAccessLayer.Data.Models.AppointmentDetails", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDataAccessLayer.Data.Models.Drug", null)
                        .WithMany()
                        .HasForeignKey("DescribedDrugsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppointmentDetailsIssue", b =>
                {
                    b.HasOne("CDataAccessLayer.Data.Models.AppointmentDetails", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDataAccessLayer.Data.Models.Issue", null)
                        .WithMany()
                        .HasForeignKey("DiagnosedIssuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.AppointmentDetails", b =>
                {
                    b.HasOne("CDataAccessLayer.Data.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DId");

                    b.HasOne("CDataAccessLayer.Data.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.Doctor", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.Patient", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.PatientsDrugs", b =>
                {
                    b.HasOne("CDataAccessLayer.Data.Models.Drug", "Drug")
                        .WithMany("Patients")
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDataAccessLayer.Data.Models.Patient", "Patient")
                        .WithMany("Drugs")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drug");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DrugIssue", b =>
                {
                    b.HasOne("CDataAccessLayer.Data.Models.Issue", null)
                        .WithMany()
                        .HasForeignKey("ConflictedIssuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDataAccessLayer.Data.Models.Drug", null)
                        .WithMany()
                        .HasForeignKey("ConflictingDrugsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrugIssue1", b =>
                {
                    b.HasOne("CDataAccessLayer.Data.Models.Issue", null)
                        .WithMany()
                        .HasForeignKey("TreatedIssuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDataAccessLayer.Data.Models.Drug", null)
                        .WithMany()
                        .HasForeignKey("TreatmentDrugsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IssuePatient", b =>
                {
                    b.HasOne("CDataAccessLayer.Data.Models.Issue", null)
                        .WithMany()
                        .HasForeignKey("IssuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CDataAccessLayer.Data.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.Drug", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("CDataAccessLayer.Data.Models.Patient", b =>
                {
                    b.Navigation("Drugs");
                });
#pragma warning restore 612, 618
        }
    }
}
