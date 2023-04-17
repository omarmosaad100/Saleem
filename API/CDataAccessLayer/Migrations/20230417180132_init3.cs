using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("07fc2f3f-c9b2-4cd1-9440-1b2e4a311f2a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0d7b479b-6884-4b26-a25c-b01f070dcaf4"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0f502541-c409-4b7d-9efa-e93d14090e1a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("15756d21-e9db-4bf8-9031-e927585b97a1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1b6e3b35-6c8b-4509-9174-79f2a69375b2"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("25bffa5c-764c-4df0-b7df-5fe78df862c5"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3e3c9a29-f8c9-4f62-9955-00c6e6799a82"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4a8dd62a-cfde-4188-8e51-9e8a206650dc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5b9ba2fd-25ca-4366-b3de-099a83ac21cd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6ccec5d2-5ab0-4fd0-ad35-e949520ffa0a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("714ccdc4-efa3-4c1c-8639-5beb3fd76fcd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7bda1f18-76d3-4cc7-9cd1-7b6c66b1bc9d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("8ba81900-3544-4d54-9b7e-512cd93f90f3"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9a52f97c-9f33-430d-a56a-ab4868cfb54e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9d686726-5170-4fec-8181-cbfa2ae5dcaf"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a67a57ae-40a7-4395-a463-8c96adabf7db"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b354f81a-4dd4-4cb6-9452-08497a413fda"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c9407d94-9415-4477-8eed-4c1cae8a505f"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f104c668-b7b6-48ad-8514-7a2a7beed6fe"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f7af93b5-ba3b-4894-9cf3-0149e9996d1d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("05ee820d-9119-4840-bb1a-d2f46b01bc2c"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("2906e05c-4d8c-400a-a6f0-76b0fa65d3f2"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("540144a2-9f6b-4d16-b1c9-7bc85f4544c4"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("6190b0fd-97ae-46e4-890a-10a7e8fe57f5"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("7f416cd9-db99-4f21-a9e1-55ecba71f420"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("89ce1abe-d973-4612-8895-f3b55e208035"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("9fc41604-ec9e-4f22-8215-92034635a283"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("b9d51f8e-347a-4b59-8e1a-fe16a4aeaf72"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("ceb8e50b-87e5-4ba3-a72b-030ff63555de"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("fde6f7bb-cb77-447b-bdd0-2c8ac4414e64"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("07fc2f3f-c9b2-4cd1-9440-1b2e4a311f2a"), "Hydrocodone", 0 },
                    { new Guid("0d7b479b-6884-4b26-a25c-b01f070dcaf4"), "Fentanyl", 1 },
                    { new Guid("0f502541-c409-4b7d-9efa-e93d14090e1a"), "Lidocaine", 3 },
                    { new Guid("15756d21-e9db-4bf8-9031-e927585b97a1"), "Methadone", 0 },
                    { new Guid("1b6e3b35-6c8b-4509-9174-79f2a69375b2"), "Zoloft", 0 },
                    { new Guid("25bffa5c-764c-4df0-b7df-5fe78df862c5"), "Codeine", 0 },
                    { new Guid("3e3c9a29-f8c9-4f62-9955-00c6e6799a82"), "Epinephrine", 1 },
                    { new Guid("4a8dd62a-cfde-4188-8e51-9e8a206650dc"), "Ativan", 0 },
                    { new Guid("5b9ba2fd-25ca-4366-b3de-099a83ac21cd"), "Paracetamol", 0 },
                    { new Guid("6ccec5d2-5ab0-4fd0-ad35-e949520ffa0a"), "Prednisone", 0 },
                    { new Guid("714ccdc4-efa3-4c1c-8639-5beb3fd76fcd"), "Amoxicillin", 0 },
                    { new Guid("7bda1f18-76d3-4cc7-9cd1-7b6c66b1bc9d"), "Xanax", 0 },
                    { new Guid("8ba81900-3544-4d54-9b7e-512cd93f90f3"), "Ventolin", 2 },
                    { new Guid("9a52f97c-9f33-430d-a56a-ab4868cfb54e"), "Azithromycin", 0 },
                    { new Guid("9d686726-5170-4fec-8181-cbfa2ae5dcaf"), "Prozac", 0 },
                    { new Guid("a67a57ae-40a7-4395-a463-8c96adabf7db"), "Valium", 0 },
                    { new Guid("b354f81a-4dd4-4cb6-9452-08497a413fda"), "Morphine", 1 },
                    { new Guid("c9407d94-9415-4477-8eed-4c1cae8a505f"), "Oxycodone", 0 },
                    { new Guid("f104c668-b7b6-48ad-8514-7a2a7beed6fe"), "Lorazepam", 0 },
                    { new Guid("f7af93b5-ba3b-4894-9cf3-0149e9996d1d"), "Ibuprofen", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("05ee820d-9119-4840-bb1a-d2f46b01bc2c"), "Anxiety" },
                    { new Guid("2906e05c-4d8c-400a-a6f0-76b0fa65d3f2"), "Fever" },
                    { new Guid("540144a2-9f6b-4d16-b1c9-7bc85f4544c4"), "High blood pressure" },
                    { new Guid("6190b0fd-97ae-46e4-890a-10a7e8fe57f5"), "Depression" },
                    { new Guid("7f416cd9-db99-4f21-a9e1-55ecba71f420"), "Cough" },
                    { new Guid("89ce1abe-d973-4612-8895-f3b55e208035"), "Back pain" },
                    { new Guid("9fc41604-ec9e-4f22-8215-92034635a283"), "Joint pain" },
                    { new Guid("b9d51f8e-347a-4b59-8e1a-fe16a4aeaf72"), "Headache" },
                    { new Guid("ceb8e50b-87e5-4ba3-a72b-030ff63555de"), "Sore throat" },
                    { new Guid("fde6f7bb-cb77-447b-bdd0-2c8ac4414e64"), "Allergies" }
                });
        }
    }
}
