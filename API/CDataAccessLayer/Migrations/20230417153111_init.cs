using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakingMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Specialization = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NationalID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patients_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conflicts",
                columns: table => new
                {
                    ConflictedIssuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConflictingDrugsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conflicts", x => new { x.ConflictedIssuesId, x.ConflictingDrugsId });
                    table.ForeignKey(
                        name: "FK_Conflicts_Drugs_ConflictingDrugsId",
                        column: x => x.ConflictingDrugsId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conflicts_Issues_ConflictedIssuesId",
                        column: x => x.ConflictedIssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssuesTreatment",
                columns: table => new
                {
                    TreatedIssuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentDrugsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuesTreatment", x => new { x.TreatedIssuesId, x.TreatmentDrugsId });
                    table.ForeignKey(
                        name: "FK_IssuesTreatment_Drugs_TreatmentDrugsId",
                        column: x => x.TreatmentDrugsId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuesTreatment_Issues_TreatedIssuesId",
                        column: x => x.TreatedIssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_Doctors_DId",
                        column: x => x.DId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_patients_PId",
                        column: x => x.PId,
                        principalTable: "patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IssuePatient",
                columns: table => new
                {
                    IssuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuePatient", x => new { x.IssuesId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_IssuePatient_Issues_IssuesId",
                        column: x => x.IssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuePatient_patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientsDrugs",
                columns: table => new
                {
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DrugId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TimesPerDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDrugs", x => new { x.PatientId, x.DrugId });
                    table.ForeignKey(
                        name: "FK_PatientsDrugs_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientsDrugs_patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDetailsDrug",
                columns: table => new
                {
                    AppointmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescribedDrugsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetailsDrug", x => new { x.AppointmentsId, x.DescribedDrugsId });
                    table.ForeignKey(
                        name: "FK_AppointmentDetailsDrug_AppointmentDetails_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalTable: "AppointmentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentDetailsDrug_Drugs_DescribedDrugsId",
                        column: x => x.DescribedDrugsId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDetailsIssue",
                columns: table => new
                {
                    AppointmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiagnosedIssuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetailsIssue", x => new { x.AppointmentsId, x.DiagnosedIssuesId });
                    table.ForeignKey(
                        name: "FK_AppointmentDetailsIssue_AppointmentDetails_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalTable: "AppointmentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentDetailsIssue_Issues_DiagnosedIssuesId",
                        column: x => x.DiagnosedIssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("1722353b-1136-4cfc-80f4-62e5d2703db9"), "Codeine", 0 },
                    { new Guid("1afeca7e-1db0-42a6-9ce3-6518226c7125"), "Xanax", 0 },
                    { new Guid("41e53da3-7229-4dc4-9e5d-5f485cc92c58"), "Ibuprofen", 0 },
                    { new Guid("457fb061-57f0-4f0d-b4fc-0980907ce59e"), "Methadone", 0 },
                    { new Guid("48df3cff-a436-4db7-81e4-29d6a45f034b"), "Zoloft", 0 },
                    { new Guid("49563c11-9b80-4c75-92ee-42daad37c59b"), "Valium", 0 },
                    { new Guid("4c60077e-da06-4515-b43a-7cef89a4cfbf"), "Fentanyl", 1 },
                    { new Guid("504774b6-7103-427c-ba56-45ef7b9a3209"), "Amoxicillin", 0 },
                    { new Guid("598a943d-43fa-4fd4-b41b-2bcddc8af37f"), "Epinephrine", 1 },
                    { new Guid("5c10872b-6dfe-463e-ad0f-288a161b7d81"), "Prozac", 0 },
                    { new Guid("6e1a3191-8d74-48da-9144-50c4ff5a9dc5"), "Oxycodone", 0 },
                    { new Guid("89e7f9f3-5976-40c2-8e9b-381a0a21f572"), "Morphine", 1 },
                    { new Guid("9410c4cf-eadb-49d2-b6e9-2c61b8061769"), "Paracetamol", 0 },
                    { new Guid("a400cea9-7b01-4633-989b-7b142180a4be"), "Ventolin", 2 },
                    { new Guid("bdbe56a1-5506-41ee-a0c1-ee6de663533e"), "Prednisone", 0 },
                    { new Guid("c14e5e09-c9f2-4dca-9339-5e377e38f10f"), "Azithromycin", 0 },
                    { new Guid("d4dd3b2b-eedc-47c4-bf38-3c7988ca9b0e"), "Hydrocodone", 0 },
                    { new Guid("db29b672-5b3a-4e3f-9ba3-dfb4fa82ae0e"), "Ativan", 0 },
                    { new Guid("f1f97818-1578-4dbc-863c-ec25dd220acb"), "Lidocaine", 3 },
                    { new Guid("fcd97e84-04a2-45d2-bf6d-8b7646006184"), "Lorazepam", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("32f27a9f-15c4-4a05-b13f-b53a378f9546"), "Allergies" },
                    { new Guid("6f469697-6427-4573-80da-9b524e2dab07"), "Cough" },
                    { new Guid("83b6e92a-a16d-46dc-aac9-bed820369f09"), "Sore throat" },
                    { new Guid("910096b7-ab55-44ac-b583-dd816b8816a4"), "Back pain" },
                    { new Guid("ba7b9ea0-cbe9-4464-ace7-388d3730e8a8"), "Fever" },
                    { new Guid("c609f276-e48a-4528-85e8-2d1308d57cbf"), "Anxiety" },
                    { new Guid("c73d279a-0053-49bc-b121-e9c104151536"), "High blood pressure" },
                    { new Guid("ce4a6680-767f-4fae-ba19-b4b591ac5263"), "Headache" },
                    { new Guid("d8925c40-9a83-4fdd-8af8-86efe2a47e8d"), "Joint pain" },
                    { new Guid("e72189f1-2a55-42b5-b170-8fb6992c3b92"), "Depression" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_DId",
                table: "AppointmentDetails",
                column: "DId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_PId",
                table: "AppointmentDetails",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetailsDrug_DescribedDrugsId",
                table: "AppointmentDetailsDrug",
                column: "DescribedDrugsId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetailsIssue_DiagnosedIssuesId",
                table: "AppointmentDetailsIssue",
                column: "DiagnosedIssuesId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Conflicts_ConflictingDrugsId",
                table: "Conflicts",
                column: "ConflictingDrugsId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuePatient_PatientsId",
                table: "IssuePatient",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuesTreatment_TreatmentDrugsId",
                table: "IssuesTreatment",
                column: "TreatmentDrugsId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsDrugs_DrugId",
                table: "PatientsDrugs",
                column: "DrugId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentDetailsDrug");

            migrationBuilder.DropTable(
                name: "AppointmentDetailsIssue");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Conflicts");

            migrationBuilder.DropTable(
                name: "IssuePatient");

            migrationBuilder.DropTable(
                name: "IssuesTreatment");

            migrationBuilder.DropTable(
                name: "PatientsDrugs");

            migrationBuilder.DropTable(
                name: "AppointmentDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
