using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class eIsvaReferralInfo_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("09b4d894-b93d-4282-b279-2a389562038f"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("46ef74c1-1310-4e27-9c58-179b26e61746"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("65bcdff9-9f36-4df7-a397-66121bc7baa5"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("687a322f-930d-4089-b026-f869b18a6101"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("095cf8f7-817d-42f8-8903-008a83d77f38"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("160d0c2e-ab94-4ecc-957b-aa59d0fe3620"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("36c6450c-fe47-40a3-8f52-f8a1f04c0e1b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5162f63e-343b-49c8-afd0-792521d30053"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7c4bc1bc-4a26-4e31-bdbf-40a96bfd698d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("847ebf67-15a4-4559-8e53-a988625e00b1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ae8da41a-9e42-4bd3-8a47-5271793f660b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b956978e-7ed6-4014-9826-f3ec643df9d9"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("3a5c0c94-6ba4-4432-8faa-9baed076118d"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("6635d738-968f-4577-b21f-c273d8eb2803"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("92f20e72-de92-4533-ae16-80c6a082862c"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("aef1af58-c659-4009-9e36-1e452411357a"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d4b9374e-8de5-4726-929e-095b70dc2492"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("dfdd0ba3-4218-42cc-8b96-f3449a607c85"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("1902a81d-7938-4565-ad19-e5675285224a"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("1bd330a8-cbed-454d-bcb5-277a63852d1c"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("2faf37d0-a2b0-4850-b262-e83b93f4798e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("59f1a64c-1fd9-48db-b816-a41cf41d619e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("da6975a1-d237-46c0-9684-c78a3a335696"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef6113cc-f060-49df-b0f0-263a6cfffa5e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("fdf08ae6-c4f6-4414-a3ba-76785f99fcde"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("11fc9d27-4d84-4f2d-8600-3c1222ff7320"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2cacc3d0-3890-441f-b0ff-464d793b81e3"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2d7f3dd6-41d8-401f-8c8d-7455a97f321e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("33993eea-8964-4bc6-a9e3-53209a2db608"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5b917900-256e-4664-8974-f3cb2d223e22"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6062fb4b-2f56-413b-927a-01737fd0cb4e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("71acf09b-8148-442e-8e60-aa006f4d50a2"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("bdfed790-52ae-4d9e-947c-ae476688832e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c8187057-b5fc-477a-8c7a-68c1315351fd"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d2beb8bc-1d52-4f73-a491-13467302de8f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d49db039-0943-435f-bc11-81e4669833d9"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("dc0067f6-a3f2-4b98-9feb-f8a94922bf7d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("e7a0c98e-b39b-4c9b-95d2-8b8c94c3eabe"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("fdf06aa7-1329-4f32-bd3f-4994c3c1c706"));

            migrationBuilder.CreateTable(
                name: "eIsvaReferralInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    eReferralId = table.Column<Guid>(nullable: false),
                    IsvaReferralService = table.Column<bool>(nullable: false),
                    CurrentlyReceivingSupport = table.Column<bool>(nullable: false),
                    AttendSexualAssaultRefCenter = table.Column<string>(type: "varchar(5)", nullable: false),
                    PoliceInvolved = table.Column<bool>(nullable: false),
                    CurrentOpenInvestigation = table.Column<bool>(nullable: false),
                    OfficerInChargeName = table.Column<string>(type: "varchar(50)", nullable: true),
                    OfficerInChargeService = table.Column<string>(type: "varchar(50)", nullable: true),
                    OfficerInChargeTel = table.Column<string>(type: "varchar(50)", nullable: true),
                    VictimSupportBeenContact = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eIsvaReferralInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eIsvaReferralInfos_EReferrals_eReferralId",
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

            migrationBuilder.CreateIndex(
                name: "IX_eIsvaReferralInfos_eReferralId",
                table: "eIsvaReferralInfos",
                column: "eReferralId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eIsvaReferralInfos");

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

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("46ef74c1-1310-4e27-9c58-179b26e61746"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("09b4d894-b93d-4282-b279-2a389562038f"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("65bcdff9-9f36-4df7-a397-66121bc7baa5"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("687a322f-930d-4089-b026-f869b18a6101"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7c4bc1bc-4a26-4e31-bdbf-40a96bfd698d"), "Other" },
                    { new Guid("ae8da41a-9e42-4bd3-8a47-5271793f660b"), "Chester" },
                    { new Guid("095cf8f7-817d-42f8-8903-008a83d77f38"), "Leeds" },
                    { new Guid("847ebf67-15a4-4559-8e53-a988625e00b1"), "Oldhan" },
                    { new Guid("b956978e-7ed6-4014-9826-f3ec643df9d9"), "Salfor" },
                    { new Guid("5162f63e-343b-49c8-afd0-792521d30053"), "Manchester" },
                    { new Guid("36c6450c-fe47-40a3-8f52-f8a1f04c0e1b"), "Liverpool" },
                    { new Guid("160d0c2e-ab94-4ecc-957b-aa59d0fe3620"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("3a5c0c94-6ba4-4432-8faa-9baed076118d"), "01", "Behaviour and Emotional" },
                    { new Guid("6635d738-968f-4577-b21f-c273d8eb2803"), "02", "Hearing" },
                    { new Guid("dfdd0ba3-4218-42cc-8b96-f3449a607c85"), "03", "Manual Dexterity" },
                    { new Guid("92f20e72-de92-4533-ae16-80c6a082862c"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("aef1af58-c659-4009-9e36-1e452411357a"), "XX", "Other" },
                    { new Guid("d4b9374e-8de5-4726-929e-095b70dc2492"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("1902a81d-7938-4565-ad19-e5675285224a"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("ef6113cc-f060-49df-b0f0-263a6cfffa5e"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("fdf08ae6-c4f6-4414-a3ba-76785f99fcde"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("1bd330a8-cbed-454d-bcb5-277a63852d1c"), "B", "White - Irish", 20 },
                    { new Guid("2faf37d0-a2b0-4850-b262-e83b93f4798e"), "C", "White - Any other White background", 23 },
                    { new Guid("59f1a64c-1fd9-48db-b816-a41cf41d619e"), "A", "White -British", 15 },
                    { new Guid("da6975a1-d237-46c0-9684-c78a3a335696"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("c8187057-b5fc-477a-8c7a-68c1315351fd"), "L", "None" },
                    { new Guid("5b917900-256e-4664-8974-f3cb2d223e22"), "K", "Other" },
                    { new Guid("2cacc3d0-3890-441f-b0ff-464d793b81e3"), "J", "Zoroastrian" },
                    { new Guid("d49db039-0943-435f-bc11-81e4669833d9"), "I", "Sikh" },
                    { new Guid("d2beb8bc-1d52-4f73-a491-13467302de8f"), "H", "Pagan" },
                    { new Guid("2d7f3dd6-41d8-401f-8c8d-7455a97f321e"), "G", "Muslim" },
                    { new Guid("6062fb4b-2f56-413b-927a-01737fd0cb4e"), "F", "Jewish" },
                    { new Guid("e7a0c98e-b39b-4c9b-95d2-8b8c94c3eabe"), "D", "Hindu" },
                    { new Guid("33993eea-8964-4bc6-a9e3-53209a2db608"), "C", "Christian" },
                    { new Guid("11fc9d27-4d84-4f2d-8600-3c1222ff7320"), "B", "Buddhist" },
                    { new Guid("71acf09b-8148-442e-8e60-aa006f4d50a2"), "A", "Baha'i" },
                    { new Guid("dc0067f6-a3f2-4b98-9feb-f8a94922bf7d"), "M", "Declines to Disclose" },
                    { new Guid("fdf06aa7-1329-4f32-bd3f-4994c3c1c706"), "E", "Jain" },
                    { new Guid("bdfed790-52ae-4d9e-947c-ae476688832e"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
