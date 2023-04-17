using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_AspNetUsers_UserId",
                table: "patients");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "patients",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_AspNetUsers_Id",
                table: "patients",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_AspNetUsers_Id",
                table: "patients");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "patients",
                newName: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_AspNetUsers_UserId",
                table: "patients",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
