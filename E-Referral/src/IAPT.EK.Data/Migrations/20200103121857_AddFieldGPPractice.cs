using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class AddFieldGPPractice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "GPPractices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "GPPractices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine3",
                table: "GPPractices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine4",
                table: "GPPractices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine5",
                table: "GPPractices",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("fe5b3a69-9204-448c-b407-6420e35dfb94"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("dba432b4-514b-49b0-8794-ad634b63d5df"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("60822e7d-9978-4b51-b082-6327ee535c03"), "01N", "NHS North Manchester CCG", "Q73" },
                    { new Guid("c96f532a-311d-41b2-a16d-9be9f243ea49"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e8450931-eef2-4c58-9bdc-fb0f7743e5e6"), "Oldhan" },
                    { new Guid("49601309-7fa3-4bec-b771-3792bdc0f5e1"), "Leeds" },
                    { new Guid("456b019b-0cbd-472b-9524-e33dc3742072"), "York" },
                    { new Guid("6a0ccee9-7b79-4ddd-bfcc-603c6264abd1"), "Chester" },
                    { new Guid("31d1ed50-5a1b-4075-b421-19b994a27708"), "Manchester" },
                    { new Guid("d88ef3e0-6220-4456-b2cb-93243493b23a"), "Liverpool" },
                    { new Guid("bdf5f74d-ebb0-499f-8c57-1187a15a4d57"), "Salfor" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("59020817-0b62-4dd1-a43c-fea3b912f5ac"), "01", "Behaviour and Emotional" },
                    { new Guid("fd13a8f2-245a-4984-ae5f-33f5c7ab5670"), "02", "Hearing" },
                    { new Guid("00d8f0a0-641a-4324-850b-43d1caaf8ba8"), "03", "Manual Dexterity" },
                    { new Guid("a20933b9-8ce2-4bf6-8a93-a06133763dbb"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("c087eaff-5739-48de-a740-8d530753da7e"), "XX", "Other" },
                    { new Guid("ab2e674d-9640-4b8c-82dc-cebb34874de5"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("4e7a2afc-644f-41c3-b4c1-baf9bf8f6436"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("00224bb7-d6ac-4267-8f44-e286e14246b3"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("5157c9f6-a930-4db3-81e5-aa1770e24a8e"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("cf833fab-1aa7-4b26-89f7-978baecb2203"), "B", "White - Irish", 20 },
                    { new Guid("6bad26f1-5efc-4c8d-adaa-6c4c22d94544"), "C", "White - Any other White background", 23 },
                    { new Guid("c21e3982-9d49-4df8-bfd8-b393ec78045f"), "A", "White -British", 15 },
                    { new Guid("5061fe58-f0af-4289-b882-61a9aad56d2e"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("3325dc9b-77fb-4aa6-93d2-3a346e8d91e7"), "L", "None" },
                    { new Guid("88fbb7f9-5045-4d55-bd19-19433260ef48"), "K", "Other" },
                    { new Guid("c9cf6709-0001-45b1-853e-6e3a3dc00034"), "J", "Zoroastrian" },
                    { new Guid("866ab01d-0f49-4b6c-b424-2b6a45832c0b"), "I", "Sikh" },
                    { new Guid("2e1bec74-ffc3-4ceb-99f4-122716afe5c8"), "H", "Pagan" },
                    { new Guid("cfd1120c-6c8f-4436-953a-74f7c24d4716"), "G", "Muslim" },
                    { new Guid("c679c2bc-9d15-4a54-b0b3-0cb1849cdd82"), "F", "Jewish" },
                    { new Guid("5a448806-b59f-47b5-bc6e-01acc5a6adbf"), "D", "Hindu" },
                    { new Guid("d8a70e38-2c0c-451e-9650-cfc6adabc46f"), "C", "Christian" },
                    { new Guid("fccddfa8-30c6-4afc-90a6-74e8a2c80153"), "B", "Buddhist" },
                    { new Guid("84ec1d3c-0332-40a4-91df-94f5ad8c6501"), "A", "Baha'i" },
                    { new Guid("e204ccfc-aa53-4c85-8039-4a5a11503c69"), "M", "Declines to Disclose" },
                    { new Guid("55a3e5a4-d3b3-4b46-a8ab-0a7abf289060"), "E", "Jain" },
                    { new Guid("ef411c33-d27e-494c-bb44-5db1fca8daf8"), "N", "Patient Religion Unknown" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("60822e7d-9978-4b51-b082-6327ee535c03"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("c96f532a-311d-41b2-a16d-9be9f243ea49"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("dba432b4-514b-49b0-8794-ad634b63d5df"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("fe5b3a69-9204-448c-b407-6420e35dfb94"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("31d1ed50-5a1b-4075-b421-19b994a27708"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("456b019b-0cbd-472b-9524-e33dc3742072"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("49601309-7fa3-4bec-b771-3792bdc0f5e1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6a0ccee9-7b79-4ddd-bfcc-603c6264abd1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bdf5f74d-ebb0-499f-8c57-1187a15a4d57"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d88ef3e0-6220-4456-b2cb-93243493b23a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e8450931-eef2-4c58-9bdc-fb0f7743e5e6"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("00d8f0a0-641a-4324-850b-43d1caaf8ba8"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("59020817-0b62-4dd1-a43c-fea3b912f5ac"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("a20933b9-8ce2-4bf6-8a93-a06133763dbb"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("ab2e674d-9640-4b8c-82dc-cebb34874de5"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("c087eaff-5739-48de-a740-8d530753da7e"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("fd13a8f2-245a-4984-ae5f-33f5c7ab5670"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("00224bb7-d6ac-4267-8f44-e286e14246b3"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("4e7a2afc-644f-41c3-b4c1-baf9bf8f6436"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("5061fe58-f0af-4289-b882-61a9aad56d2e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("5157c9f6-a930-4db3-81e5-aa1770e24a8e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("6bad26f1-5efc-4c8d-adaa-6c4c22d94544"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c21e3982-9d49-4df8-bfd8-b393ec78045f"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf833fab-1aa7-4b26-89f7-978baecb2203"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2e1bec74-ffc3-4ceb-99f4-122716afe5c8"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3325dc9b-77fb-4aa6-93d2-3a346e8d91e7"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("55a3e5a4-d3b3-4b46-a8ab-0a7abf289060"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5a448806-b59f-47b5-bc6e-01acc5a6adbf"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("84ec1d3c-0332-40a4-91df-94f5ad8c6501"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("866ab01d-0f49-4b6c-b424-2b6a45832c0b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("88fbb7f9-5045-4d55-bd19-19433260ef48"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c679c2bc-9d15-4a54-b0b3-0cb1849cdd82"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c9cf6709-0001-45b1-853e-6e3a3dc00034"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("cfd1120c-6c8f-4436-953a-74f7c24d4716"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d8a70e38-2c0c-451e-9650-cfc6adabc46f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("e204ccfc-aa53-4c85-8039-4a5a11503c69"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("ef411c33-d27e-494c-bb44-5db1fca8daf8"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("fccddfa8-30c6-4afc-90a6-74e8a2c80153"));

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "GPPractices");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "GPPractices");

            migrationBuilder.DropColumn(
                name: "AddressLine3",
                table: "GPPractices");

            migrationBuilder.DropColumn(
                name: "AddressLine4",
                table: "GPPractices");

            migrationBuilder.DropColumn(
                name: "AddressLine5",
                table: "GPPractices");

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
                table: "DisabilityCode",
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
        }
    }
}
