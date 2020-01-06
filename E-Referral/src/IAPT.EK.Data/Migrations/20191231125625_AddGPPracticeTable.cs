using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class AddGPPracticeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CCGCodes",
                table: "CCGCodes");

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
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("11108e16-58a6-4ec7-888c-75d163b13187"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("1237fd0c-4f2d-401d-b71b-ffd5a57f8602"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("3ff48331-d5db-409e-9b5d-a258375880f3"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("6f5f310c-2020-451c-935b-985caead9951"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("76f67c82-1b8d-4879-88fa-2f440c5770da"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
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

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("185fc980-7013-4447-9573-b6e821218565"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("8efddac3-61a5-4c0b-9159-45c792d18632"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("8f06832d-413b-4b28-a7e6-fdf3117e32e3"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("f07cf020-ca14-46b6-ba49-35a11a53cc5e"));

            migrationBuilder.RenameTable(
                name: "CCGCodes",
                newName: "CCGCodes");

            migrationBuilder.RenameIndex(
                name: "IX_CCGCodes_Code",
                table: "CCGCodes",
                newName: "IX_CCGCodes_Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CCGCodes",
                table: "CCGCodes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "GPPractices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(6)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: false),
                    PostCode = table.Column<string>(type: "varchar(8)", nullable: true),
                    CCGCodeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPPractices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GPPractices_CCGCodes_CCGCodeId",
                        column: x => x.CCGCodeId,
                        principalTable: "CCGCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("a39cd250-0264-4f38-a907-5b7d362d11d9"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("4b27d444-dfcd-4c38-afc4-aae8888e61ed"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("1c27e286-d289-4c96-9f4a-6d5c2cce4f8a"), "01N", "NHS North Manchester CCG", "Q73" },
                    { new Guid("b005f139-a52e-4582-b7be-4b96b76c3ec1"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12517932-2dfb-41f1-9ba7-64ee3e80d3d0"), "Oldhan" },
                    { new Guid("b408b100-1c39-41cd-bb1b-2e5901210560"), "Leeds" },
                    { new Guid("84394b5d-a826-4799-9d21-d5613f56c687"), "York" },
                    { new Guid("a6efa575-dd4c-44cc-bbd4-386d3a431eaa"), "Chester" },
                    { new Guid("60cce9fc-74d1-499d-8d5d-2cb24f4587bb"), "Manchester" },
                    { new Guid("6887244e-e37d-4af5-b239-58683a717f28"), "Liverpool" },
                    { new Guid("deb70b62-1bc4-4f0e-a46e-6b3308b23ab9"), "Salfor" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("08b990e0-cb34-493b-9911-57c282b1135e"), "01", "Behaviour and Emotional" },
                    { new Guid("7a0d47b5-60e9-4cec-97d8-760dacf6076a"), "02", "Hearing" },
                    { new Guid("a79f1acf-7cd7-42dd-9f13-7e30500443a8"), "03", "Manual Dexterity" },
                    { new Guid("8151c9fe-8597-4ac3-919d-fe48e2a546bf"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("ecc7d153-06f5-49cd-b41f-12d4a86abf70"), "XX", "Other" },
                    { new Guid("d15fca84-96db-4911-b078-869ecdd28382"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("3a211f0e-1618-42e0-a89f-4063cded3622"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("b6b87610-9fa5-4671-a74a-62460b6e916f"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("a1920ce4-2abe-4496-bc83-84bf8463996b"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("73698571-5152-4afb-977f-70e339bc671b"), "B", "White - Irish", 20 },
                    { new Guid("baf8a4f0-032e-4225-a37f-ec5a03b13e52"), "C", "White - Any other White background", 23 },
                    { new Guid("58e516c2-11d9-46d6-a012-61c1c328de66"), "A", "White -British", 15 },
                    { new Guid("ecbe76b2-2fe3-4c35-8c37-52fdb19a1009"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("1b25a5cd-3c81-4476-81c9-1ab151a1d4a3"), "L", "None" },
                    { new Guid("db533890-c321-40f4-bbda-a64229c8964e"), "K", "Other" },
                    { new Guid("886cc6c8-2f50-481e-b108-1dcbd285d86f"), "J", "Zoroastrian" },
                    { new Guid("c02f710c-5816-40e4-9112-4c49e633190d"), "I", "Sikh" },
                    { new Guid("564da8a3-6e42-463d-9499-9f770b0e7ecc"), "H", "Pagan" },
                    { new Guid("931e53f4-f601-44af-af3b-c0c5746ce429"), "G", "Muslim" },
                    { new Guid("0b6abe30-9a6f-4b0c-a372-657880e81afa"), "F", "Jewish" },
                    { new Guid("a9fbc65d-d45f-4602-b3bc-4a503048837f"), "D", "Hindu" },
                    { new Guid("e2c51094-b2dc-491c-ac62-99580f178f59"), "C", "Christian" },
                    { new Guid("d3d1c9d3-0025-4e4f-9bac-b25ab9da4c2d"), "B", "Buddhist" },
                    { new Guid("13276725-3b50-4e8d-ba10-0d6e8e87149a"), "A", "Baha'i" },
                    { new Guid("12021c84-a759-426e-9e5c-3dfea8c290bc"), "M", "Declines to Disclose" },
                    { new Guid("935c3204-be73-4074-8c9f-10fd1dc4549d"), "E", "Jain" },
                    { new Guid("9710c698-d716-4a91-8b2f-d63d6fdbda60"), "N", "Patient Religion Unknown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GPPractices_CCGCodeId",
                table: "GPPractices",
                column: "CCGCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_GPPractices_Code",
                table: "GPPractices",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GPPractices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CCGCodes",
                table: "CCGCodes");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("1c27e286-d289-4c96-9f4a-6d5c2cce4f8a"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("4b27d444-dfcd-4c38-afc4-aae8888e61ed"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("a39cd250-0264-4f38-a907-5b7d362d11d9"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("b005f139-a52e-4582-b7be-4b96b76c3ec1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("12517932-2dfb-41f1-9ba7-64ee3e80d3d0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("60cce9fc-74d1-499d-8d5d-2cb24f4587bb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6887244e-e37d-4af5-b239-58683a717f28"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("84394b5d-a826-4799-9d21-d5613f56c687"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a6efa575-dd4c-44cc-bbd4-386d3a431eaa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b408b100-1c39-41cd-bb1b-2e5901210560"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("deb70b62-1bc4-4f0e-a46e-6b3308b23ab9"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("08b990e0-cb34-493b-9911-57c282b1135e"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("7a0d47b5-60e9-4cec-97d8-760dacf6076a"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("8151c9fe-8597-4ac3-919d-fe48e2a546bf"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("a79f1acf-7cd7-42dd-9f13-7e30500443a8"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d15fca84-96db-4911-b078-869ecdd28382"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("ecc7d153-06f5-49cd-b41f-12d4a86abf70"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("3a211f0e-1618-42e0-a89f-4063cded3622"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("58e516c2-11d9-46d6-a012-61c1c328de66"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("73698571-5152-4afb-977f-70e339bc671b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("a1920ce4-2abe-4496-bc83-84bf8463996b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6b87610-9fa5-4671-a74a-62460b6e916f"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("baf8a4f0-032e-4225-a37f-ec5a03b13e52"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ecbe76b2-2fe3-4c35-8c37-52fdb19a1009"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("0b6abe30-9a6f-4b0c-a372-657880e81afa"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("12021c84-a759-426e-9e5c-3dfea8c290bc"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("13276725-3b50-4e8d-ba10-0d6e8e87149a"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("1b25a5cd-3c81-4476-81c9-1ab151a1d4a3"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("564da8a3-6e42-463d-9499-9f770b0e7ecc"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("886cc6c8-2f50-481e-b108-1dcbd285d86f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("931e53f4-f601-44af-af3b-c0c5746ce429"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("935c3204-be73-4074-8c9f-10fd1dc4549d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9710c698-d716-4a91-8b2f-d63d6fdbda60"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a9fbc65d-d45f-4602-b3bc-4a503048837f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c02f710c-5816-40e4-9112-4c49e633190d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d3d1c9d3-0025-4e4f-9bac-b25ab9da4c2d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("db533890-c321-40f4-bbda-a64229c8964e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("e2c51094-b2dc-491c-ac62-99580f178f59"));

            migrationBuilder.RenameTable(
                name: "CCGCodes",
                newName: "cCGCodes");

            migrationBuilder.RenameIndex(
                name: "IX_CCGCodes_Code",
                table: "CCGCodes",
                newName: "IX_CCGCodes_Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CCGCodes",
                table: "CCGCodes",
                column: "Id");

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
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("185fc980-7013-4447-9573-b6e821218565"), "12F", "NHS Wirral CCG", "Q75" },
                    { new Guid("8efddac3-61a5-4c0b-9159-45c792d18632"), "01N", "NHS North Manchester CCG", "Q73" },
                    { new Guid("8f06832d-413b-4b28-a7e6-fdf3117e32e3"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("f07cf020-ca14-46b6-ba49-35a11a53cc5e"), "01G", "NHS Salford CCG", "Q73" }
                });
        }
    }
}
