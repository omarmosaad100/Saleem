using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init42 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("032157e7-820b-4c2d-967f-9e241c849d3a"), "Morphine", 1 },
                    { new Guid("215dbcd7-0b01-4af9-ac40-9c28bc9855b4"), "Codeine", 0 },
                    { new Guid("29c1acb4-bba1-4bf5-b325-1129eac3d95d"), "Ibuprofen", 0 },
                    { new Guid("2cacd865-0908-42e8-8108-7943a8874d93"), "Zoloft", 0 },
                    { new Guid("39aaec46-9f74-4020-aa52-347d58e14ff0"), "Paracetamol", 0 },
                    { new Guid("3cc1870e-f0dd-4419-92c4-5d5e9bbd52a6"), "Amoxicillin", 0 },
                    { new Guid("3d8664c5-5dad-4eaf-b46b-8c26e23e28f2"), "Ventolin", 2 },
                    { new Guid("52e8b2e4-1c8e-4d62-bf09-54c1ef9fce79"), "Xanax", 0 },
                    { new Guid("5994b6c0-67c5-4745-a017-12ca5b1e5ec9"), "Fentanyl", 1 },
                    { new Guid("5f3a5dcc-c920-4768-b9af-bd3dd03056d4"), "Prozac", 0 },
                    { new Guid("67597c04-1676-4ec4-b53e-1decb91d703a"), "Prednisone", 0 },
                    { new Guid("68561ca7-87ee-4988-a5fc-b3acad816a11"), "Valium", 0 },
                    { new Guid("8173c5ff-87eb-4e61-8b45-49023ae12d59"), "Methadone", 0 },
                    { new Guid("a16426dd-19d2-4c29-b687-69171215a843"), "Oxycodone", 0 },
                    { new Guid("ae6696b0-f7fb-4dbf-bede-c4e0eac219e8"), "Ativan", 0 },
                    { new Guid("b717fb07-8353-4fb4-b783-0520aea3e36c"), "Hydrocodone", 0 },
                    { new Guid("d1b2f1bd-dfd7-4001-b40b-2a538000d577"), "Lidocaine", 3 },
                    { new Guid("e3ad9a5d-64db-4ecd-b186-70b090116eb8"), "Lorazepam", 0 },
                    { new Guid("fab8f02f-a9b7-4dee-8d4c-8fc9ac5cf7f8"), "Epinephrine", 1 },
                    { new Guid("ff2590f3-0030-4646-916d-645b7780add3"), "Azithromycin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("313c8179-98be-4b30-8426-fd7aa6b80544"), "Joint pain" },
                    { new Guid("35081fcd-2889-4da5-81f6-c7a5905906c1"), "Headache" },
                    { new Guid("50143209-1135-4ada-b914-6cd66a246bf1"), "Allergies" },
                    { new Guid("5ed67536-59c5-48d5-aac6-1d4f654ded21"), "High blood pressure" },
                    { new Guid("713d286b-4a50-4640-bc34-76f0ff87bc10"), "Anxiety" },
                    { new Guid("8c59d618-01a8-476c-913a-bbee2a1f7be7"), "Cough" },
                    { new Guid("b53eecd3-32b9-4650-9827-8f073015c883"), "Fever" },
                    { new Guid("c4d1f2be-37af-4d66-96e8-aafc4eb7a36b"), "Sore throat" },
                    { new Guid("d16330ab-a0cf-49c8-82d0-e09d5b593d9f"), "Back pain" },
                    { new Guid("d9315a55-a425-46f0-9655-3aaecb6aff44"), "Depression" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("032157e7-820b-4c2d-967f-9e241c849d3a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("215dbcd7-0b01-4af9-ac40-9c28bc9855b4"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("29c1acb4-bba1-4bf5-b325-1129eac3d95d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("2cacd865-0908-42e8-8108-7943a8874d93"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("39aaec46-9f74-4020-aa52-347d58e14ff0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3cc1870e-f0dd-4419-92c4-5d5e9bbd52a6"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3d8664c5-5dad-4eaf-b46b-8c26e23e28f2"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("52e8b2e4-1c8e-4d62-bf09-54c1ef9fce79"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5994b6c0-67c5-4745-a017-12ca5b1e5ec9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("5f3a5dcc-c920-4768-b9af-bd3dd03056d4"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("67597c04-1676-4ec4-b53e-1decb91d703a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("68561ca7-87ee-4988-a5fc-b3acad816a11"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("8173c5ff-87eb-4e61-8b45-49023ae12d59"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a16426dd-19d2-4c29-b687-69171215a843"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ae6696b0-f7fb-4dbf-bede-c4e0eac219e8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("b717fb07-8353-4fb4-b783-0520aea3e36c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d1b2f1bd-dfd7-4001-b40b-2a538000d577"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e3ad9a5d-64db-4ecd-b186-70b090116eb8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("fab8f02f-a9b7-4dee-8d4c-8fc9ac5cf7f8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ff2590f3-0030-4646-916d-645b7780add3"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("313c8179-98be-4b30-8426-fd7aa6b80544"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("35081fcd-2889-4da5-81f6-c7a5905906c1"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("50143209-1135-4ada-b914-6cd66a246bf1"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("5ed67536-59c5-48d5-aac6-1d4f654ded21"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("713d286b-4a50-4640-bc34-76f0ff87bc10"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("8c59d618-01a8-476c-913a-bbee2a1f7be7"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("b53eecd3-32b9-4650-9827-8f073015c883"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("c4d1f2be-37af-4d66-96e8-aafc4eb7a36b"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("d16330ab-a0cf-49c8-82d0-e09d5b593d9f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("d9315a55-a425-46f0-9655-3aaecb6aff44"));

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
    }
}
