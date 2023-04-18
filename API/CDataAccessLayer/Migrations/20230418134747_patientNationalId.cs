using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class patientNationalId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "NationalIdId",
                table: "patients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Name", "TakingMethod" },
                values: new object[,]
                {
                    { new Guid("34029a94-d2f8-44cb-8dd0-54a0d6a469fe"), "Azithromycin", 0 },
                    { new Guid("3f365c57-7c8f-44ef-a425-6b35246c67dd"), "Prednisone", 0 },
                    { new Guid("4e40718d-c25f-4199-b329-37069077e8f6"), "Valium", 0 },
                    { new Guid("50d7fa88-9063-4386-b3b5-5cf01289d4c9"), "Xanax", 0 },
                    { new Guid("50e4491f-7303-4082-873c-de1c01f96143"), "Amoxicillin", 0 },
                    { new Guid("58ce6c85-5ae0-4376-bfe0-f910edf46429"), "Codeine", 0 },
                    { new Guid("6d657171-6cf6-43aa-9693-9a80fdfab7ba"), "Zoloft", 0 },
                    { new Guid("71d559f1-e35e-44d0-ae87-4cdebc717874"), "Lorazepam", 0 },
                    { new Guid("7952e7a6-500d-4e53-8711-e54fff1dc6c5"), "Prozac", 0 },
                    { new Guid("829c0b85-fb66-4a47-a0ed-df6ad6dd6d21"), "Ventolin", 2 },
                    { new Guid("875a4e20-69dc-45fa-bd2f-935537f987ea"), "Epinephrine", 1 },
                    { new Guid("8e80d14b-53f7-4012-8768-a99128e17d95"), "Morphine", 1 },
                    { new Guid("9275073f-fbca-422e-8638-724b58ac76c0"), "Ibuprofen", 0 },
                    { new Guid("a5c2835a-7989-4721-9c3c-ec850844b188"), "Paracetamol", 0 },
                    { new Guid("ac007734-b2c1-4f91-82ae-80e33b372468"), "Oxycodone", 0 },
                    { new Guid("ade61b7c-24a8-45f5-a746-51be92897038"), "Hydrocodone", 0 },
                    { new Guid("cde833e9-140f-4ea1-ac4d-6fec1afe0b6c"), "Methadone", 0 },
                    { new Guid("d2838b3a-60c9-4f73-9561-4d2c10e5cb59"), "Fentanyl", 1 },
                    { new Guid("da1e76bb-f8f6-430d-b199-4ac8023452b0"), "Ativan", 0 },
                    { new Guid("dfa6a5e9-158d-4d94-a870-73c37a12888a"), "Lidocaine", 3 }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("51175d07-09a6-4e82-8e17-1656dc700ce4"), "Joint pain" },
                    { new Guid("604772ff-3081-4285-b25e-4bcf0aa93a38"), "High blood pressure" },
                    { new Guid("848eff84-0b08-4780-8001-aaac830c8ab5"), "Fever" },
                    { new Guid("9a1e92bc-3eaf-4a88-91b2-3a755f795d29"), "Headache" },
                    { new Guid("a04e15da-8517-4662-8a6f-ed4aab923347"), "Back pain" },
                    { new Guid("a337fee0-04fc-4456-928d-3c6b5d380658"), "Cough" },
                    { new Guid("d675f475-22d3-482f-8a50-5b1d987006d3"), "Depression" },
                    { new Guid("f210da15-e806-4e04-b9b8-75870fd475b6"), "Anxiety" },
                    { new Guid("fa18f456-317c-4906-951f-2cb7eba72cad"), "Sore throat" },
                    { new Guid("faae98c7-56a3-4121-b421-57d69d4ab9ba"), "Allergies" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_patients_NationalIdId",
                table: "patients",
                column: "NationalIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_nationalIds_NationalIdId",
                table: "patients",
                column: "NationalIdId",
                principalTable: "nationalIds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_nationalIds_NationalIdId",
                table: "patients");

            migrationBuilder.DropIndex(
                name: "IX_patients_NationalIdId",
                table: "patients");

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("34029a94-d2f8-44cb-8dd0-54a0d6a469fe"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("3f365c57-7c8f-44ef-a425-6b35246c67dd"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("4e40718d-c25f-4199-b329-37069077e8f6"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("50d7fa88-9063-4386-b3b5-5cf01289d4c9"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("50e4491f-7303-4082-873c-de1c01f96143"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("58ce6c85-5ae0-4376-bfe0-f910edf46429"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("6d657171-6cf6-43aa-9693-9a80fdfab7ba"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("71d559f1-e35e-44d0-ae87-4cdebc717874"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("7952e7a6-500d-4e53-8711-e54fff1dc6c5"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("829c0b85-fb66-4a47-a0ed-df6ad6dd6d21"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("875a4e20-69dc-45fa-bd2f-935537f987ea"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("8e80d14b-53f7-4012-8768-a99128e17d95"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("9275073f-fbca-422e-8638-724b58ac76c0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("a5c2835a-7989-4721-9c3c-ec850844b188"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ac007734-b2c1-4f91-82ae-80e33b372468"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("ade61b7c-24a8-45f5-a746-51be92897038"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("cde833e9-140f-4ea1-ac4d-6fec1afe0b6c"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("d2838b3a-60c9-4f73-9561-4d2c10e5cb59"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("da1e76bb-f8f6-430d-b199-4ac8023452b0"));

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: new Guid("dfa6a5e9-158d-4d94-a870-73c37a12888a"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("51175d07-09a6-4e82-8e17-1656dc700ce4"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("604772ff-3081-4285-b25e-4bcf0aa93a38"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("848eff84-0b08-4780-8001-aaac830c8ab5"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("9a1e92bc-3eaf-4a88-91b2-3a755f795d29"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("a04e15da-8517-4662-8a6f-ed4aab923347"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("a337fee0-04fc-4456-928d-3c6b5d380658"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("d675f475-22d3-482f-8a50-5b1d987006d3"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("f210da15-e806-4e04-b9b8-75870fd475b6"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("fa18f456-317c-4906-951f-2cb7eba72cad"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("faae98c7-56a3-4121-b421-57d69d4ab9ba"));

            migrationBuilder.DropColumn(
                name: "NationalIdId",
                table: "patients");

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
        }
    }
}
