using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class nationaliDAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("03ffe4ca-b451-44b7-a3ee-9a51ff553bea"), "Xanax", 0 },
                    { new Guid("36e892c0-e6b0-4517-92cb-ef8b23949909"), "Prozac", 0 },
                    { new Guid("398f4a0c-aa09-4d6e-a9df-f932b3cba065"), "Codeine", 0 },
                    { new Guid("458f137e-b05c-4197-ab72-962ab36f8b2c"), "Ativan", 0 },
                    { new Guid("46460250-561a-4ea6-b3f7-c77a5625ea0c"), "Prednisone", 0 },
                    { new Guid("5bbdca04-b0bb-44da-8864-ae6eeec04be0"), "Morphine", 1 },
                    { new Guid("62e6e201-d6e1-4f9c-98aa-32b5c6f1a6f3"), "Lorazepam", 0 },
                    { new Guid("6a22b0a4-fe12-4430-b801-ba2082e8f712"), "Zoloft", 0 },
                    { new Guid("75ea28f5-1a51-49c5-a7f8-6a309afd7d30"), "Oxycodone", 0 },
                    { new Guid("7e3bf0b3-575a-42d4-9ba4-05cc3cfbedb9"), "Methadone", 0 },
                    { new Guid("83acde43-7879-4525-b3fe-b988b2ce8905"), "Epinephrine", 1 },
                    { new Guid("9299a0a8-ff92-40c2-9920-bcc9b426f52d"), "Azithromycin", 0 },
                    { new Guid("c69906aa-99d0-4a91-b97a-f61198574a58"), "Paracetamol", 0 },
                    { new Guid("c8d1f136-7b4b-47a2-9745-a4c885018329"), "Hydrocodone", 0 },
                    { new Guid("c9f0310e-f347-44d0-a0ec-03f71b223d5b"), "Ibuprofen", 0 },
                    { new Guid("cde84cf7-b42a-45f7-b932-b2a4395a1aeb"), "Ventolin", 2 },
                    { new Guid("dc6dcd8e-05ec-4836-87c5-0d0bc76cfbc5"), "Valium", 0 },
                    { new Guid("de0735b8-332e-4ea8-84e4-c1d410936793"), "Amoxicillin", 0 },
                    { new Guid("e24980ae-a132-46b5-8681-44b76e5899d2"), "Fentanyl", 1 },
                    { new Guid("fb372f61-2200-4cbe-9601-43a4699c05e7"), "Lidocaine", 3 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0b40beb0-9edf-48a5-9a0c-fe3196689e98"), "Headache" },
                    { new Guid("46440fd9-628a-4d61-bd96-469e1e81b407"), "Back pain" },
                    { new Guid("81ee61b7-bcc7-4eec-8723-be5f2451a4bb"), "Fever" },
                    { new Guid("9285a233-9584-4177-8b67-2c60c1a019ea"), "Sore throat" },
                    { new Guid("a3b1f31f-f3b1-44da-82f8-8d67ff015eed"), "High blood pressure" },
                    { new Guid("b7c175a9-dd9e-4635-98d3-c3952f86ee0c"), "Cough" },
                    { new Guid("db7946c8-0afb-4a88-9730-5662a615f0da"), "Depression" },
                    { new Guid("e3466e8d-3113-4b2e-9c9c-8b905c9299a0"), "Joint pain" },
                    { new Guid("e6b0ef7d-124b-4846-9fa0-85b66387fed3"), "Allergies" },
                    { new Guid("f80544c0-59b2-4fa3-9960-10f880b1e096"), "Anxiety" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("03ffe4ca-b451-44b7-a3ee-9a51ff553bea"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("36e892c0-e6b0-4517-92cb-ef8b23949909"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("398f4a0c-aa09-4d6e-a9df-f932b3cba065"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("458f137e-b05c-4197-ab72-962ab36f8b2c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("46460250-561a-4ea6-b3f7-c77a5625ea0c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5bbdca04-b0bb-44da-8864-ae6eeec04be0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("62e6e201-d6e1-4f9c-98aa-32b5c6f1a6f3"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6a22b0a4-fe12-4430-b801-ba2082e8f712"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("75ea28f5-1a51-49c5-a7f8-6a309afd7d30"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7e3bf0b3-575a-42d4-9ba4-05cc3cfbedb9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("83acde43-7879-4525-b3fe-b988b2ce8905"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9299a0a8-ff92-40c2-9920-bcc9b426f52d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c69906aa-99d0-4a91-b97a-f61198574a58"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c8d1f136-7b4b-47a2-9745-a4c885018329"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c9f0310e-f347-44d0-a0ec-03f71b223d5b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("cde84cf7-b42a-45f7-b932-b2a4395a1aeb"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("dc6dcd8e-05ec-4836-87c5-0d0bc76cfbc5"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("de0735b8-332e-4ea8-84e4-c1d410936793"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e24980ae-a132-46b5-8681-44b76e5899d2"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("fb372f61-2200-4cbe-9601-43a4699c05e7"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("0b40beb0-9edf-48a5-9a0c-fe3196689e98"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("46440fd9-628a-4d61-bd96-469e1e81b407"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("81ee61b7-bcc7-4eec-8723-be5f2451a4bb"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("9285a233-9584-4177-8b67-2c60c1a019ea"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("a3b1f31f-f3b1-44da-82f8-8d67ff015eed"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("b7c175a9-dd9e-4635-98d3-c3952f86ee0c"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("db7946c8-0afb-4a88-9730-5662a615f0da"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("e3466e8d-3113-4b2e-9c9c-8b905c9299a0"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("e6b0ef7d-124b-4846-9fa0-85b66387fed3"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("f80544c0-59b2-4fa3-9960-10f880b1e096"));

            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "patients");

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
        }
    }
}
