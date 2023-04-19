using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class nationalIdsAdded : Migration
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

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("1b1766bb-286f-465e-b555-ee723791f03c"), "Valium", 0 },
                    { new Guid("232d52b9-8eb1-4a9c-a787-0b702fdef19f"), "Epinephrine", 1 },
                    { new Guid("3b4058f4-ba5a-4208-afe1-a937fe451d77"), "Ventolin", 2 },
                    { new Guid("559a33d9-5780-455c-be6c-0396ad3df1ca"), "Codeine", 0 },
                    { new Guid("583428b1-338b-4a4b-a909-58a9472465bf"), "Morphine", 1 },
                    { new Guid("59d50b39-0ccf-4feb-932c-b40e0d4db222"), "Xanax", 0 },
                    { new Guid("68a96702-07a6-453b-964b-9e31388ac43a"), "Azithromycin", 0 },
                    { new Guid("7300fcf0-081f-4c74-9cee-bcf46966f70c"), "Oxycodone", 0 },
                    { new Guid("7e3e2107-2224-4895-923c-f2efb79d8faa"), "Fentanyl", 1 },
                    { new Guid("89d2e4d7-2e89-4ccf-aa45-6c943a544cd5"), "Lidocaine", 3 },
                    { new Guid("8daa6c1d-44ed-4161-9f65-451e371b0f2d"), "Lorazepam", 0 },
                    { new Guid("9e72682f-1b1f-4c43-ae77-b63f6f49bb93"), "Hydrocodone", 0 },
                    { new Guid("b73dddfe-d248-4340-97d2-4aaabe14ed23"), "Ibuprofen", 0 },
                    { new Guid("b9d63277-f8dd-4973-8b0b-17452087e12a"), "Prednisone", 0 },
                    { new Guid("bf8be46d-f777-4d38-b6e4-e5fe5c38f252"), "Amoxicillin", 0 },
                    { new Guid("d46a6e9f-d87d-482d-860a-e19717e5653f"), "Zoloft", 0 },
                    { new Guid("e07121fe-3346-4af5-a13c-dce14e5bd14e"), "Ativan", 0 },
                    { new Guid("f3772df6-2551-4b90-96a8-c5e77d5c8e63"), "Prozac", 0 },
                    { new Guid("f494ae16-b1e7-4cd7-b1f3-b69e867403f1"), "Methadone", 0 },
                    { new Guid("fb6928f6-8e06-49b3-9df8-c76739559474"), "Paracetamol", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("028703c6-06dd-472a-8cec-a71a8ee6fbf5"), "High blood pressure" },
                    { new Guid("1686db70-fd65-4895-ba1b-c2a285e6cf7d"), "Anxiety" },
                    { new Guid("1d7687ef-405a-4e03-a646-28157ca668f8"), "Sore throat" },
                    { new Guid("2325083e-ce14-4cef-abe4-1ada8f03892a"), "Joint pain" },
                    { new Guid("3fab4b96-2d79-4899-9f3a-e26e6cd0875a"), "Allergies" },
                    { new Guid("607ed07d-15a7-47a2-afd5-8af0be905f40"), "Cough" },
                    { new Guid("637b2123-5277-4729-8c01-85784ce1fa7e"), "Headache" },
                    { new Guid("a8d40922-5a9d-4494-8e46-2a2f8a7f5da1"), "Depression" },
                    { new Guid("cd8455bf-c154-41ab-a3c3-dc3a11c9183a"), "Back pain" },
                    { new Guid("e98e87ec-51f3-4ace-9d54-4e687f042fd4"), "Fever" }
                });

            migrationBuilder.InsertData(
                table: "nationalIds",
                column: "Id",
                values: new object[]
                {
                    "29708170100000",
                    "29708170100001",
                    "29708170100002",
                    "29708170100003",
                    "29708170100004",
                    "29708170100005",
                    "29708170100006",
                    "29708170100007",
                    "29708170100008",
                    "29708170100009"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1b1766bb-286f-465e-b555-ee723791f03c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("232d52b9-8eb1-4a9c-a787-0b702fdef19f"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3b4058f4-ba5a-4208-afe1-a937fe451d77"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("559a33d9-5780-455c-be6c-0396ad3df1ca"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("583428b1-338b-4a4b-a909-58a9472465bf"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("59d50b39-0ccf-4feb-932c-b40e0d4db222"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("68a96702-07a6-453b-964b-9e31388ac43a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7300fcf0-081f-4c74-9cee-bcf46966f70c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7e3e2107-2224-4895-923c-f2efb79d8faa"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("89d2e4d7-2e89-4ccf-aa45-6c943a544cd5"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("8daa6c1d-44ed-4161-9f65-451e371b0f2d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9e72682f-1b1f-4c43-ae77-b63f6f49bb93"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b73dddfe-d248-4340-97d2-4aaabe14ed23"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b9d63277-f8dd-4973-8b0b-17452087e12a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("bf8be46d-f777-4d38-b6e4-e5fe5c38f252"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d46a6e9f-d87d-482d-860a-e19717e5653f"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e07121fe-3346-4af5-a13c-dce14e5bd14e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f3772df6-2551-4b90-96a8-c5e77d5c8e63"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f494ae16-b1e7-4cd7-b1f3-b69e867403f1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("fb6928f6-8e06-49b3-9df8-c76739559474"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("028703c6-06dd-472a-8cec-a71a8ee6fbf5"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("1686db70-fd65-4895-ba1b-c2a285e6cf7d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("1d7687ef-405a-4e03-a646-28157ca668f8"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("2325083e-ce14-4cef-abe4-1ada8f03892a"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("3fab4b96-2d79-4899-9f3a-e26e6cd0875a"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("607ed07d-15a7-47a2-afd5-8af0be905f40"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("637b2123-5277-4729-8c01-85784ce1fa7e"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("a8d40922-5a9d-4494-8e46-2a2f8a7f5da1"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("cd8455bf-c154-41ab-a3c3-dc3a11c9183a"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("e98e87ec-51f3-4ace-9d54-4e687f042fd4"));

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100000");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100001");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100002");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100003");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100004");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100005");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100006");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100007");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100008");

            migrationBuilder.DeleteData(
                table: "nationalIds",
                keyColumn: "Id",
                keyValue: "29708170100009");

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
