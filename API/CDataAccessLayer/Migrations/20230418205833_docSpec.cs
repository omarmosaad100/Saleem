using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class docSpec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0870004d-f77d-4356-8981-4bac23e18432"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1975dc45-51a6-44ac-8b83-b248224cba77"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3c2e0311-349e-424c-8fc6-5a20ef8a02b0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4543907c-13a6-4816-9346-08bde67f0825"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("48b694ec-0a8f-43b0-9cac-587ce3c4ca3e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4ae86177-d5da-40fa-99b9-af8f403daecd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4ecaee08-f504-4877-a5ff-c4cf82f4038a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("51825020-53e3-45cd-8096-6072338fc50c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("65296870-6802-4d47-bcea-3fdb72d9497c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("69fac1c8-9e15-4b05-8900-62c103466dfc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6ab4b7e6-5871-477c-9717-cfda36dc6e8a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("75586726-f371-4a48-9482-33bd6642a563"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7d13f0b1-c934-4a60-a0e4-9362d21fc2b2"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("972868e2-c450-4f1e-bbd4-05c7863e70f8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("978d8b61-7f14-42ac-b432-78e71f590898"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9ffc10a6-4e9b-4391-8c74-57e7e766a8e1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a37c0943-058b-4a37-b16a-a4d05162e53a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("cf1f06cc-c4f2-41f2-9071-237a002b514e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("dc78a7a3-6bc0-4162-aefc-43d63b43dcf6"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("dd73ee57-5eb0-4c94-bbf0-290e690cbf62"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("04f4e5b1-ced4-4b66-8243-a92568e23902"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("0b974973-76a9-4a9c-9a78-2541b588a8c8"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("0d2b70e0-acd3-4cbb-80cc-ae6ce2d2aff7"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("37b23138-7b6a-4907-a86f-4f11ef5b8c86"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("393b7f58-7acc-4315-b95d-f4d4130bad78"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("3a5a1514-9b8e-4411-a67c-af24237681f0"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("4eceedb6-5b1b-43dc-a5b3-8f82aee82f8f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("670b936e-1dd7-4603-b583-a98a5f2780b5"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("990fb94c-fdc0-4122-baf4-4e4fbf8bd46c"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("de71d655-10f1-4ce8-9f6a-830ebca8afbc"));

            migrationBuilder.AddColumn<int>(
                name: "Specialization",
                table: "AppointmentDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("092613a1-bf2d-4266-8a79-597f02e61838"), "Ativan", 0 },
                    { new Guid("0cc6cc34-5bf1-4d6b-8f4c-321cb526a5b1"), "Azithromycin", 0 },
                    { new Guid("1f1523c9-b6ea-4af3-b406-225fc9b21988"), "Methadone", 0 },
                    { new Guid("3eca55bc-0235-43af-8f2d-bcbfb3151651"), "Xanax", 0 },
                    { new Guid("57d4a114-7fa2-4b32-832d-97b07c8b3355"), "Paracetamol", 0 },
                    { new Guid("5ac18c3c-6af2-4044-82c2-1d1e6c6782a7"), "Prozac", 0 },
                    { new Guid("5dd49fca-9e47-4541-8e45-2656c897cd58"), "Valium", 0 },
                    { new Guid("64c117de-ec37-4ff0-9d43-7110a5889aa3"), "Hydrocodone", 0 },
                    { new Guid("6538aa26-133f-42aa-b1d2-640c2ecb59c0"), "Ibuprofen", 0 },
                    { new Guid("679997ae-ae90-453c-9f48-875da65ba363"), "Fentanyl", 1 },
                    { new Guid("80033b40-f400-4789-814b-6a3b3eb04c04"), "Lidocaine", 3 },
                    { new Guid("809bf907-1fa0-42ef-8b7f-67942be59661"), "Ventolin", 2 },
                    { new Guid("9e23f49f-4ce1-48ac-a9eb-d10b32b3638e"), "Morphine", 1 },
                    { new Guid("a4dce63c-d092-4fd3-8e89-4628a5a199a7"), "Zoloft", 0 },
                    { new Guid("a6db3d1b-8863-486e-9870-f561c2ff7d81"), "Amoxicillin", 0 },
                    { new Guid("a820f852-88a9-4117-91ef-e3f1fffda236"), "Codeine", 0 },
                    { new Guid("af6300dc-116e-4186-8412-435023653f37"), "Prednisone", 0 },
                    { new Guid("b1ce3a77-ed96-413a-a545-437e603d11e2"), "Oxycodone", 0 },
                    { new Guid("c7be1578-23c0-423f-9caa-88b9bd80f0da"), "Epinephrine", 1 },
                    { new Guid("dad41470-4156-4404-bbbd-55f24d8d06c1"), "Lorazepam", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("362c005b-8b88-4017-bdec-ec36d69c4a1a"), "Cough" },
                    { new Guid("3b22af83-ae8e-43a7-919d-2665a87a3a30"), "Sore throat" },
                    { new Guid("43b7832e-3597-4b20-aa37-2f082e1bc02d"), "Fever" },
                    { new Guid("576a5c9e-93cb-4e9b-ac82-6ee1818716cf"), "Depression" },
                    { new Guid("7307a13e-72d4-4914-a0ac-1afd4c71b381"), "High blood pressure" },
                    { new Guid("b26da2c4-3280-44a7-a3e6-d003c56c3138"), "Back pain" },
                    { new Guid("ea825342-45b0-4d32-a563-b2c391879902"), "Joint pain" },
                    { new Guid("eb7041b3-4b05-4808-95da-1087f3344772"), "Headache" },
                    { new Guid("f158241f-2678-4000-91e2-ed76d7453db8"), "Anxiety" },
                    { new Guid("fe870bf8-ef59-4b8f-8285-c48beb2c4a18"), "Allergies" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("092613a1-bf2d-4266-8a79-597f02e61838"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0cc6cc34-5bf1-4d6b-8f4c-321cb526a5b1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1f1523c9-b6ea-4af3-b406-225fc9b21988"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3eca55bc-0235-43af-8f2d-bcbfb3151651"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("57d4a114-7fa2-4b32-832d-97b07c8b3355"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5ac18c3c-6af2-4044-82c2-1d1e6c6782a7"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5dd49fca-9e47-4541-8e45-2656c897cd58"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("64c117de-ec37-4ff0-9d43-7110a5889aa3"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6538aa26-133f-42aa-b1d2-640c2ecb59c0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("679997ae-ae90-453c-9f48-875da65ba363"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("80033b40-f400-4789-814b-6a3b3eb04c04"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("809bf907-1fa0-42ef-8b7f-67942be59661"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9e23f49f-4ce1-48ac-a9eb-d10b32b3638e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a4dce63c-d092-4fd3-8e89-4628a5a199a7"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a6db3d1b-8863-486e-9870-f561c2ff7d81"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a820f852-88a9-4117-91ef-e3f1fffda236"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("af6300dc-116e-4186-8412-435023653f37"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b1ce3a77-ed96-413a-a545-437e603d11e2"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c7be1578-23c0-423f-9caa-88b9bd80f0da"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("dad41470-4156-4404-bbbd-55f24d8d06c1"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("362c005b-8b88-4017-bdec-ec36d69c4a1a"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("3b22af83-ae8e-43a7-919d-2665a87a3a30"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("43b7832e-3597-4b20-aa37-2f082e1bc02d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("576a5c9e-93cb-4e9b-ac82-6ee1818716cf"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("7307a13e-72d4-4914-a0ac-1afd4c71b381"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("b26da2c4-3280-44a7-a3e6-d003c56c3138"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("ea825342-45b0-4d32-a563-b2c391879902"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("eb7041b3-4b05-4808-95da-1087f3344772"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("f158241f-2678-4000-91e2-ed76d7453db8"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("fe870bf8-ef59-4b8f-8285-c48beb2c4a18"));

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "AppointmentDetails");

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("0870004d-f77d-4356-8981-4bac23e18432"), "Lorazepam", 0 },
                    { new Guid("1975dc45-51a6-44ac-8b83-b248224cba77"), "Zoloft", 0 },
                    { new Guid("3c2e0311-349e-424c-8fc6-5a20ef8a02b0"), "Paracetamol", 0 },
                    { new Guid("4543907c-13a6-4816-9346-08bde67f0825"), "Lidocaine", 3 },
                    { new Guid("48b694ec-0a8f-43b0-9cac-587ce3c4ca3e"), "Azithromycin", 0 },
                    { new Guid("4ae86177-d5da-40fa-99b9-af8f403daecd"), "Ibuprofen", 0 },
                    { new Guid("4ecaee08-f504-4877-a5ff-c4cf82f4038a"), "Ativan", 0 },
                    { new Guid("51825020-53e3-45cd-8096-6072338fc50c"), "Hydrocodone", 0 },
                    { new Guid("65296870-6802-4d47-bcea-3fdb72d9497c"), "Methadone", 0 },
                    { new Guid("69fac1c8-9e15-4b05-8900-62c103466dfc"), "Epinephrine", 1 },
                    { new Guid("6ab4b7e6-5871-477c-9717-cfda36dc6e8a"), "Prozac", 0 },
                    { new Guid("75586726-f371-4a48-9482-33bd6642a563"), "Ventolin", 2 },
                    { new Guid("7d13f0b1-c934-4a60-a0e4-9362d21fc2b2"), "Codeine", 0 },
                    { new Guid("972868e2-c450-4f1e-bbd4-05c7863e70f8"), "Oxycodone", 0 },
                    { new Guid("978d8b61-7f14-42ac-b432-78e71f590898"), "Xanax", 0 },
                    { new Guid("9ffc10a6-4e9b-4391-8c74-57e7e766a8e1"), "Morphine", 1 },
                    { new Guid("a37c0943-058b-4a37-b16a-a4d05162e53a"), "Valium", 0 },
                    { new Guid("cf1f06cc-c4f2-41f2-9071-237a002b514e"), "Amoxicillin", 0 },
                    { new Guid("dc78a7a3-6bc0-4162-aefc-43d63b43dcf6"), "Prednisone", 0 },
                    { new Guid("dd73ee57-5eb0-4c94-bbf0-290e690cbf62"), "Fentanyl", 1 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04f4e5b1-ced4-4b66-8243-a92568e23902"), "Fever" },
                    { new Guid("0b974973-76a9-4a9c-9a78-2541b588a8c8"), "Allergies" },
                    { new Guid("0d2b70e0-acd3-4cbb-80cc-ae6ce2d2aff7"), "Headache" },
                    { new Guid("37b23138-7b6a-4907-a86f-4f11ef5b8c86"), "Anxiety" },
                    { new Guid("393b7f58-7acc-4315-b95d-f4d4130bad78"), "Depression" },
                    { new Guid("3a5a1514-9b8e-4411-a67c-af24237681f0"), "Joint pain" },
                    { new Guid("4eceedb6-5b1b-43dc-a5b3-8f82aee82f8f"), "Cough" },
                    { new Guid("670b936e-1dd7-4603-b583-a98a5f2780b5"), "High blood pressure" },
                    { new Guid("990fb94c-fdc0-4122-baf4-4e4fbf8bd46c"), "Sore throat" },
                    { new Guid("de71d655-10f1-4ce8-9f6a-830ebca8afbc"), "Back pain" }
                });
        }
    }
}
