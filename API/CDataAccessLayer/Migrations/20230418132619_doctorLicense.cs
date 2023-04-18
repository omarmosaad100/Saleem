using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class doctorLicense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("0d01b00b-5c78-44a0-8006-b69d912a607e"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("14751a69-b8c6-4aab-a7ab-95ef2d73ad96"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1aa3c387-4612-409f-8a3a-ffd6363431bc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("1f44591e-04ac-43c0-8d0e-ec8667b3a4bc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("349dd2fa-d79f-4c00-8295-bfb49cda2f10"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3ca060d2-ec16-4a59-b2b7-bc865b3a7db2"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4b361d8d-7479-4d8d-965c-16a6e448d366"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6946defd-cdbb-4ee2-b3bc-768d4038a1fc"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("73366c7e-1e00-4888-bb12-c0bd8ec60bbd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("90366f79-2463-484e-995e-198f7f784099"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("977c27bb-3a95-48ac-b1fb-8e4204b8dc0b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9c64cd14-82b2-441e-ba44-97da0ba9689a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a637a193-28df-407d-af72-c1724f021089"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("cdb9763e-8869-465e-8daf-f94b1a5898ba"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("eb3df79f-86a3-4d2f-9775-c41bb25654c5"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ebeef964-a690-46f6-8191-da385122bd08"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ed0022e3-ad73-40b9-9c1f-0d232b048211"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f696ce06-fd7a-4f83-a96b-bd61a18bf574"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("fc99dbe2-5f32-42e7-868b-3e94f818fce6"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ff7d6239-941f-4877-a3ea-c61b3b6e4476"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("42a3e960-0b56-46a3-8d75-21f8f499dac8"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("6fcb5d7a-15d6-48c9-a460-0a254894806e"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("71c00854-b112-4434-a122-e8e361d075e0"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("7894d126-3fff-4da0-96b3-1d33386cd558"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("7b7917ce-b37b-4563-97e9-aba0592ac789"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("87cae15b-d1a6-46d6-9bec-6fa73cd3062d"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("9e13e162-ba9e-4cba-aaa2-3416cf75ccc0"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("bcbd46e8-129b-4b5b-bfb3-ef25c2bd98ca"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("c437b131-557f-4260-bea7-7a6e13bd02cc"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("f21e6f62-f7f2-44c7-831d-091148277b8d"));

            migrationBuilder.AddColumn<Guid>(
                name: "licenseId",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("13f498fd-aebe-4a50-b729-7ec3096d924d"), "Lidocaine", 3 },
                    { new Guid("15a28081-719d-4bb8-96f6-1bad823028da"), "Prednisone", 0 },
                    { new Guid("27c98bce-526d-49b4-a98c-ae0ca28b20b1"), "Ibuprofen", 0 },
                    { new Guid("544ec3f8-1ab5-47b8-835d-97cbf03570ea"), "Ventolin", 2 },
                    { new Guid("6474031b-cc79-43ac-9b92-2c252772bf6d"), "Ativan", 0 },
                    { new Guid("726d694d-8df0-4bc2-9b6e-6fb4f73701be"), "Azithromycin", 0 },
                    { new Guid("745a6580-3c31-4121-97cc-ef8e0183eee9"), "Xanax", 0 },
                    { new Guid("74940f0e-54f4-4086-8c4e-d163428aae9b"), "Methadone", 0 },
                    { new Guid("83fe7f96-c49b-4921-8600-723a042dea8a"), "Oxycodone", 0 },
                    { new Guid("94f73468-1368-486b-bea3-694112753eb3"), "Valium", 0 },
                    { new Guid("96a256ed-1bf6-4c67-93ab-62535eaca0a2"), "Hydrocodone", 0 },
                    { new Guid("98ddbf8f-3cd8-47b2-bf0d-bdc52bd8681f"), "Paracetamol", 0 },
                    { new Guid("ac377035-f7fa-459d-bd95-360f45a7639d"), "Morphine", 1 },
                    { new Guid("c6248587-e6d1-48f5-b835-9ffe3eed0382"), "Lorazepam", 0 },
                    { new Guid("d077d5a3-5685-408d-a7ca-946c6a21619d"), "Fentanyl", 1 },
                    { new Guid("d80e5728-78d8-44cd-a775-1f5ff6c85b88"), "Amoxicillin", 0 },
                    { new Guid("eadebb6a-982a-4817-9818-cd043b1543c1"), "Epinephrine", 1 },
                    { new Guid("f6faecea-3d1a-471c-8dc5-70d94fa53eec"), "Zoloft", 0 },
                    { new Guid("f7384680-ec0d-4d6d-8471-bb9250763fb4"), "Prozac", 0 },
                    { new Guid("f81c16ff-0463-4992-bc5f-6686048f7c6f"), "Codeine", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02d2c0d4-7213-4acf-a991-32e16d622a4f"), "Joint pain" },
                    { new Guid("2c0476c8-148a-4873-8625-e0b33b1415d9"), "High blood pressure" },
                    { new Guid("3b5289fc-9a75-4544-be84-a46f5d2a52d3"), "Sore throat" },
                    { new Guid("5345c7c3-0d92-483b-8b8b-fdd0a39d0621"), "Fever" },
                    { new Guid("55ef0d78-1a9e-4cdb-8e51-19ab25f69672"), "Anxiety" },
                    { new Guid("5a218cc5-c5f8-4b29-b9f5-baaa054e33cc"), "Back pain" },
                    { new Guid("5bd046d7-468c-4887-a292-70e98c8c7f0b"), "Cough" },
                    { new Guid("642d4422-d3f8-4a68-9d17-2b0cad981743"), "Depression" },
                    { new Guid("815461b7-971c-4b95-8dde-9abb7484ae66"), "Allergies" },
                    { new Guid("d78470e2-56f2-4ebe-9320-6831f39b20df"), "Headache" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_licenseId",
                table: "Doctors",
                column: "licenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_licenses_licenseId",
                table: "Doctors",
                column: "licenseId",
                principalTable: "licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_licenses_licenseId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_licenseId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("13f498fd-aebe-4a50-b729-7ec3096d924d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("15a28081-719d-4bb8-96f6-1bad823028da"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("27c98bce-526d-49b4-a98c-ae0ca28b20b1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("544ec3f8-1ab5-47b8-835d-97cbf03570ea"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6474031b-cc79-43ac-9b92-2c252772bf6d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("726d694d-8df0-4bc2-9b6e-6fb4f73701be"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("745a6580-3c31-4121-97cc-ef8e0183eee9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("74940f0e-54f4-4086-8c4e-d163428aae9b"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("83fe7f96-c49b-4921-8600-723a042dea8a"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("94f73468-1368-486b-bea3-694112753eb3"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("96a256ed-1bf6-4c67-93ab-62535eaca0a2"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("98ddbf8f-3cd8-47b2-bf0d-bdc52bd8681f"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ac377035-f7fa-459d-bd95-360f45a7639d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("c6248587-e6d1-48f5-b835-9ffe3eed0382"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d077d5a3-5685-408d-a7ca-946c6a21619d"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d80e5728-78d8-44cd-a775-1f5ff6c85b88"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("eadebb6a-982a-4817-9818-cd043b1543c1"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f6faecea-3d1a-471c-8dc5-70d94fa53eec"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f7384680-ec0d-4d6d-8471-bb9250763fb4"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("f81c16ff-0463-4992-bc5f-6686048f7c6f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("02d2c0d4-7213-4acf-a991-32e16d622a4f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("2c0476c8-148a-4873-8625-e0b33b1415d9"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("3b5289fc-9a75-4544-be84-a46f5d2a52d3"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("5345c7c3-0d92-483b-8b8b-fdd0a39d0621"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("55ef0d78-1a9e-4cdb-8e51-19ab25f69672"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("5a218cc5-c5f8-4b29-b9f5-baaa054e33cc"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("5bd046d7-468c-4887-a292-70e98c8c7f0b"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("642d4422-d3f8-4a68-9d17-2b0cad981743"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("815461b7-971c-4b95-8dde-9abb7484ae66"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("d78470e2-56f2-4ebe-9320-6831f39b20df"));

            migrationBuilder.DropColumn(
                name: "licenseId",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("0d01b00b-5c78-44a0-8006-b69d912a607e"), "Amoxicillin", 0 },
                    { new Guid("14751a69-b8c6-4aab-a7ab-95ef2d73ad96"), "Oxycodone", 0 },
                    { new Guid("1aa3c387-4612-409f-8a3a-ffd6363431bc"), "Prednisone", 0 },
                    { new Guid("1f44591e-04ac-43c0-8d0e-ec8667b3a4bc"), "Fentanyl", 1 },
                    { new Guid("349dd2fa-d79f-4c00-8295-bfb49cda2f10"), "Ibuprofen", 0 },
                    { new Guid("3ca060d2-ec16-4a59-b2b7-bc865b3a7db2"), "Ativan", 0 },
                    { new Guid("4b361d8d-7479-4d8d-965c-16a6e448d366"), "Morphine", 1 },
                    { new Guid("6946defd-cdbb-4ee2-b3bc-768d4038a1fc"), "Zoloft", 0 },
                    { new Guid("73366c7e-1e00-4888-bb12-c0bd8ec60bbd"), "Xanax", 0 },
                    { new Guid("90366f79-2463-484e-995e-198f7f784099"), "Lidocaine", 3 },
                    { new Guid("977c27bb-3a95-48ac-b1fb-8e4204b8dc0b"), "Azithromycin", 0 },
                    { new Guid("9c64cd14-82b2-441e-ba44-97da0ba9689a"), "Methadone", 0 },
                    { new Guid("a637a193-28df-407d-af72-c1724f021089"), "Paracetamol", 0 },
                    { new Guid("cdb9763e-8869-465e-8daf-f94b1a5898ba"), "Hydrocodone", 0 },
                    { new Guid("eb3df79f-86a3-4d2f-9775-c41bb25654c5"), "Codeine", 0 },
                    { new Guid("ebeef964-a690-46f6-8191-da385122bd08"), "Lorazepam", 0 },
                    { new Guid("ed0022e3-ad73-40b9-9c1f-0d232b048211"), "Ventolin", 2 },
                    { new Guid("f696ce06-fd7a-4f83-a96b-bd61a18bf574"), "Epinephrine", 1 },
                    { new Guid("fc99dbe2-5f32-42e7-868b-3e94f818fce6"), "Prozac", 0 },
                    { new Guid("ff7d6239-941f-4877-a3ea-c61b3b6e4476"), "Valium", 0 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("42a3e960-0b56-46a3-8d75-21f8f499dac8"), "Allergies" },
                    { new Guid("6fcb5d7a-15d6-48c9-a460-0a254894806e"), "Depression" },
                    { new Guid("71c00854-b112-4434-a122-e8e361d075e0"), "Back pain" },
                    { new Guid("7894d126-3fff-4da0-96b3-1d33386cd558"), "Cough" },
                    { new Guid("7b7917ce-b37b-4563-97e9-aba0592ac789"), "Anxiety" },
                    { new Guid("87cae15b-d1a6-46d6-9bec-6fa73cd3062d"), "Sore throat" },
                    { new Guid("9e13e162-ba9e-4cba-aaa2-3416cf75ccc0"), "Joint pain" },
                    { new Guid("bcbd46e8-129b-4b5b-bfb3-ef25c2bd98ca"), "Headache" },
                    { new Guid("c437b131-557f-4260-bea7-7a6e13bd02cc"), "High blood pressure" },
                    { new Guid("f21e6f62-f7f2-44c7-831d-091148277b8d"), "Fever" }
                });
        }
    }
}
