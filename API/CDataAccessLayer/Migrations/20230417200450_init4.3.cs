using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init43 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "NationalID",
                table: "patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("0753c779-f910-4ead-b21b-0a26576644fd"), "Azithromycin", 0 },
                    { new Guid("096ec582-3e3c-4c83-93a2-a21d67b37bef"), "Xanax", 0 },
                    { new Guid("1a593f76-98e5-4705-bdd4-a4780adc1b96"), "Lidocaine", 3 },
                    { new Guid("1eebf3e6-7dc7-438d-afe7-d7d97d69aad0"), "Lorazepam", 0 },
                    { new Guid("29dcdbb0-7595-455a-8d51-f1b227127daf"), "Zoloft", 0 },
                    { new Guid("371c7ffd-f947-427c-8a3c-5e9afe769eb5"), "Paracetamol", 0 },
                    { new Guid("3e095c20-14a6-4f4e-b736-f67ec7ccbd1b"), "Codeine", 0 },
                    { new Guid("41958159-e275-4653-abac-b4a01629bc67"), "Prozac", 0 },
                    { new Guid("4b6b4d1d-87b5-4569-9fd9-26753b44fd88"), "Oxycodone", 0 },
                    { new Guid("787a6c6d-58d9-41b7-89db-83a12ff9c35a"), "Ibuprofen", 0 },
                    { new Guid("7b8ce30d-8c6d-4db6-bd95-0260428d9df8"), "Ventolin", 2 },
                    { new Guid("9cfaef96-5bc9-4562-9e63-e27c0201f8d1"), "Ativan", 0 },
                    { new Guid("baab02f2-6996-448d-9f24-1a93303971c9"), "Fentanyl", 1 },
                    { new Guid("c3a829a9-bba9-4a04-85fb-14fa991ddb92"), "Hydrocodone", 0 },
                    { new Guid("d4b8c723-5c8a-48b2-b411-69c3e1e8a8c1"), "Methadone", 0 },
                    { new Guid("e0f4eef9-deed-47b2-8395-019acd27231a"), "Prednisone", 0 },
                    { new Guid("e449d4c8-e17d-4ab1-a3c2-95451f698f57"), "Amoxicillin", 0 },
                    { new Guid("f2e81009-d13c-4aa4-a7bc-9853d425d9bc"), "Epinephrine", 1 },
                    { new Guid("f57ea926-6c8f-4c4e-8908-19ee89bb6375"), "Valium", 0 },
                    { new Guid("ff4b386f-511e-4dca-b78d-62f8a6af5959"), "Morphine", 1 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1967e6a5-30d0-41de-a854-7500ae554719"), "Allergies" },
                    { new Guid("3b140f88-f3f5-49bf-8be0-4f42bcfa1a8f"), "Fever" },
                    { new Guid("4ab2b469-63c0-477e-9e86-ef5134cbbe78"), "High blood pressure" },
                    { new Guid("6982ed99-f0f5-49b1-9636-b6cdc1e785c5"), "Anxiety" },
                    { new Guid("87850ccc-4b32-47b4-9ea4-66b314fe2897"), "Sore throat" },
                    { new Guid("88aba024-beea-4158-b666-9d2d2e371100"), "Depression" },
                    { new Guid("997f7f94-2997-4d8a-a8cd-c3009faeb7a8"), "Headache" },
                    { new Guid("c922d4a1-ab48-43cc-84dc-fcb04a9f42a1"), "Joint pain" },
                    { new Guid("cfa60675-c4a8-4591-8dd5-a078fbc7bfde"), "Back pain" },
                    { new Guid("f4e7cf3c-02d6-40c9-8cbd-f62c37aebbfe"), "Cough" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0753c779-f910-4ead-b21b-0a26576644fd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("096ec582-3e3c-4c83-93a2-a21d67b37bef"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1a593f76-98e5-4705-bdd4-a4780adc1b96"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1eebf3e6-7dc7-438d-afe7-d7d97d69aad0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("29dcdbb0-7595-455a-8d51-f1b227127daf"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("371c7ffd-f947-427c-8a3c-5e9afe769eb5"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3e095c20-14a6-4f4e-b736-f67ec7ccbd1b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("41958159-e275-4653-abac-b4a01629bc67"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4b6b4d1d-87b5-4569-9fd9-26753b44fd88"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("787a6c6d-58d9-41b7-89db-83a12ff9c35a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7b8ce30d-8c6d-4db6-bd95-0260428d9df8"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9cfaef96-5bc9-4562-9e63-e27c0201f8d1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("baab02f2-6996-448d-9f24-1a93303971c9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c3a829a9-bba9-4a04-85fb-14fa991ddb92"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d4b8c723-5c8a-48b2-b411-69c3e1e8a8c1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e0f4eef9-deed-47b2-8395-019acd27231a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("e449d4c8-e17d-4ab1-a3c2-95451f698f57"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f2e81009-d13c-4aa4-a7bc-9853d425d9bc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f57ea926-6c8f-4c4e-8908-19ee89bb6375"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ff4b386f-511e-4dca-b78d-62f8a6af5959"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("1967e6a5-30d0-41de-a854-7500ae554719"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("3b140f88-f3f5-49bf-8be0-4f42bcfa1a8f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("4ab2b469-63c0-477e-9e86-ef5134cbbe78"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("6982ed99-f0f5-49b1-9636-b6cdc1e785c5"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("87850ccc-4b32-47b4-9ea4-66b314fe2897"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("88aba024-beea-4158-b666-9d2d2e371100"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("997f7f94-2997-4d8a-a8cd-c3009faeb7a8"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("c922d4a1-ab48-43cc-84dc-fcb04a9f42a1"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("cfa60675-c4a8-4591-8dd5-a078fbc7bfde"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("f4e7cf3c-02d6-40c9-8cbd-f62c37aebbfe"));

            migrationBuilder.AlterColumn<int>(
                name: "NationalID",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
