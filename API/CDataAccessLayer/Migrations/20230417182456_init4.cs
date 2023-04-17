using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("202ff3b0-b972-4e9f-8f90-9d055d8e6fcb"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("27195881-bd1f-4251-a737-51f343a6c7b8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3bb23697-3777-4a6c-b9bb-1282564a976d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("41647769-32d2-45fc-8758-df295eb06d47"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5cf1ccbf-fe45-422c-9042-0800d51d1f50"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("60ce2819-5705-486c-9686-4209cf1eaf1e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6243e709-d623-422e-80a2-88e7edb63c8d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("727c5e3d-956f-4d89-b60f-f72092b7d30a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("97a444ef-862a-4d2b-a3c7-aabbb19ada4b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("993c3bdd-e17c-4c56-9e79-131a86ef0edd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("99759b50-dbfc-451b-9dcc-7e6abfda5139"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9c8135d2-6920-46de-9ac2-25329334c8b3"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a660c51b-679c-46f9-9864-fe0eefa09833"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a9b5f13e-c0cd-46a8-a290-fa7fd82c7c6b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ad263f64-d7f7-4051-b1fd-d12c9d7532ab"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ae197415-3513-43c6-ac99-b3efa523ffff"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c4f29189-9de1-46aa-8794-cb256875f342"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d00be5b4-fb97-4d18-8a5d-9f96f260b1bc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ebea8e0f-5dee-43b1-b24f-edcf67dca466"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ecdf2e4c-cd14-43a9-95be-427686144521"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("00bccb02-d5ac-4226-824c-eb4f9b343776"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("43bcd990-5d53-49f0-98c2-d9cba26870fc"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("5703f941-7f06-40bb-aab1-2c8fd6c96a4b"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("5e06ef02-dcdf-4cc5-832f-55de2971dd9b"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("6dcc794e-9574-4bcd-af2d-5ec19fb9b6af"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("85ef02a3-f753-4405-ad7f-4f931598571f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("8f782514-e3bc-490e-a427-8f3c4414548d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("c501d9ee-649c-4866-b374-016a742ce473"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("d4393b2e-ade6-476a-bb26-5815652cec8b"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("f1be8e3f-c4c9-4e8e-8e72-459e26b36bf1"));

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("0396f0b2-a97e-4577-80c8-b60c19d32c53"), "Codeine", 0 },
                    { new Guid("04a305a9-f580-492f-ad30-c553797a8e35"), "Paracetamol", 0 },
                    { new Guid("079d53a6-4ecd-48ae-83e7-142b10569b4c"), "Ibuprofen", 0 },
                    { new Guid("1840af57-00be-4898-a597-299f83d500d9"), "Prednisone", 0 },
                    { new Guid("33b5b119-3751-4621-8032-2d2842a93d97"), "Hydrocodone", 0 },
                    { new Guid("4ae9b8c3-d320-496f-9cdb-bcd12688d240"), "Ativan", 0 },
                    { new Guid("4b44f6a3-cf5a-4c0e-9eec-adf356196c14"), "Lidocaine", 3 },
                    { new Guid("4e91e046-6fa7-417a-9881-990df3d983cd"), "Oxycodone", 0 },
                    { new Guid("540e0f66-b354-4839-b658-90a73ec8509c"), "Morphine", 1 },
                    { new Guid("67f5e7bf-7822-4296-b97f-cf0616865b1c"), "Valium", 0 },
                    { new Guid("6b97e047-8391-480f-a784-dc14deed32bd"), "Fentanyl", 1 },
                    { new Guid("7b0c2168-4fba-4ebf-9529-9bd8c6dca770"), "Methadone", 0 },
                    { new Guid("7d2903b0-9d08-4944-ad0f-25ab14a18580"), "Xanax", 0 },
                    { new Guid("94d84db8-9e8a-4948-9be9-f15168c03135"), "Epinephrine", 1 },
                    { new Guid("bd64cdba-498e-4d5a-8495-05999a5aae94"), "Amoxicillin", 0 },
                    { new Guid("c55fa610-f311-4dd5-9abb-51cea38ef139"), "Ventolin", 2 },
                    { new Guid("d6dbdcfa-5cda-46aa-b5ab-bbec01cae23b"), "Prozac", 0 },
                    { new Guid("dac25d8c-9eb0-42b0-84aa-2a264d1c9d4d"), "Azithromycin", 0 },
                    { new Guid("f1a1ba02-8dfe-4db6-a54f-cb912e0b60ec"), "Lorazepam", 0 },
                    { new Guid("f6e46bc7-99be-42a8-90ac-122be679ea1d"), "Zoloft", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1110c901-42fa-4c0c-a3a9-5644cbb787f8"), "Joint pain" },
                    { new Guid("1b67a790-b334-43d8-b68b-e8440e5f6163"), "Depression" },
                    { new Guid("1c470b44-d327-46c8-829a-1921819b5fa7"), "Anxiety" },
                    { new Guid("4704b746-b20a-4d22-a6f9-2d71faffb41d"), "High blood pressure" },
                    { new Guid("56b7bb0a-2327-4055-8815-79f92b9e5775"), "Allergies" },
                    { new Guid("6b27b633-a9d3-4e36-8c1d-be80c0b1bb86"), "Cough" },
                    { new Guid("ac8f1a52-866a-42d0-a3a1-33fd1ae79819"), "Back pain" },
                    { new Guid("b22b0056-c600-4494-a50c-a43f79927993"), "Headache" },
                    { new Guid("ea292dd4-b0e3-4f1c-a715-089fd186d932"), "Fever" },
                    { new Guid("f1910151-b3ef-4218-b390-1b968cb96c8e"), "Sore throat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0396f0b2-a97e-4577-80c8-b60c19d32c53"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("04a305a9-f580-492f-ad30-c553797a8e35"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("079d53a6-4ecd-48ae-83e7-142b10569b4c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1840af57-00be-4898-a597-299f83d500d9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("33b5b119-3751-4621-8032-2d2842a93d97"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4ae9b8c3-d320-496f-9cdb-bcd12688d240"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4b44f6a3-cf5a-4c0e-9eec-adf356196c14"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4e91e046-6fa7-417a-9881-990df3d983cd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("540e0f66-b354-4839-b658-90a73ec8509c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("67f5e7bf-7822-4296-b97f-cf0616865b1c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6b97e047-8391-480f-a784-dc14deed32bd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7b0c2168-4fba-4ebf-9529-9bd8c6dca770"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7d2903b0-9d08-4944-ad0f-25ab14a18580"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("94d84db8-9e8a-4948-9be9-f15168c03135"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("bd64cdba-498e-4d5a-8495-05999a5aae94"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c55fa610-f311-4dd5-9abb-51cea38ef139"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d6dbdcfa-5cda-46aa-b5ab-bbec01cae23b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("dac25d8c-9eb0-42b0-84aa-2a264d1c9d4d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f1a1ba02-8dfe-4db6-a54f-cb912e0b60ec"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f6e46bc7-99be-42a8-90ac-122be679ea1d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("1110c901-42fa-4c0c-a3a9-5644cbb787f8"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("1b67a790-b334-43d8-b68b-e8440e5f6163"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("1c470b44-d327-46c8-829a-1921819b5fa7"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("4704b746-b20a-4d22-a6f9-2d71faffb41d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("56b7bb0a-2327-4055-8815-79f92b9e5775"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("6b27b633-a9d3-4e36-8c1d-be80c0b1bb86"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("ac8f1a52-866a-42d0-a3a1-33fd1ae79819"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("b22b0056-c600-4494-a50c-a43f79927993"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("ea292dd4-b0e3-4f1c-a715-089fd186d932"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("f1910151-b3ef-4218-b390-1b968cb96c8e"));

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("202ff3b0-b972-4e9f-8f90-9d055d8e6fcb"), "Hydrocodone", 0 },
                    { new Guid("27195881-bd1f-4251-a737-51f343a6c7b8"), "Prednisone", 0 },
                    { new Guid("3bb23697-3777-4a6c-b9bb-1282564a976d"), "Ventolin", 2 },
                    { new Guid("41647769-32d2-45fc-8758-df295eb06d47"), "Valium", 0 },
                    { new Guid("5cf1ccbf-fe45-422c-9042-0800d51d1f50"), "Methadone", 0 },
                    { new Guid("60ce2819-5705-486c-9686-4209cf1eaf1e"), "Ativan", 0 },
                    { new Guid("6243e709-d623-422e-80a2-88e7edb63c8d"), "Zoloft", 0 },
                    { new Guid("727c5e3d-956f-4d89-b60f-f72092b7d30a"), "Azithromycin", 0 },
                    { new Guid("97a444ef-862a-4d2b-a3c7-aabbb19ada4b"), "Codeine", 0 },
                    { new Guid("993c3bdd-e17c-4c56-9e79-131a86ef0edd"), "Oxycodone", 0 },
                    { new Guid("99759b50-dbfc-451b-9dcc-7e6abfda5139"), "Lidocaine", 3 },
                    { new Guid("9c8135d2-6920-46de-9ac2-25329334c8b3"), "Amoxicillin", 0 },
                    { new Guid("a660c51b-679c-46f9-9864-fe0eefa09833"), "Epinephrine", 1 },
                    { new Guid("a9b5f13e-c0cd-46a8-a290-fa7fd82c7c6b"), "Fentanyl", 1 },
                    { new Guid("ad263f64-d7f7-4051-b1fd-d12c9d7532ab"), "Paracetamol", 0 },
                    { new Guid("ae197415-3513-43c6-ac99-b3efa523ffff"), "Xanax", 0 },
                    { new Guid("c4f29189-9de1-46aa-8794-cb256875f342"), "Lorazepam", 0 },
                    { new Guid("d00be5b4-fb97-4d18-8a5d-9f96f260b1bc"), "Morphine", 1 },
                    { new Guid("ebea8e0f-5dee-43b1-b24f-edcf67dca466"), "Ibuprofen", 0 },
                    { new Guid("ecdf2e4c-cd14-43a9-95be-427686144521"), "Prozac", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00bccb02-d5ac-4226-824c-eb4f9b343776"), "Back pain" },
                    { new Guid("43bcd990-5d53-49f0-98c2-d9cba26870fc"), "Allergies" },
                    { new Guid("5703f941-7f06-40bb-aab1-2c8fd6c96a4b"), "Anxiety" },
                    { new Guid("5e06ef02-dcdf-4cc5-832f-55de2971dd9b"), "Fever" },
                    { new Guid("6dcc794e-9574-4bcd-af2d-5ec19fb9b6af"), "Joint pain" },
                    { new Guid("85ef02a3-f753-4405-ad7f-4f931598571f"), "Cough" },
                    { new Guid("8f782514-e3bc-490e-a427-8f3c4414548d"), "Sore throat" },
                    { new Guid("c501d9ee-649c-4866-b374-016a742ce473"), "High blood pressure" },
                    { new Guid("d4393b2e-ade6-476a-bb26-5815652cec8b"), "Headache" },
                    { new Guid("f1be8e3f-c4c9-4e8e-8e72-459e26b36bf1"), "Depression" }
                });
        }
    }
}
