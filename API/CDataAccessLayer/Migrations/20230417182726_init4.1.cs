using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init41 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("04187ee5-fafc-4f84-bb22-67d31e981243"), "Azithromycin", 0 },
                    { new Guid("15cd306b-fb9e-4b7c-860d-6fd865107b0a"), "Paracetamol", 0 },
                    { new Guid("1dcbdc45-2139-4560-a017-4621ffffd27c"), "Prozac", 0 },
                    { new Guid("625c9287-662d-4912-89e3-e27fe751b734"), "Valium", 0 },
                    { new Guid("6286ab9d-5779-409b-a850-fc5b1710fc00"), "Xanax", 0 },
                    { new Guid("719b30f9-9db1-4bfb-a827-4ed56fe6d62f"), "Ibuprofen", 0 },
                    { new Guid("7dd5919f-3e48-4b1a-970e-f49b32f8f701"), "Ativan", 0 },
                    { new Guid("988371ed-f979-4205-9d8c-0980b1393990"), "Morphine", 1 },
                    { new Guid("99de3f4d-c76d-45c5-bcfa-596cb0df3dbe"), "Fentanyl", 1 },
                    { new Guid("af6c5b23-f859-46f8-82a0-0dfd9ed69910"), "Oxycodone", 0 },
                    { new Guid("aff3d17a-2114-4737-af4a-ae8e30181ef3"), "Methadone", 0 },
                    { new Guid("b6ca993e-b319-4fb9-9eb2-d30dce649365"), "Amoxicillin", 0 },
                    { new Guid("b7697bec-1e69-4e1e-832f-495f54f5c5b8"), "Lidocaine", 3 },
                    { new Guid("b93db9a5-ffbc-45ba-88d2-15ef1a3b6042"), "Codeine", 0 },
                    { new Guid("c099f3ab-122b-4cdc-88d2-38a40029c6a5"), "Epinephrine", 1 },
                    { new Guid("ce85e26b-6ad1-40b2-ad35-be5a4946d7fc"), "Prednisone", 0 },
                    { new Guid("f2972579-2a35-42a2-bcfb-21edaf3a873c"), "Lorazepam", 0 },
                    { new Guid("fbdb0443-d5ea-4db9-8f0d-3e32a7befb51"), "Zoloft", 0 },
                    { new Guid("fd2bb60e-ba73-4862-a97a-19f3b1995e10"), "Hydrocodone", 0 },
                    { new Guid("fe6d6d99-b2d4-4f14-a257-724347bd002e"), "Ventolin", 2 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("080aba07-e051-4751-b417-afe758e565d5"), "Fever" },
                    { new Guid("36607359-018a-4be3-bf04-1ca0ffbeb31e"), "High blood pressure" },
                    { new Guid("705ee7fd-c589-4ab5-a851-e1865559f486"), "Sore throat" },
                    { new Guid("8a7b960f-b2dd-49e5-968f-aa84b5fbe5eb"), "Anxiety" },
                    { new Guid("92b1c434-c9de-46b5-9da0-5d78742f7f9f"), "Depression" },
                    { new Guid("a1b3afa5-7179-42f5-a440-880cfe845c75"), "Cough" },
                    { new Guid("b2313095-f190-4b02-889c-5fc5f536ffb0"), "Allergies" },
                    { new Guid("c538a896-792a-478f-b698-084001a19f57"), "Back pain" },
                    { new Guid("d593471a-0bdb-4c2f-94c5-17c93566765a"), "Headache" },
                    { new Guid("d8657b16-6b3c-49f7-9253-974fa292e077"), "Joint pain" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("04187ee5-fafc-4f84-bb22-67d31e981243"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("15cd306b-fb9e-4b7c-860d-6fd865107b0a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1dcbdc45-2139-4560-a017-4621ffffd27c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("625c9287-662d-4912-89e3-e27fe751b734"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6286ab9d-5779-409b-a850-fc5b1710fc00"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("719b30f9-9db1-4bfb-a827-4ed56fe6d62f"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7dd5919f-3e48-4b1a-970e-f49b32f8f701"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("988371ed-f979-4205-9d8c-0980b1393990"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("99de3f4d-c76d-45c5-bcfa-596cb0df3dbe"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("af6c5b23-f859-46f8-82a0-0dfd9ed69910"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("aff3d17a-2114-4737-af4a-ae8e30181ef3"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b6ca993e-b319-4fb9-9eb2-d30dce649365"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b7697bec-1e69-4e1e-832f-495f54f5c5b8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b93db9a5-ffbc-45ba-88d2-15ef1a3b6042"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c099f3ab-122b-4cdc-88d2-38a40029c6a5"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ce85e26b-6ad1-40b2-ad35-be5a4946d7fc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f2972579-2a35-42a2-bcfb-21edaf3a873c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("fbdb0443-d5ea-4db9-8f0d-3e32a7befb51"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("fd2bb60e-ba73-4862-a97a-19f3b1995e10"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("fe6d6d99-b2d4-4f14-a257-724347bd002e"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("080aba07-e051-4751-b417-afe758e565d5"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("36607359-018a-4be3-bf04-1ca0ffbeb31e"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("705ee7fd-c589-4ab5-a851-e1865559f486"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("8a7b960f-b2dd-49e5-968f-aa84b5fbe5eb"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("92b1c434-c9de-46b5-9da0-5d78742f7f9f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("a1b3afa5-7179-42f5-a440-880cfe845c75"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("b2313095-f190-4b02-889c-5fc5f536ffb0"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("c538a896-792a-478f-b698-084001a19f57"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("d593471a-0bdb-4c2f-94c5-17c93566765a"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("d8657b16-6b3c-49f7-9253-974fa292e077"));

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
    }
}
