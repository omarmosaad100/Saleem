using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class three3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentDetailsDrug",
                columns: table => new
                {
                    AppointmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescribedDrugsId = table.Column<int>(type: "int", nullable: false)
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
                    DiagnosedIssuesId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetailsDrug_DescribedDrugsId",
                table: "AppointmentDetailsDrug",
                column: "DescribedDrugsId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetailsIssue_DiagnosedIssuesId",
                table: "AppointmentDetailsIssue",
                column: "DiagnosedIssuesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentDetailsDrug");

            migrationBuilder.DropTable(
                name: "AppointmentDetailsIssue");
        }
    }
}
