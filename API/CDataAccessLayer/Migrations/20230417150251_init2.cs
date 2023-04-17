using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
