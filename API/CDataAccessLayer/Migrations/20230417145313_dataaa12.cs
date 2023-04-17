using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class dataaa12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("1f4882a5-ac92-4c94-9c01-25ee217cacb0"), "Prozac", 0 },
                    { new Guid("3443370c-0be1-457f-b0fa-8248251a998c"), "Zoloft", 0 },
                    { new Guid("3f521eac-a5a0-47c5-b675-fd4bb7873d5e"), "Methadone", 0 },
                    { new Guid("4742bb67-ac9b-4388-b362-ded34a29b9d9"), "Amoxicillin", 0 },
                    { new Guid("5504f30f-55b7-44c2-a359-c87c72c0f1b8"), "Ativan", 0 },
                    { new Guid("571b1163-7e0b-475d-8768-56c9e1d1cb86"), "Codeine", 0 },
                    { new Guid("6324fff9-5f4a-428f-8c10-fb9550b8e1e2"), "Lorazepam", 0 },
                    { new Guid("6939b44e-c0e8-4bec-9b06-d437ffdca84d"), "Valium", 0 },
                    { new Guid("6e07ef01-1b0a-43a5-9ba3-3f1f820b6efc"), "Xanax", 0 },
                    { new Guid("79e5201e-edd5-4b40-af46-a7175a4eb2be"), "Morphine", 1 },
                    { new Guid("88e717ba-b830-4387-a819-49cb6bdbfe18"), "Paracetamol", 0 },
                    { new Guid("92ecdbbf-2dff-47df-943d-eca7b7e04650"), "Ibuprofen", 0 },
                    { new Guid("a4da5c7b-a10f-418e-820a-e1b3be1138e8"), "Hydrocodone", 0 },
                    { new Guid("ab98ad8d-9b2f-4d96-95e7-d547ddc5bba4"), "Azithromycin", 0 },
                    { new Guid("d0ab5e61-888b-465f-8c47-99f99e269267"), "Epinephrine", 1 },
                    { new Guid("d8d04ce0-0185-4c7d-ae5c-33e586544cc5"), "Lidocaine", 3 },
                    { new Guid("d8d21467-5f37-4813-8048-44fe1d66909e"), "Prednisone", 0 },
                    { new Guid("e38e6f0b-7121-44cf-957e-e45b23e1e6be"), "Oxycodone", 0 },
                    { new Guid("e83c6072-c300-481e-9f6c-1818deb2f8d7"), "Ventolin", 2 },
                    { new Guid("ef878ca5-aa60-4e0b-a351-b5b4b4f21426"), "Fentanyl", 1 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0fcb08f9-96c0-4ee6-a14c-939fd381f05f"), "Cough" },
                    { new Guid("2080478c-05ef-41eb-b3b1-935883523343"), "Depression" },
                    { new Guid("287e6050-6a07-4353-a4b5-9d0916cc4cb6"), "High blood pressure" },
                    { new Guid("36725b58-5509-4986-a2e4-9d2bc286a51c"), "Allergies" },
                    { new Guid("4bb9daab-48bf-49ad-95ae-58686db15ec3"), "Anxiety" },
                    { new Guid("62583bae-5a6a-434e-a365-385fffc51bf8"), "Joint pain" },
                    { new Guid("8b7a52a4-2545-4d65-b1f8-e58c57a89887"), "Headache" },
                    { new Guid("ce3e5b37-12a6-426b-8a62-7135b80387e1"), "Sore throat" },
                    { new Guid("cf1b937f-dc1b-47cc-a54b-79d80777b46b"), "Back pain" },
                    { new Guid("de6abefc-91e5-47a2-8ab7-5a5b547dc5b6"), "Fever" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1f4882a5-ac92-4c94-9c01-25ee217cacb0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3443370c-0be1-457f-b0fa-8248251a998c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3f521eac-a5a0-47c5-b675-fd4bb7873d5e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4742bb67-ac9b-4388-b362-ded34a29b9d9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5504f30f-55b7-44c2-a359-c87c72c0f1b8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("571b1163-7e0b-475d-8768-56c9e1d1cb86"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6324fff9-5f4a-428f-8c10-fb9550b8e1e2"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6939b44e-c0e8-4bec-9b06-d437ffdca84d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6e07ef01-1b0a-43a5-9ba3-3f1f820b6efc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("79e5201e-edd5-4b40-af46-a7175a4eb2be"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("88e717ba-b830-4387-a819-49cb6bdbfe18"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("92ecdbbf-2dff-47df-943d-eca7b7e04650"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a4da5c7b-a10f-418e-820a-e1b3be1138e8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ab98ad8d-9b2f-4d96-95e7-d547ddc5bba4"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d0ab5e61-888b-465f-8c47-99f99e269267"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d8d04ce0-0185-4c7d-ae5c-33e586544cc5"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d8d21467-5f37-4813-8048-44fe1d66909e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e38e6f0b-7121-44cf-957e-e45b23e1e6be"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e83c6072-c300-481e-9f6c-1818deb2f8d7"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ef878ca5-aa60-4e0b-a351-b5b4b4f21426"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("0fcb08f9-96c0-4ee6-a14c-939fd381f05f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("2080478c-05ef-41eb-b3b1-935883523343"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("287e6050-6a07-4353-a4b5-9d0916cc4cb6"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("36725b58-5509-4986-a2e4-9d2bc286a51c"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("4bb9daab-48bf-49ad-95ae-58686db15ec3"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("62583bae-5a6a-434e-a365-385fffc51bf8"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("8b7a52a4-2545-4d65-b1f8-e58c57a89887"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("ce3e5b37-12a6-426b-8a62-7135b80387e1"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("cf1b937f-dc1b-47cc-a54b-79d80777b46b"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("de6abefc-91e5-47a2-8ab7-5a5b547dc5b6"));
        }
    }
}
