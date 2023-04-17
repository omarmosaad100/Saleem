using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class three2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrugIssue_Drugs_ConflictingDrugsId",
                table: "DrugIssue");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugIssue_Issues_ConflictedIssuesId",
                table: "DrugIssue");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugIssue1_Drugs_TreatmentDrugsId",
                table: "DrugIssue1");

            migrationBuilder.DropForeignKey(
                name: "FK_DrugIssue1_Issues_TreatedIssuesId",
                table: "DrugIssue1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugIssue1",
                table: "DrugIssue1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugIssue",
                table: "DrugIssue");

            migrationBuilder.RenameTable(
                name: "DrugIssue1",
                newName: "IssuesTreatment");

            migrationBuilder.RenameTable(
                name: "DrugIssue",
                newName: "Conflicts");

            migrationBuilder.RenameIndex(
                name: "IX_DrugIssue1_TreatmentDrugsId",
                table: "IssuesTreatment",
                newName: "IX_IssuesTreatment_TreatmentDrugsId");

            migrationBuilder.RenameIndex(
                name: "IX_DrugIssue_ConflictingDrugsId",
                table: "Conflicts",
                newName: "IX_Conflicts_ConflictingDrugsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IssuesTreatment",
                table: "IssuesTreatment",
                columns: new[] { "TreatedIssuesId", "TreatmentDrugsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conflicts",
                table: "Conflicts",
                columns: new[] { "ConflictedIssuesId", "ConflictingDrugsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Conflicts_Drugs_ConflictingDrugsId",
                table: "Conflicts",
                column: "ConflictingDrugsId",
                principalTable: "Drugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conflicts_Issues_ConflictedIssuesId",
                table: "Conflicts",
                column: "ConflictedIssuesId",
                principalTable: "Issues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IssuesTreatment_Drugs_TreatmentDrugsId",
                table: "IssuesTreatment",
                column: "TreatmentDrugsId",
                principalTable: "Drugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IssuesTreatment_Issues_TreatedIssuesId",
                table: "IssuesTreatment",
                column: "TreatedIssuesId",
                principalTable: "Issues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conflicts_Drugs_ConflictingDrugsId",
                table: "Conflicts");

            migrationBuilder.DropForeignKey(
                name: "FK_Conflicts_Issues_ConflictedIssuesId",
                table: "Conflicts");

            migrationBuilder.DropForeignKey(
                name: "FK_IssuesTreatment_Drugs_TreatmentDrugsId",
                table: "IssuesTreatment");

            migrationBuilder.DropForeignKey(
                name: "FK_IssuesTreatment_Issues_TreatedIssuesId",
                table: "IssuesTreatment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IssuesTreatment",
                table: "IssuesTreatment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conflicts",
                table: "Conflicts");

            migrationBuilder.RenameTable(
                name: "IssuesTreatment",
                newName: "DrugIssue1");

            migrationBuilder.RenameTable(
                name: "Conflicts",
                newName: "DrugIssue");

            migrationBuilder.RenameIndex(
                name: "IX_IssuesTreatment_TreatmentDrugsId",
                table: "DrugIssue1",
                newName: "IX_DrugIssue1_TreatmentDrugsId");

            migrationBuilder.RenameIndex(
                name: "IX_Conflicts_ConflictingDrugsId",
                table: "DrugIssue",
                newName: "IX_DrugIssue_ConflictingDrugsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugIssue1",
                table: "DrugIssue1",
                columns: new[] { "TreatedIssuesId", "TreatmentDrugsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugIssue",
                table: "DrugIssue",
                columns: new[] { "ConflictedIssuesId", "ConflictingDrugsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DrugIssue_Drugs_ConflictingDrugsId",
                table: "DrugIssue",
                column: "ConflictingDrugsId",
                principalTable: "Drugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrugIssue_Issues_ConflictedIssuesId",
                table: "DrugIssue",
                column: "ConflictedIssuesId",
                principalTable: "Issues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrugIssue1_Drugs_TreatmentDrugsId",
                table: "DrugIssue1",
                column: "TreatmentDrugsId",
                principalTable: "Drugs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrugIssue1_Issues_TreatedIssuesId",
                table: "DrugIssue1",
                column: "TreatedIssuesId",
                principalTable: "Issues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
