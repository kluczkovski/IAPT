using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class AddCCGCodeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0c75be76-9583-44c7-a3b0-ee0314f5753b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1013f7d6-974e-4590-85ea-ad474a196fc7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("282b0878-b892-458d-947e-65e356d3b7ea"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6787c018-e458-42da-a450-d428fdffa382"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a0a0361f-9b40-4f64-8d2c-ea1c59c42245"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ba0f970f-ee03-4893-aa32-4f40ff24bda9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c66c8f74-0edb-4130-a6e1-8282dc74acd1"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("02a1e4f1-159e-4067-b0e8-e49cd5fff424"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("13a1e748-e2a8-4799-ba80-94f80cccbbd1"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("201cf3ea-0bf2-46d2-aa30-bea138a3a749"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("4c2390d1-10ad-405e-a36f-6e3103420a44"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("7eaff7c7-ddba-489c-8953-104380c33beb"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("f28fa5e8-a351-480b-8edb-422165da0d9a"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("0deff82b-6a26-4236-bcb1-b3f7d66a6f00"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("637815df-7a25-457e-9ed8-62080f086282"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8aa9466d-fdfa-4815-80c5-c70b789a268e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac744792-f52a-41f6-8483-0733082e695e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("b33ec21f-8036-40d6-b1e3-0a5ac22753a6"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3d92fdc-2c06-4d5f-8b3b-5b7a7f53542a"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1a4677d-e62c-41cb-820e-a1f92ab9f7bc"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("11008e66-5aac-4f52-b24a-00360ee0bb56"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("11ac2916-07ea-406b-bd74-9ee4b9b4b0bb"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("173df8ae-43dd-45e5-805d-28a4e6bff187"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("36be50e4-4b2f-428d-837a-77afa360a7e8"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("48b99c82-8b07-4593-930f-64b6b746ccb4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b5811e7-07dc-4643-a91b-4b1dddc57779"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6a20ccf0-f710-49ac-baff-7712e24411c7"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("7d05cc09-35f1-4e58-b05f-299bb6d5ef59"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("812a9fe0-8458-45e7-b06d-ba08f27af27d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("8d328a75-d93a-404a-a400-dc149fddf591"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("969f6b99-cb0b-4cbb-bd2e-ad599db9f2ba"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9a482916-07c0-4917-b55b-03252c400918"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9d48df5b-859d-4507-a880-b16e4303598e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1de199d-044e-443b-91e6-704e65580fdc"));

            migrationBuilder.CreateTable(
                name: "cCGCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(5)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: false),
                    Hub = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cCGCodes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b025b784-8c23-489a-9b04-ccc6e71998b3"), "Leeds" },
                    { new Guid("49ea76ae-2749-4494-b360-dda9c7a6bea4"), "Liverpool" },
                    { new Guid("c7848308-565a-438d-978e-d46a44617e95"), "Manchester" },
                    { new Guid("618b7307-038e-4921-ad02-2f3bb8a33ad5"), "Salfor" },
                    { new Guid("11dbde9d-ae19-4835-9996-e2ea9be4c1b4"), "York" },
                    { new Guid("77afa471-9031-449c-b118-df84efd86fbd"), "Chester" },
                    { new Guid("f5c23c87-b9e2-4ea6-9087-cf789c9bdcc5"), "Oldhan" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCode",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("7c962c3f-808e-432b-bed3-c562379b4940"), "XX", "Other" },
                    { new Guid("76f67c82-1b8d-4879-88fa-2f440c5770da"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("1237fd0c-4f2d-401d-b71b-ffd5a57f8602"), "02", "Hearing" },
                    { new Guid("6f5f310c-2020-451c-935b-985caead9951"), "01", "Behaviour and Emotional" },
                    { new Guid("3ff48331-d5db-409e-9b5d-a258375880f3"), "03", "Manual Dexterity" },
                    { new Guid("11108e16-58a6-4ec7-888c-75d163b13187"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("d9ed2048-d3a5-4684-83fb-5556008d0d10"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("7e894fc5-6efe-4ff1-8621-8474555d06db"), "D", "Mixed - White and Black Caribbean", 25 },
                    { new Guid("9c355351-9e96-409b-a557-4f6096014fce"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("45c17927-b80d-4684-9457-aaa07626ebb9"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("1cecd654-55ea-46fc-bd33-4321687a9dbb"), "C", "White - Any other White background", 23 },
                    { new Guid("b49bce45-8392-49ef-b45d-3fc42e329ed0"), "B", "White - Irish", 20 },
                    { new Guid("bf80022c-c615-4dc9-97e4-3a1e1ffb94f5"), "A", "White -British", 15 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("1518b6d2-9471-47b7-bc9a-2b5bb34f2f99"), "F", "Jewish" },
                    { new Guid("598e766c-9f01-4255-8988-1ef8d98607c6"), "J", "Zoroastrian" },
                    { new Guid("94f08c31-f5de-4d32-8178-916e5a7b206c"), "K", "Other" },
                    { new Guid("0efc089c-09e5-4c84-9049-31c31be6760e"), "L", "None" },
                    { new Guid("9be8b04e-fe30-49ff-8b4c-49c3c60285da"), "H", "Pagan" },
                    { new Guid("f0e5cc84-49ef-4178-a20f-aafd01b257da"), "G", "Muslim" },
                    { new Guid("567f1cae-a14c-4812-a919-615539473b10"), "I", "Sikh" },
                    { new Guid("d3d8539e-3ecb-48b5-92ad-2e8163408083"), "E", "Jain" },
                    { new Guid("a0948204-2b15-4793-a1a6-18fef62e59f6"), "N", "Patient Religion Unknown" },
                    { new Guid("848d4cb1-085d-4e9d-b65d-cf01c20a083b"), "C", "Christian" },
                    { new Guid("eb2fbe4f-16af-4eca-ac71-f0afde64e8bb"), "B", "Buddhist" },
                    { new Guid("e2d355cf-263d-4004-bdba-437d63faaa6a"), "A", "Baha'i" },
                    { new Guid("5ecc0588-8f6f-4fc1-9f93-beabefcbd60b"), "M", "Declines to Disclose" },
                    { new Guid("0ed436e1-86c7-4488-8373-1e0a4feb38de"), "D", "Hindu" }
                });

            migrationBuilder.InsertData(
                table: "cCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("185fc980-7013-4447-9573-b6e821218565"), "12F", "NHS Wirral CCG", "Q75" },
                    { new Guid("8efddac3-61a5-4c0b-9159-45c792d18632"), "01N", "NHS North Manchester CCG", "Q73" },
                    { new Guid("8f06832d-413b-4b28-a7e6-fdf3117e32e3"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("f07cf020-ca14-46b6-ba49-35a11a53cc5e"), "01G", "NHS Salford CCG", "Q73" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cCGCodes_Code",
                table: "cCGCodes",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cCGCodes");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("11dbde9d-ae19-4835-9996-e2ea9be4c1b4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("49ea76ae-2749-4494-b360-dda9c7a6bea4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("618b7307-038e-4921-ad02-2f3bb8a33ad5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("77afa471-9031-449c-b118-df84efd86fbd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b025b784-8c23-489a-9b04-ccc6e71998b3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c7848308-565a-438d-978e-d46a44617e95"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f5c23c87-b9e2-4ea6-9087-cf789c9bdcc5"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("11108e16-58a6-4ec7-888c-75d163b13187"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("1237fd0c-4f2d-401d-b71b-ffd5a57f8602"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("3ff48331-d5db-409e-9b5d-a258375880f3"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("6f5f310c-2020-451c-935b-985caead9951"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("76f67c82-1b8d-4879-88fa-2f440c5770da"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("7c962c3f-808e-432b-bed3-c562379b4940"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("1cecd654-55ea-46fc-bd33-4321687a9dbb"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("45c17927-b80d-4684-9457-aaa07626ebb9"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e894fc5-6efe-4ff1-8621-8474555d06db"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c355351-9e96-409b-a557-4f6096014fce"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("b49bce45-8392-49ef-b45d-3fc42e329ed0"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf80022c-c615-4dc9-97e4-3a1e1ffb94f5"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9ed2048-d3a5-4684-83fb-5556008d0d10"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("0ed436e1-86c7-4488-8373-1e0a4feb38de"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("0efc089c-09e5-4c84-9049-31c31be6760e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("1518b6d2-9471-47b7-bc9a-2b5bb34f2f99"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("567f1cae-a14c-4812-a919-615539473b10"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("598e766c-9f01-4255-8988-1ef8d98607c6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5ecc0588-8f6f-4fc1-9f93-beabefcbd60b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("848d4cb1-085d-4e9d-b65d-cf01c20a083b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("94f08c31-f5de-4d32-8178-916e5a7b206c"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9be8b04e-fe30-49ff-8b4c-49c3c60285da"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a0948204-2b15-4793-a1a6-18fef62e59f6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d3d8539e-3ecb-48b5-92ad-2e8163408083"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("e2d355cf-263d-4004-bdba-437d63faaa6a"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("eb2fbe4f-16af-4eca-ac71-f0afde64e8bb"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("f0e5cc84-49ef-4178-a20f-aafd01b257da"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("282b0878-b892-458d-947e-65e356d3b7ea"), "Liverpool" },
                    { new Guid("0c75be76-9583-44c7-a3b0-ee0314f5753b"), "Manchester" },
                    { new Guid("c66c8f74-0edb-4130-a6e1-8282dc74acd1"), "Salfor" },
                    { new Guid("ba0f970f-ee03-4893-aa32-4f40ff24bda9"), "York" },
                    { new Guid("6787c018-e458-42da-a450-d428fdffa382"), "Leeds" },
                    { new Guid("1013f7d6-974e-4590-85ea-ad474a196fc7"), "Chester" },
                    { new Guid("a0a0361f-9b40-4f64-8d2c-ea1c59c42245"), "Oldhan" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCode",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("f28fa5e8-a351-480b-8edb-422165da0d9a"), "01", "Behaviour and Emotional" },
                    { new Guid("201cf3ea-0bf2-46d2-aa30-bea138a3a749"), "02", "Hearing" },
                    { new Guid("02a1e4f1-159e-4067-b0e8-e49cd5fff424"), "03", "Manual Dexterity" },
                    { new Guid("7eaff7c7-ddba-489c-8953-104380c33beb"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("13a1e748-e2a8-4799-ba80-94f80cccbbd1"), "XX", "Other" },
                    { new Guid("4c2390d1-10ad-405e-a36f-6e3103420a44"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("637815df-7a25-457e-9ed8-62080f086282"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("e1a4677d-e62c-41cb-820e-a1f92ab9f7bc"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("8aa9466d-fdfa-4815-80c5-c70b789a268e"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("ac744792-f52a-41f6-8483-0733082e695e"), "D", "Mixed - White and Black Caribbean", 25 },
                    { new Guid("b3d92fdc-2c06-4d5f-8b3b-5b7a7f53542a"), "C", "White - Any other White background", 23 },
                    { new Guid("0deff82b-6a26-4236-bcb1-b3f7d66a6f00"), "B", "White - Irish", 20 },
                    { new Guid("b33ec21f-8036-40d6-b1e3-0a5ac22753a6"), "A", "White -British", 15 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("7d05cc09-35f1-4e58-b05f-299bb6d5ef59"), "L", "None" },
                    { new Guid("969f6b99-cb0b-4cbb-bd2e-ad599db9f2ba"), "K", "Other" },
                    { new Guid("812a9fe0-8458-45e7-b06d-ba08f27af27d"), "J", "Zoroastrian" },
                    { new Guid("173df8ae-43dd-45e5-805d-28a4e6bff187"), "I", "Sikh" },
                    { new Guid("4b5811e7-07dc-4643-a91b-4b1dddc57779"), "H", "Pagan" },
                    { new Guid("8d328a75-d93a-404a-a400-dc149fddf591"), "G", "Muslim" },
                    { new Guid("9d48df5b-859d-4507-a880-b16e4303598e"), "F", "Jewish" },
                    { new Guid("9a482916-07c0-4917-b55b-03252c400918"), "E", "Jain" },
                    { new Guid("48b99c82-8b07-4593-930f-64b6b746ccb4"), "D", "Hindu" },
                    { new Guid("6a20ccf0-f710-49ac-baff-7712e24411c7"), "C", "Christian" },
                    { new Guid("11008e66-5aac-4f52-b24a-00360ee0bb56"), "B", "Buddhist" },
                    { new Guid("36be50e4-4b2f-428d-837a-77afa360a7e8"), "A", "Baha'i" },
                    { new Guid("11ac2916-07ea-406b-bd74-9ee4b9b4b0bb"), "M", "Declines to Disclose" },
                    { new Guid("f1de199d-044e-443b-91e6-704e65580fdc"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
