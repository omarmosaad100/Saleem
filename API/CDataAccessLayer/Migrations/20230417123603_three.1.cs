using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class three1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "AppointmentDetails",
                type: "decimal(2,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugIssue",
                columns: table => new
                {
                    ConflictedIssuesId = table.Column<int>(type: "int", nullable: false),
                    ConflictingDrugsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugIssue", x => new { x.ConflictedIssuesId, x.ConflictingDrugsId });
                    table.ForeignKey(
                        name: "FK_DrugIssue_Drugs_ConflictingDrugsId",
                        column: x => x.ConflictingDrugsId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugIssue_Issues_ConflictedIssuesId",
                        column: x => x.ConflictedIssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrugIssue1",
                columns: table => new
                {
                    TreatedIssuesId = table.Column<int>(type: "int", nullable: false),
                    TreatmentDrugsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugIssue1", x => new { x.TreatedIssuesId, x.TreatmentDrugsId });
                    table.ForeignKey(
                        name: "FK_DrugIssue1_Drugs_TreatmentDrugsId",
                        column: x => x.TreatmentDrugsId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugIssue1_Issues_TreatedIssuesId",
                        column: x => x.TreatedIssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrugIssue_ConflictingDrugsId",
                table: "DrugIssue",
                column: "ConflictingDrugsId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugIssue1_TreatmentDrugsId",
                table: "DrugIssue1",
                column: "TreatmentDrugsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrugIssue");

            migrationBuilder.DropTable(
                name: "DrugIssue1");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "AppointmentDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)");
        }
    }
}
