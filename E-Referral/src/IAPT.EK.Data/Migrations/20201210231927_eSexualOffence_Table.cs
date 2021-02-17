using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class eSexualOffence_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("5a146ea0-f70d-425a-83da-a37a395d9624"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("649b22b9-60da-47b6-bcd3-6fd8e5b16db7"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("6800ae74-019e-45e1-a46d-2da295301167"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("bc38d52a-71e8-463f-849f-8aa2b59842ff"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2eed38db-d06c-4b69-82d5-9babff429474"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3bfdf55f-e2c6-4a02-aad3-04200878cad2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("509cd3d9-5fe1-4f00-9cb4-65f02d93abfa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("59d18537-7213-447e-94f9-6f7f0bd98935"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("858bd4c2-6581-424c-a7e4-9280501a54fc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8ef19413-b0a2-4486-b8b7-3cebcbc26b9a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f117ab46-e61f-42cf-9c23-162f37c10d4e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f9b59c13-8351-44b8-816b-0ebed4d8e012"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("2091b934-ba55-4c56-91fd-4b7177a1af7a"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("2933d0f3-00a2-4555-a41d-5cefaa0b4952"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("765f9453-06db-4a57-b1bf-db9b7a463a44"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("9042561b-1647-469b-a446-2d447e1c13c9"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d0eaf273-163d-458b-85a3-c98b8fe232df"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("f9a6b8e1-21d2-4782-bf45-2e4628a1b9f5"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("037bad40-265c-4817-974d-26840c535b29"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("23864271-42fa-4537-b1bb-e2255bb4a1e6"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("46be01b6-3263-4f4a-a5dc-44086225db52"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("69625a0a-61b2-46f5-8c55-fe706e7c6b45"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("906a44c7-3e7f-4127-ade8-7eb0ab32712a"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d59ede8-ddbb-406d-b055-720484f3c8e0"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c97622a4-1671-4fcc-9b15-a880e392f21f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("00443526-1b37-4fa6-b89d-699457568c50"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("08a8ee0e-7fb1-46f2-b9a1-855415cfe442"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("098fb0d1-613a-4e0d-955e-795d925184f6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("1073018f-2745-4b48-a0e5-9be54d9ca6c7"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2cdecdc6-0cc8-4b27-93b5-15d136be1d81"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2e8c7bfa-b620-48bf-80ca-3989cd52d4ed"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("55e82727-ff4a-4034-a789-8119c24de5ad"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6752fca4-3e89-4458-a64f-f1f4472a26c7"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6a71847f-04e8-4432-8017-c3e10b99a960"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("72f519bf-03a9-4aec-8c4e-6e057a06f537"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("75c3c885-de60-47d0-a872-fb02746790aa"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("86dacb5e-2c15-4123-8fe1-2717ae0a1b96"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("8ca4cd09-4a6c-4e68-9f6c-8ad3ab6334de"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("db4939f7-f12b-4ecb-96ab-000106be74a3"));

            migrationBuilder.CreateTable(
                name: "eSexualOffences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    eReferralId = table.Column<Guid>(nullable: false),
                    BriefSummary = table.Column<string>(nullable: false),
                    WhenWasIt = table.Column<string>(type: "varchar(50)", nullable: false),
                    OffenceType = table.Column<string>(type: "varchar(250)", nullable: false),
                    AgeAtTimeOfOffence = table.Column<string>(type: "varchar(250)", nullable: false),
                    WhatWasGenderOfPerpetror = table.Column<string>(type: "varchar(250)", nullable: false),
                    WhatWasRelationshipToPerpetror = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eSexualOffences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eSexualOffences_EReferrals_eReferralId",
                        column: x => x.eReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_eSexualOffences_eReferralId",
                table: "eSexualOffences",
                column: "eReferralId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eSexualOffences");

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

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("649b22b9-60da-47b6-bcd3-6fd8e5b16db7"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("bc38d52a-71e8-463f-849f-8aa2b59842ff"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("5a146ea0-f70d-425a-83da-a37a395d9624"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("6800ae74-019e-45e1-a46d-2da295301167"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f9b59c13-8351-44b8-816b-0ebed4d8e012"), "Other" },
                    { new Guid("3bfdf55f-e2c6-4a02-aad3-04200878cad2"), "Chester" },
                    { new Guid("858bd4c2-6581-424c-a7e4-9280501a54fc"), "Leeds" },
                    { new Guid("f117ab46-e61f-42cf-9c23-162f37c10d4e"), "Oldhan" },
                    { new Guid("2eed38db-d06c-4b69-82d5-9babff429474"), "Salfor" },
                    { new Guid("8ef19413-b0a2-4486-b8b7-3cebcbc26b9a"), "Manchester" },
                    { new Guid("59d18537-7213-447e-94f9-6f7f0bd98935"), "Liverpool" },
                    { new Guid("509cd3d9-5fe1-4f00-9cb4-65f02d93abfa"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("2091b934-ba55-4c56-91fd-4b7177a1af7a"), "01", "Behaviour and Emotional" },
                    { new Guid("f9a6b8e1-21d2-4782-bf45-2e4628a1b9f5"), "02", "Hearing" },
                    { new Guid("2933d0f3-00a2-4555-a41d-5cefaa0b4952"), "03", "Manual Dexterity" },
                    { new Guid("d0eaf273-163d-458b-85a3-c98b8fe232df"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("765f9453-06db-4a57-b1bf-db9b7a463a44"), "XX", "Other" },
                    { new Guid("9042561b-1647-469b-a446-2d447e1c13c9"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("69625a0a-61b2-46f5-8c55-fe706e7c6b45"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("46be01b6-3263-4f4a-a5dc-44086225db52"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("c97622a4-1671-4fcc-9b15-a880e392f21f"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("906a44c7-3e7f-4127-ade8-7eb0ab32712a"), "B", "White - Irish", 20 },
                    { new Guid("23864271-42fa-4537-b1bb-e2255bb4a1e6"), "C", "White - Any other White background", 23 },
                    { new Guid("037bad40-265c-4817-974d-26840c535b29"), "A", "White -British", 15 },
                    { new Guid("9d59ede8-ddbb-406d-b055-720484f3c8e0"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("2e8c7bfa-b620-48bf-80ca-3989cd52d4ed"), "L", "None" },
                    { new Guid("6a71847f-04e8-4432-8017-c3e10b99a960"), "K", "Other" },
                    { new Guid("db4939f7-f12b-4ecb-96ab-000106be74a3"), "J", "Zoroastrian" },
                    { new Guid("8ca4cd09-4a6c-4e68-9f6c-8ad3ab6334de"), "I", "Sikh" },
                    { new Guid("86dacb5e-2c15-4123-8fe1-2717ae0a1b96"), "H", "Pagan" },
                    { new Guid("72f519bf-03a9-4aec-8c4e-6e057a06f537"), "G", "Muslim" },
                    { new Guid("00443526-1b37-4fa6-b89d-699457568c50"), "F", "Jewish" },
                    { new Guid("2cdecdc6-0cc8-4b27-93b5-15d136be1d81"), "D", "Hindu" },
                    { new Guid("75c3c885-de60-47d0-a872-fb02746790aa"), "C", "Christian" },
                    { new Guid("55e82727-ff4a-4034-a789-8119c24de5ad"), "B", "Buddhist" },
                    { new Guid("1073018f-2745-4b48-a0e5-9be54d9ca6c7"), "A", "Baha'i" },
                    { new Guid("6752fca4-3e89-4458-a64f-f1f4472a26c7"), "M", "Declines to Disclose" },
                    { new Guid("08a8ee0e-7fb1-46f2-b9a1-855415cfe442"), "E", "Jain" },
                    { new Guid("098fb0d1-613a-4e0d-955e-795d925184f6"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
