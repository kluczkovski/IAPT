using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class Add_LTPH_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "eLongTermPhysicalHealths",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    HasClientLTPH = table.Column<string>(type: "varchar(50)", nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eLongTermPhysicalHealths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eLongTermPhysicalHealths_EReferrals_EReferralId",
                        column: x => x.EReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("0ed68f22-3dce-47b2-9dd9-4ceaa59861cf"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("9590a8b4-dae9-4358-8d71-af0d5f3e6169"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("a7a4553e-8c6c-458e-b469-8dc0bef1ec05"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("25b2a106-0f09-4ae5-9038-fffefdbd2270"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d0120137-5f23-4dfb-a8c6-f5f7ea8ddcdc"), "Other" },
                    { new Guid("e69ed416-2489-435e-ab9b-74f61cadb3d1"), "Chester" },
                    { new Guid("9f8c0867-8d34-4984-be92-165b6d6a626d"), "Leeds" },
                    { new Guid("6f5b6752-47e4-4902-ac92-249ddc6edc47"), "Oldhan" },
                    { new Guid("402c2de3-f543-493d-ba7d-c45178743005"), "Salfor" },
                    { new Guid("e822a725-893e-47ea-8d5a-1f147e78f786"), "Manchester" },
                    { new Guid("02dc5940-413c-4d4b-b6dc-6a82c4004669"), "Liverpool" },
                    { new Guid("113eac65-7491-4c78-99d7-403a5fddc96e"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("1372a97a-6118-4fc2-9576-23a8debdf95e"), "01", "Behaviour and Emotional" },
                    { new Guid("dcaacb7b-f2db-4308-89cb-40dc3799decc"), "02", "Hearing" },
                    { new Guid("3f62dddb-90e1-49cf-828e-ee16b573b53e"), "03", "Manual Dexterity" },
                    { new Guid("7eb9b6db-99fd-4a94-9cea-ee9920c8a211"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("38a56e0e-9abe-434f-a353-cb4d4472d871"), "XX", "Other" },
                    { new Guid("2edbd3f2-f1a0-4929-9387-0f5f1df0de8b"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("818b0be0-ddf1-4a3c-8564-fa97a6636e8d"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("7adfe0e9-d2c3-46f7-af20-a0cf5b125741"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("c3b6a686-865b-4d04-8b79-1e7fe202f7b1"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("201e0e64-0c8c-41ce-8132-87f7ce6a8bb3"), "B", "White - Irish", 20 },
                    { new Guid("c715417a-367f-4e68-a4db-df58a9acf685"), "C", "White - Any other White background", 23 },
                    { new Guid("e985030d-4c90-4e6b-9353-c2b5aced5842"), "A", "White -British", 15 },
                    { new Guid("fb31790e-f775-436b-8337-4735baa8d6ad"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("c8463db9-ec75-41db-9da7-be513f4b9911"), "L", "None" },
                    { new Guid("c72248c0-f110-467a-a3a5-c0f3f56021f5"), "K", "Other" },
                    { new Guid("90b522e1-1fad-4804-be76-d0c55a63ce68"), "J", "Zoroastrian" },
                    { new Guid("c395f932-e923-4fe6-a9c6-002a2bbeba5f"), "I", "Sikh" },
                    { new Guid("bca66e48-58f6-4d63-b902-00b564b1b99c"), "H", "Pagan" },
                    { new Guid("08f2948f-f27d-48e2-ac21-e7ade95d3c8e"), "G", "Muslim" },
                    { new Guid("3a031418-5449-4d01-9062-ef0fcd1da263"), "F", "Jewish" },
                    { new Guid("1f863795-e8a7-4df2-b067-1f418c89d3f5"), "D", "Hindu" },
                    { new Guid("29ca25a1-8eda-4d33-8bf4-0a806ff55d66"), "C", "Christian" },
                    { new Guid("faf36cef-25a7-4f8d-8ef6-4d33c5484c6d"), "B", "Buddhist" },
                    { new Guid("8322b39b-85b6-4abe-ba28-309dbb99ed78"), "A", "Baha'i" },
                    { new Guid("ffa0de24-8003-4397-90d8-8c156f033f8e"), "M", "Declines to Disclose" },
                    { new Guid("c227c528-9c69-4362-86fe-5727d47ca099"), "E", "Jain" },
                    { new Guid("f8213265-0ed5-486c-9f4a-4b6f027f241f"), "N", "Patient Religion Unknown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_eLongTermPhysicalHealths_EReferralId",
                table: "eLongTermPhysicalHealths",
                column: "EReferralId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eLongTermPhysicalHealths");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("0ed68f22-3dce-47b2-9dd9-4ceaa59861cf"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("25b2a106-0f09-4ae5-9038-fffefdbd2270"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("9590a8b4-dae9-4358-8d71-af0d5f3e6169"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("a7a4553e-8c6c-458e-b469-8dc0bef1ec05"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("02dc5940-413c-4d4b-b6dc-6a82c4004669"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("113eac65-7491-4c78-99d7-403a5fddc96e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("402c2de3-f543-493d-ba7d-c45178743005"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f5b6752-47e4-4902-ac92-249ddc6edc47"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9f8c0867-8d34-4984-be92-165b6d6a626d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d0120137-5f23-4dfb-a8c6-f5f7ea8ddcdc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e69ed416-2489-435e-ab9b-74f61cadb3d1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e822a725-893e-47ea-8d5a-1f147e78f786"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("1372a97a-6118-4fc2-9576-23a8debdf95e"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("2edbd3f2-f1a0-4929-9387-0f5f1df0de8b"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("38a56e0e-9abe-434f-a353-cb4d4472d871"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("3f62dddb-90e1-49cf-828e-ee16b573b53e"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("7eb9b6db-99fd-4a94-9cea-ee9920c8a211"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("dcaacb7b-f2db-4308-89cb-40dc3799decc"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("201e0e64-0c8c-41ce-8132-87f7ce6a8bb3"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("7adfe0e9-d2c3-46f7-af20-a0cf5b125741"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("818b0be0-ddf1-4a3c-8564-fa97a6636e8d"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3b6a686-865b-4d04-8b79-1e7fe202f7b1"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c715417a-367f-4e68-a4db-df58a9acf685"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("e985030d-4c90-4e6b-9353-c2b5aced5842"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb31790e-f775-436b-8337-4735baa8d6ad"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("08f2948f-f27d-48e2-ac21-e7ade95d3c8e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("1f863795-e8a7-4df2-b067-1f418c89d3f5"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("29ca25a1-8eda-4d33-8bf4-0a806ff55d66"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3a031418-5449-4d01-9062-ef0fcd1da263"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("8322b39b-85b6-4abe-ba28-309dbb99ed78"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("90b522e1-1fad-4804-be76-d0c55a63ce68"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("bca66e48-58f6-4d63-b902-00b564b1b99c"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c227c528-9c69-4362-86fe-5727d47ca099"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c395f932-e923-4fe6-a9c6-002a2bbeba5f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c72248c0-f110-467a-a3a5-c0f3f56021f5"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c8463db9-ec75-41db-9da7-be513f4b9911"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("f8213265-0ed5-486c-9f4a-4b6f027f241f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("faf36cef-25a7-4f8d-8ef6-4d33c5484c6d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("ffa0de24-8003-4397-90d8-8c156f033f8e"));

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
    }
}
