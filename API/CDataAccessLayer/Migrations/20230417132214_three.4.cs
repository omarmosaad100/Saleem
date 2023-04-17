using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class three4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TakingMethod",
                table: "Drugs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TakingMethod",
                table: "Drugs");
        }
    }
}
