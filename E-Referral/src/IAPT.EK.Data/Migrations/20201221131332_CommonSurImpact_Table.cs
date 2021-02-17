using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class CommonSurImpact_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("3a12854a-2e6e-4476-af7d-4d01b664996f"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("69140912-a874-4a48-80f8-a6f1a6372170"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("6d6dc107-9b99-4564-8415-7829a5c2b58b"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("ad902290-0434-4381-b6b9-ca4a3137710e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d69bd9a-0b14-4402-b708-226a2e8ec555"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("25cb89ff-8427-464b-8160-069574824b3b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("302b7b03-7a8e-40ad-8235-3e39ea088c8d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3b24e077-db28-4a32-8cca-0244d8ad183e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b3bef90d-950d-487b-97a7-63be6de902b7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c5b8be18-4399-41ff-b21e-76776327a0b2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d92112ab-a240-4b8f-8ad9-3d85d9ce8940"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f4f03a08-958b-40f7-9ed1-312965e5285c"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("17eb97d9-0fd3-42d5-9c73-8bf227714d0b"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("3a58d3b9-30c0-4ecc-8957-9c2f5c3345c3"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("3fe8d8fc-415b-49c2-bd95-657b0f03c873"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("69080b46-2333-4218-9afb-77ecf7619487"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("89878637-5186-4ee3-a1f4-af03c1b782e5"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("a2a47242-c2ed-40ad-8484-e1e6a6b10def"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("2136e47f-0956-4463-8b29-a4133fc13f76"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("3bc217a9-d953-4523-abe8-538e4282a5e1"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("80e3b93d-5775-49c3-b17b-ea4b2b062485"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c1ded129-e4e0-4da5-ab1a-32c95175870a"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c443f143-265f-4ca6-8d6c-70e4b5f6d8f2"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c661014d-1237-4fe5-82bf-946880696fb8"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("e33fc592-2eef-421c-b44d-4c8ba57bde5e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("0628c1db-56df-4458-9d73-c889719d4378"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("0ceebc1b-3299-4324-b94a-eec69a7d74dc"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("39cb756b-cdd9-4987-abfa-f5e631fbc796"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("59045659-4b68-4ef3-8c27-33810191b98c"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5da0d852-5202-4a80-a873-1ac60489ab2b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6463a4a4-9f4b-494b-a1e3-c2cf8953974b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("7a66f76e-05aa-49cb-9b39-d89b99de13cf"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("95f7e91d-78ef-4fc6-93ac-7c4255d55cd4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a1973ce7-d726-49f9-8a4e-a09c30a4d1e1"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a5e91529-5f02-4190-bf4e-365ee2ba2b27"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("be69180b-7624-4a25-9624-f946ff8ffe2b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("cf90b2f4-8a27-4503-bfec-a0e87018acd7"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("f86c5ea8-e0bf-49c5-9081-5f339f7df2cf"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("fb28e847-d240-4f5d-aa29-bfcc5b41b879"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CCGCodeId",
                table: "GPPractices",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReligionId",
                table: "EDiversities",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "EthnicCategoryId",
                table: "EDiversities",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "GpPracticeId",
                table: "EContactDetails",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "CityId",
                table: "EContactDetails",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.CreateTable(
                name: "eCommonSurvivorImpacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    HasAnyIssuesWithDrugs = table.Column<bool>(nullable: false),
                    HasAnyIssuesWithDrugsDetail = table.Column<string>(nullable: true),
                    HasOrHadEngagedAnyDrugTreatment = table.Column<string>(type: "varchar(20)", nullable: true),
                    CurrentTreatmentName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CurrentTreatmentService = table.Column<string>(type: "varchar(100)", nullable: true),
                    CurrentTreatmentTel = table.Column<string>(type: "varchar(30)", nullable: true),
                    PrescribedAnyMedical = table.Column<string>(type: "varchar(20)", nullable: true),
                    PrescribedAnyMedicalDetails = table.Column<string>(nullable: true),
                    ServedOrCurrentlyUnderInvestiagtion = table.Column<bool>(nullable: false),
                    ProbationServiceOrCRC = table.Column<string>(type: "varchar(20)", nullable: true),
                    FinalComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eCommonSurvivorImpacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eCommonSurvivorImpacts_EReferrals_EReferralId",
                        column: x => x.EReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "eOffences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ECommonSurvivorImpactId = table.Column<Guid>(nullable: false),
                    Offence = table.Column<string>(type: "varchar(150)", nullable: true),
                    Conviction = table.Column<string>(type: "varchar(30)", nullable: true),
                    LengthOfSentence = table.Column<string>(type: "varchar(30)", nullable: true),
                    MonthYearSentence = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eOffences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eOffences_eCommonSurvivorImpacts_ECommonSurvivorImpactId",
                        column: x => x.ECommonSurvivorImpactId,
                        principalTable: "eCommonSurvivorImpacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "eProbationServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ECommonSurvivorImpactId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Service = table.Column<string>(type: "varchar(100)", nullable: true),
                    Telephone = table.Column<string>(type: "varchar(50)", nullable: true),
                    ConsentToContact = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eProbationServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eProbationServices_eCommonSurvivorImpacts_ECommonSurvivorImp~",
                        column: x => x.ECommonSurvivorImpactId,
                        principalTable: "eCommonSurvivorImpacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "eServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ECommonSurvivorImpactId = table.Column<Guid>(nullable: false),
                    Service = table.Column<string>(type: "varchar(150)", nullable: true),
                    TreatmentProvided = table.Column<string>(type: "varchar(100)", nullable: true),
                    Start = table.Column<string>(type: "varchar(50)", nullable: true),
                    End = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eServices_eCommonSurvivorImpacts_ECommonSurvivorImpactId",
                        column: x => x.ECommonSurvivorImpactId,
                        principalTable: "eCommonSurvivorImpacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("f681d9e8-6b6a-41f4-87fe-551ac0ef3cf1"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("3fa5e29c-f71f-4f44-b717-829aa5fba2e8"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("4bf23608-2f42-470c-b55f-fc14e88cb323"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("5366780f-a36a-4767-b7eb-bdb6f813a135"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ecf19aa-9cfc-48fa-bc6f-78dfaabdb099"), "Other" },
                    { new Guid("70aa335c-a610-49de-9398-77e4154a8eca"), "Chester" },
                    { new Guid("4f8be03a-a4ee-4952-8364-9d83a38b04e2"), "Leeds" },
                    { new Guid("030b0207-c79a-4722-a52b-95d6c54aed78"), "Oldhan" },
                    { new Guid("5102c5d0-88f2-41b3-a63b-ce22549f6d69"), "Salfor" },
                    { new Guid("1c499a70-3111-472c-a24d-ea41d06f2d68"), "Manchester" },
                    { new Guid("ea3e7090-e1ba-437c-812c-806afdb20295"), "Liverpool" },
                    { new Guid("6f3d5515-d99e-4f52-9222-abf0eea33402"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("7e9b6d2c-e59c-49d5-898b-0c738ebbf622"), "01", "Behaviour and Emotional" },
                    { new Guid("d1e77164-a459-46c5-8d5d-587823ad43eb"), "02", "Hearing" },
                    { new Guid("7dc56695-0e88-448d-ab0e-b99d9eed8c26"), "03", "Manual Dexterity" },
                    { new Guid("910999fc-54e7-40f0-b246-1bc57c40b368"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("24e38103-cbec-477c-8bd1-0948d7101dc3"), "XX", "Other" },
                    { new Guid("32d14317-4bf1-4e90-babd-c3a3b7380cb8"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("c395e2ff-5663-4246-9b27-c0eaa52cedaa"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("93d7fbf9-45ce-45d1-b44e-deec376eb29f"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("6839b0bb-6a2a-4a23-be6f-fa1a8013d53e"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("2c9fc4cc-7885-400d-a125-58aaf5d802ea"), "B", "White - Irish", 20 },
                    { new Guid("9e069cd1-b5a3-4b87-804c-7c2ae61aaa2c"), "C", "White - Any other White background", 23 },
                    { new Guid("542bd9b7-d271-4012-bc05-e4ff636cb8be"), "A", "White -British", 15 },
                    { new Guid("0d5561cb-8ed4-4935-b37d-f0d0fab20515"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("981747c0-afc8-4074-ac63-a8c3e3e77e52"), "L", "None" },
                    { new Guid("966d9938-5008-49ad-b5bb-bd6bb8360220"), "K", "Other" },
                    { new Guid("60690df1-205c-4b56-9374-2a9b8e8eb804"), "J", "Zoroastrian" },
                    { new Guid("c42195e0-e3b6-4425-8ccb-b4476e79c876"), "I", "Sikh" },
                    { new Guid("9da349a3-3f9e-49b3-ab31-7b833a54c3d3"), "H", "Pagan" },
                    { new Guid("b4c16ee9-4239-4084-81ea-189f7c131db1"), "G", "Muslim" },
                    { new Guid("3010ba47-2720-4931-9dc4-053eb217dc32"), "F", "Jewish" },
                    { new Guid("57f085e9-a409-4dd8-88d6-c7fead481dcc"), "D", "Hindu" },
                    { new Guid("a396d536-8ee0-446e-8fbf-7e262351a429"), "C", "Christian" },
                    { new Guid("1d84ff37-2a98-4622-b75a-85b8ac036266"), "B", "Buddhist" },
                    { new Guid("425b2089-5a84-4bfe-abcf-443b70ace405"), "A", "Baha'i" },
                    { new Guid("59f621d9-ab53-4a08-9d63-e973fc63c3c4"), "M", "Declines to Disclose" },
                    { new Guid("0233aadb-55c3-420f-b3d0-ee7923a84b52"), "E", "Jain" },
                    { new Guid("632971b6-80fe-48b2-96a7-92dc7959e988"), "N", "Patient Religion Unknown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_eCommonSurvivorImpacts_EReferralId",
                table: "eCommonSurvivorImpacts",
                column: "EReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eOffences_ECommonSurvivorImpactId",
                table: "eOffences",
                column: "ECommonSurvivorImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_eProbationServices_ECommonSurvivorImpactId",
                table: "eProbationServices",
                column: "ECommonSurvivorImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_eServices_ECommonSurvivorImpactId",
                table: "eServices",
                column: "ECommonSurvivorImpactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eOffences");

            migrationBuilder.DropTable(
                name: "eProbationServices");

            migrationBuilder.DropTable(
                name: "eServices");

            migrationBuilder.DropTable(
                name: "eCommonSurvivorImpacts");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("3fa5e29c-f71f-4f44-b717-829aa5fba2e8"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("4bf23608-2f42-470c-b55f-fc14e88cb323"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("5366780f-a36a-4767-b7eb-bdb6f813a135"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("f681d9e8-6b6a-41f4-87fe-551ac0ef3cf1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("030b0207-c79a-4722-a52b-95d6c54aed78"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c499a70-3111-472c-a24d-ea41d06f2d68"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4ecf19aa-9cfc-48fa-bc6f-78dfaabdb099"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f8be03a-a4ee-4952-8364-9d83a38b04e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5102c5d0-88f2-41b3-a63b-ce22549f6d69"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f3d5515-d99e-4f52-9222-abf0eea33402"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("70aa335c-a610-49de-9398-77e4154a8eca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ea3e7090-e1ba-437c-812c-806afdb20295"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("24e38103-cbec-477c-8bd1-0948d7101dc3"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("32d14317-4bf1-4e90-babd-c3a3b7380cb8"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("7dc56695-0e88-448d-ab0e-b99d9eed8c26"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("7e9b6d2c-e59c-49d5-898b-0c738ebbf622"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("910999fc-54e7-40f0-b246-1bc57c40b368"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d1e77164-a459-46c5-8d5d-587823ad43eb"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d5561cb-8ed4-4935-b37d-f0d0fab20515"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c9fc4cc-7885-400d-a125-58aaf5d802ea"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("542bd9b7-d271-4012-bc05-e4ff636cb8be"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("6839b0bb-6a2a-4a23-be6f-fa1a8013d53e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("93d7fbf9-45ce-45d1-b44e-deec376eb29f"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e069cd1-b5a3-4b87-804c-7c2ae61aaa2c"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c395e2ff-5663-4246-9b27-c0eaa52cedaa"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("0233aadb-55c3-420f-b3d0-ee7923a84b52"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("1d84ff37-2a98-4622-b75a-85b8ac036266"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3010ba47-2720-4931-9dc4-053eb217dc32"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("425b2089-5a84-4bfe-abcf-443b70ace405"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("57f085e9-a409-4dd8-88d6-c7fead481dcc"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("59f621d9-ab53-4a08-9d63-e973fc63c3c4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("60690df1-205c-4b56-9374-2a9b8e8eb804"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("632971b6-80fe-48b2-96a7-92dc7959e988"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("966d9938-5008-49ad-b5bb-bd6bb8360220"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("981747c0-afc8-4074-ac63-a8c3e3e77e52"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9da349a3-3f9e-49b3-ab31-7b833a54c3d3"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a396d536-8ee0-446e-8fbf-7e262351a429"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("b4c16ee9-4239-4084-81ea-189f7c131db1"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c42195e0-e3b6-4425-8ccb-b4476e79c876"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CCGCodeId",
                table: "GPPractices",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReligionId",
                table: "EDiversities",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EthnicCategoryId",
                table: "EDiversities",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GpPracticeId",
                table: "EContactDetails",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CityId",
                table: "EContactDetails",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("6d6dc107-9b99-4564-8415-7829a5c2b58b"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("3a12854a-2e6e-4476-af7d-4d01b664996f"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("ad902290-0434-4381-b6b9-ca4a3137710e"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("69140912-a874-4a48-80f8-a6f1a6372170"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("25cb89ff-8427-464b-8160-069574824b3b"), "Other" },
                    { new Guid("0d69bd9a-0b14-4402-b708-226a2e8ec555"), "Chester" },
                    { new Guid("f4f03a08-958b-40f7-9ed1-312965e5285c"), "Leeds" },
                    { new Guid("c5b8be18-4399-41ff-b21e-76776327a0b2"), "Oldhan" },
                    { new Guid("3b24e077-db28-4a32-8cca-0244d8ad183e"), "Salfor" },
                    { new Guid("d92112ab-a240-4b8f-8ad9-3d85d9ce8940"), "Manchester" },
                    { new Guid("302b7b03-7a8e-40ad-8235-3e39ea088c8d"), "Liverpool" },
                    { new Guid("b3bef90d-950d-487b-97a7-63be6de902b7"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("a2a47242-c2ed-40ad-8484-e1e6a6b10def"), "01", "Behaviour and Emotional" },
                    { new Guid("69080b46-2333-4218-9afb-77ecf7619487"), "02", "Hearing" },
                    { new Guid("3fe8d8fc-415b-49c2-bd95-657b0f03c873"), "03", "Manual Dexterity" },
                    { new Guid("3a58d3b9-30c0-4ecc-8957-9c2f5c3345c3"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("17eb97d9-0fd3-42d5-9c73-8bf227714d0b"), "XX", "Other" },
                    { new Guid("89878637-5186-4ee3-a1f4-af03c1b782e5"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("c1ded129-e4e0-4da5-ab1a-32c95175870a"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("c443f143-265f-4ca6-8d6c-70e4b5f6d8f2"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("c661014d-1237-4fe5-82bf-946880696fb8"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("80e3b93d-5775-49c3-b17b-ea4b2b062485"), "B", "White - Irish", 20 },
                    { new Guid("e33fc592-2eef-421c-b44d-4c8ba57bde5e"), "C", "White - Any other White background", 23 },
                    { new Guid("3bc217a9-d953-4523-abe8-538e4282a5e1"), "A", "White -British", 15 },
                    { new Guid("2136e47f-0956-4463-8b29-a4133fc13f76"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("f86c5ea8-e0bf-49c5-9081-5f339f7df2cf"), "L", "None" },
                    { new Guid("7a66f76e-05aa-49cb-9b39-d89b99de13cf"), "K", "Other" },
                    { new Guid("95f7e91d-78ef-4fc6-93ac-7c4255d55cd4"), "J", "Zoroastrian" },
                    { new Guid("59045659-4b68-4ef3-8c27-33810191b98c"), "I", "Sikh" },
                    { new Guid("a5e91529-5f02-4190-bf4e-365ee2ba2b27"), "H", "Pagan" },
                    { new Guid("fb28e847-d240-4f5d-aa29-bfcc5b41b879"), "G", "Muslim" },
                    { new Guid("be69180b-7624-4a25-9624-f946ff8ffe2b"), "F", "Jewish" },
                    { new Guid("39cb756b-cdd9-4987-abfa-f5e631fbc796"), "D", "Hindu" },
                    { new Guid("0ceebc1b-3299-4324-b94a-eec69a7d74dc"), "C", "Christian" },
                    { new Guid("0628c1db-56df-4458-9d73-c889719d4378"), "B", "Buddhist" },
                    { new Guid("5da0d852-5202-4a80-a873-1ac60489ab2b"), "A", "Baha'i" },
                    { new Guid("a1973ce7-d726-49f9-8a4e-a09c30a4d1e1"), "M", "Declines to Disclose" },
                    { new Guid("6463a4a4-9f4b-494b-a1e3-c2cf8953974b"), "E", "Jain" },
                    { new Guid("cf90b2f4-8a27-4503-bfec-a0e87018acd7"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
