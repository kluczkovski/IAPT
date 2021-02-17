using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class ChangedArmedForceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("086ad4ec-167e-401d-965c-7aabb5d87978"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("dfe14e0a-fb0a-4d41-b794-42c94a694a29"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("ee1f4644-b40e-49df-b98a-ac086b3decca"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("ff30e262-e3f2-4d3f-a358-efa06e2a4051"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("171dfae6-960b-490d-a39a-5bb1856101f1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("18dddcab-7260-4d4c-902c-9b3b57647d7e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3173e79c-b931-43a0-a142-d6f7a4080f62"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a82c5eda-d7a6-4ba6-885c-a1fdc7dabb76"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("abff7c82-323d-478c-8418-9b44f353ceb4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c7d94486-d6d2-4347-a0be-40a5bf96c7c4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ccd2db96-5dcf-432c-87f7-ca583f85df22"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5672b6c-0eb3-4c18-848d-f8caa0741ea9"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("20113f2d-cea6-4f44-973f-5c791e6ba79b"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("5fab2185-26df-4c46-98dc-fb4b29215d91"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("cade1e46-24d6-4cc1-b6b9-5c6b67071ccf"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d91a996e-3711-447d-8061-1c902ec845f1"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("e31b5528-a40b-4e0f-8e52-c7d75b7701ab"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("efbf9a03-f0ac-4239-b220-5357142eda33"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("07d6f898-7b09-4f91-9c0c-948c7fd5afda"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("5569c67f-42d6-4598-8314-2465e7720818"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("6afd9943-5e53-4baa-a96d-9a7563ce9bd6"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("96f3ff6d-aeaa-483e-859b-e6e38736e758"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("dd39ceaa-fbcb-4ced-b7c3-0a32dab2edbe"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("f153ec6f-b952-4c35-83ab-020bf0e2fae9"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("f424d731-d0f4-465d-b6d3-ff668753b00d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("018d68e7-b8f5-46fc-9719-e350168068db"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("30f85bea-d006-4ecd-9532-d82e77457ddb"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("34938d35-398d-4ce5-9ed5-16cf7424574f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3975dfa4-d8e5-4761-abd5-a5a6fb0cec46"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("451804b2-f1c5-464b-b94d-eef3e5cc80cd"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("52c96ce3-0777-4e95-ac79-74852857af5d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("71c85a50-413b-4e2d-8589-9eaebf4e7d21"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9ddb9119-19d4-4b75-a47e-39f4871220d2"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a59de72e-7179-4f56-97f6-0f9c7dfcdf05"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("aa60b08d-8016-4a64-b571-8a6548ce9994"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c0cfc0a7-70ee-4bdc-8fd5-7b3a6f3f7ebb"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d00ef7a9-5742-40b8-9154-421937be1fb3"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("dc3b0eb8-515f-414a-9d73-1200b3ffd7e6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("f4d50d46-c535-4374-8531-712b7ca0df0b"));

            migrationBuilder.AlterColumn<string>(
                name: "ServiceNumber",
                table: "eArmedForces",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HasLinkedWithArmedForce",
                table: "eArmedForces",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("2de77dc5-7459-4032-8180-69a75074edb9"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("75370272-05ae-41fa-bfc2-722b379095f0"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("e4f8100d-4045-4649-a7b1-4b9c645cc0bb"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("b41a9804-7601-4ee7-8103-7ab9a8c9db31"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("77c218a5-0127-48cb-9ad1-9d127d0e0ca3"), "Other" },
                    { new Guid("45e8c7ea-8348-478d-ad7f-a65fa53db096"), "Chester" },
                    { new Guid("8355887b-da97-4164-8bbc-e7bc33807f8e"), "Leeds" },
                    { new Guid("23842bf1-f422-42fb-9e85-9dbf821cd47b"), "Oldhan" },
                    { new Guid("8ffb9526-fb01-4ce3-9c8c-434dd8e56e0f"), "Salfor" },
                    { new Guid("0d5ca097-405b-4dd3-b929-5fa6a4638a65"), "Manchester" },
                    { new Guid("7f525a36-31ba-4df9-baa0-684b3e5b6aab"), "Liverpool" },
                    { new Guid("16c6cbfc-147d-45cd-9b12-3dbcfc0f744b"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("611bab47-e008-428c-b92c-6883a9243901"), "01", "Behaviour and Emotional" },
                    { new Guid("53e1265a-6c5f-43f9-a362-f85c67fdccc7"), "02", "Hearing" },
                    { new Guid("e1935389-909c-4619-9469-031ecbc9a8fc"), "03", "Manual Dexterity" },
                    { new Guid("0a407719-0ac5-420f-a3ff-fc2a75c3d531"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("ca79b016-ff70-4cc6-9b40-29c77696ef5d"), "XX", "Other" },
                    { new Guid("7cd4d08e-69a7-43a7-8cf0-652a6ce97daf"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("50986a2f-945b-4dba-baab-6c29a6e038fd"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("cf1e1e3b-7306-4d8d-bc43-ac779b9e09f3"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("15e7bcca-9e05-4e7d-baa3-392a58400b3c"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("31154082-761b-4b7e-8bb3-142826818bc9"), "B", "White - Irish", 20 },
                    { new Guid("d1142b23-6ece-4591-b082-cc19855e2c4a"), "C", "White - Any other White background", 23 },
                    { new Guid("3f08daa3-8770-4cb3-a080-bb8d18fe7bca"), "A", "White -British", 15 },
                    { new Guid("037dc344-0619-4093-a1fe-64b800c87ea7"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("ae5e3f07-1b15-4d2f-89ce-7c076c7a2967"), "L", "None" },
                    { new Guid("aa1a5d1e-8e1d-47b5-953c-5f5b78e27fea"), "K", "Other" },
                    { new Guid("3f8cd533-258f-4d60-9b11-e641b0817345"), "J", "Zoroastrian" },
                    { new Guid("8fa6ea5e-27e0-4d01-a76a-3117e105cd91"), "I", "Sikh" },
                    { new Guid("24bc5421-524a-48ce-930d-6873d4805b14"), "H", "Pagan" },
                    { new Guid("1c62af07-ab4f-40df-9028-85a08f4c3808"), "G", "Muslim" },
                    { new Guid("7944494e-ecac-4a1f-a2f0-3cb6cc96eb62"), "F", "Jewish" },
                    { new Guid("01ce928f-9fba-4664-965d-6430cfad5502"), "D", "Hindu" },
                    { new Guid("6882c580-208b-443a-b6e8-c184e2c34804"), "C", "Christian" },
                    { new Guid("13cb4a7e-baf4-40bb-a388-f329c5c107c4"), "B", "Buddhist" },
                    { new Guid("8c676afe-49cf-4579-b29c-6f869f68ab2b"), "A", "Baha'i" },
                    { new Guid("5b43f70a-8c11-4d0d-93cb-ff4f575fc17b"), "M", "Declines to Disclose" },
                    { new Guid("6501f57b-b4ac-47b0-aa83-14ecfae4ac86"), "E", "Jain" },
                    { new Guid("ca54afb1-1ae7-4088-b0de-628b3b2d8730"), "N", "Patient Religion Unknown" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("2de77dc5-7459-4032-8180-69a75074edb9"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("75370272-05ae-41fa-bfc2-722b379095f0"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("b41a9804-7601-4ee7-8103-7ab9a8c9db31"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("e4f8100d-4045-4649-a7b1-4b9c645cc0bb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d5ca097-405b-4dd3-b929-5fa6a4638a65"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("16c6cbfc-147d-45cd-9b12-3dbcfc0f744b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("23842bf1-f422-42fb-9e85-9dbf821cd47b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("45e8c7ea-8348-478d-ad7f-a65fa53db096"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("77c218a5-0127-48cb-9ad1-9d127d0e0ca3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7f525a36-31ba-4df9-baa0-684b3e5b6aab"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8355887b-da97-4164-8bbc-e7bc33807f8e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8ffb9526-fb01-4ce3-9c8c-434dd8e56e0f"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("0a407719-0ac5-420f-a3ff-fc2a75c3d531"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("53e1265a-6c5f-43f9-a362-f85c67fdccc7"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("611bab47-e008-428c-b92c-6883a9243901"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("7cd4d08e-69a7-43a7-8cf0-652a6ce97daf"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("ca79b016-ff70-4cc6-9b40-29c77696ef5d"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("e1935389-909c-4619-9469-031ecbc9a8fc"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("037dc344-0619-4093-a1fe-64b800c87ea7"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("15e7bcca-9e05-4e7d-baa3-392a58400b3c"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("31154082-761b-4b7e-8bb3-142826818bc9"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f08daa3-8770-4cb3-a080-bb8d18fe7bca"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("50986a2f-945b-4dba-baab-6c29a6e038fd"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf1e1e3b-7306-4d8d-bc43-ac779b9e09f3"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1142b23-6ece-4591-b082-cc19855e2c4a"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("01ce928f-9fba-4664-965d-6430cfad5502"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("13cb4a7e-baf4-40bb-a388-f329c5c107c4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("1c62af07-ab4f-40df-9028-85a08f4c3808"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("24bc5421-524a-48ce-930d-6873d4805b14"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3f8cd533-258f-4d60-9b11-e641b0817345"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5b43f70a-8c11-4d0d-93cb-ff4f575fc17b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6501f57b-b4ac-47b0-aa83-14ecfae4ac86"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6882c580-208b-443a-b6e8-c184e2c34804"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("7944494e-ecac-4a1f-a2f0-3cb6cc96eb62"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("8c676afe-49cf-4579-b29c-6f869f68ab2b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("8fa6ea5e-27e0-4d01-a76a-3117e105cd91"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("aa1a5d1e-8e1d-47b5-953c-5f5b78e27fea"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("ae5e3f07-1b15-4d2f-89ce-7c076c7a2967"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("ca54afb1-1ae7-4088-b0de-628b3b2d8730"));

            migrationBuilder.AlterColumn<string>(
                name: "ServiceNumber",
                table: "eArmedForces",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasLinkedWithArmedForce",
                table: "eArmedForces",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("dfe14e0a-fb0a-4d41-b794-42c94a694a29"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("ff30e262-e3f2-4d3f-a358-efa06e2a4051"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("ee1f4644-b40e-49df-b98a-ac086b3decca"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("086ad4ec-167e-401d-965c-7aabb5d87978"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("18dddcab-7260-4d4c-902c-9b3b57647d7e"), "Other" },
                    { new Guid("e5672b6c-0eb3-4c18-848d-f8caa0741ea9"), "Chester" },
                    { new Guid("c7d94486-d6d2-4347-a0be-40a5bf96c7c4"), "Leeds" },
                    { new Guid("a82c5eda-d7a6-4ba6-885c-a1fdc7dabb76"), "Oldhan" },
                    { new Guid("3173e79c-b931-43a0-a142-d6f7a4080f62"), "Salfor" },
                    { new Guid("171dfae6-960b-490d-a39a-5bb1856101f1"), "Manchester" },
                    { new Guid("ccd2db96-5dcf-432c-87f7-ca583f85df22"), "Liverpool" },
                    { new Guid("abff7c82-323d-478c-8418-9b44f353ceb4"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("cade1e46-24d6-4cc1-b6b9-5c6b67071ccf"), "01", "Behaviour and Emotional" },
                    { new Guid("e31b5528-a40b-4e0f-8e52-c7d75b7701ab"), "02", "Hearing" },
                    { new Guid("5fab2185-26df-4c46-98dc-fb4b29215d91"), "03", "Manual Dexterity" },
                    { new Guid("d91a996e-3711-447d-8061-1c902ec845f1"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("20113f2d-cea6-4f44-973f-5c791e6ba79b"), "XX", "Other" },
                    { new Guid("efbf9a03-f0ac-4239-b220-5357142eda33"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("96f3ff6d-aeaa-483e-859b-e6e38736e758"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("f153ec6f-b952-4c35-83ab-020bf0e2fae9"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("dd39ceaa-fbcb-4ced-b7c3-0a32dab2edbe"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("6afd9943-5e53-4baa-a96d-9a7563ce9bd6"), "B", "White - Irish", 20 },
                    { new Guid("f424d731-d0f4-465d-b6d3-ff668753b00d"), "C", "White - Any other White background", 23 },
                    { new Guid("07d6f898-7b09-4f91-9c0c-948c7fd5afda"), "A", "White -British", 15 },
                    { new Guid("5569c67f-42d6-4598-8314-2465e7720818"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("451804b2-f1c5-464b-b94d-eef3e5cc80cd"), "L", "None" },
                    { new Guid("d00ef7a9-5742-40b8-9154-421937be1fb3"), "K", "Other" },
                    { new Guid("71c85a50-413b-4e2d-8589-9eaebf4e7d21"), "J", "Zoroastrian" },
                    { new Guid("34938d35-398d-4ce5-9ed5-16cf7424574f"), "I", "Sikh" },
                    { new Guid("9ddb9119-19d4-4b75-a47e-39f4871220d2"), "H", "Pagan" },
                    { new Guid("018d68e7-b8f5-46fc-9719-e350168068db"), "G", "Muslim" },
                    { new Guid("aa60b08d-8016-4a64-b571-8a6548ce9994"), "F", "Jewish" },
                    { new Guid("30f85bea-d006-4ecd-9532-d82e77457ddb"), "D", "Hindu" },
                    { new Guid("3975dfa4-d8e5-4761-abd5-a5a6fb0cec46"), "C", "Christian" },
                    { new Guid("a59de72e-7179-4f56-97f6-0f9c7dfcdf05"), "B", "Buddhist" },
                    { new Guid("f4d50d46-c535-4374-8531-712b7ca0df0b"), "A", "Baha'i" },
                    { new Guid("dc3b0eb8-515f-414a-9d73-1200b3ffd7e6"), "M", "Declines to Disclose" },
                    { new Guid("c0cfc0a7-70ee-4bdc-8fd5-7b3a6f3f7ebb"), "E", "Jain" },
                    { new Guid("52c96ce3-0777-4e95-ac79-74852857af5d"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
