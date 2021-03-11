using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class InitialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eProbationServices_eCommonSurvivorImpacts_ECommonSurvivorImp~",
                table: "eProbationServices");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: "020f19e8-1a8e-4b48-ae0d-ef5371b3dccd");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: "09749016-2b22-4561-b34f-04b3ff11ad43");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: "737e33a8-b34f-4e4b-bb37-044d1d1f51ac");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: "fa4a6c6f-e133-40aa-9c7f-b0ff21da4c42");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "0d9a3810-fdb8-4ede-8db4-e6ef3e3f4dcf");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "15c91e11-fb1a-4e05-b77a-48595e69062a");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "258be96b-7e8d-4177-a0b9-feff6ea4f1e0");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "4b0fb160-ccd3-4acc-8dd0-9b3391466d22");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6e455f23-a817-41e4-858d-3286d3a4f16a");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "a95f9c73-4923-491a-91a3-cfead369845a");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "bd6faa0e-a0ac-4fdd-9d84-ba427abe33d0");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "f601187f-75c4-4e86-aa69-a4f2f3eaa5bc");

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: "1af119bf-29da-483e-b301-03c249e8b3af");

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: "3a8b9418-b940-4545-a027-277a140d7bcd");

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: "a47ce8f0-3279-4191-b567-0c9ead311460");

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: "ad6ef5c6-7706-4431-a85c-2bc94f61ff68");

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: "d2c6bd70-37a5-4345-9f6b-2f45209d05a8");

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: "e3702e37-f1b2-4ab8-86ce-2d769340c885");

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: "0c6c1a04-4ee5-4ed1-9c91-924d1934f737");

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: "305d3e75-cbea-45a3-b6a1-12b12e9bc654");

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: "4ad047cb-1960-4b08-a68b-d4c68231176f");

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: "9ac55b20-fc0a-47aa-ae34-2b1bbf5d0afc");

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: "baeb98f8-33a1-4ef8-9ea1-5b94cc5cf5e6");

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: "ed41d6f4-dfe3-4fab-9ccd-ff085302f819");

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: "fb1a21db-2704-4c10-9dd9-be06678a6513");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "07429971-268b-47ac-9bde-a0a366ade746");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "19b2788c-60f8-45a0-8c26-ce8f0f3fa980");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "445a999c-9360-4786-b0e3-79109ee46162");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "45c7ef0d-8cbc-4a19-84f9-93077d49814a");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "70479e49-d7b5-4e6a-a13f-4a7d1cde886c");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "7d9627b3-5549-4eef-9d3a-9cc13608f472");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "81b0fc2d-2f53-4a03-8b51-471408dab7cf");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "870a4107-5cb5-4152-b444-2edcd9271cbe");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "8d8836f2-5da7-4ea3-9d1a-d72080869aa5");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "b12d905d-9f36-42aa-a1fe-d8deb61f2def");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "b51126a6-a2d8-4397-9eb3-b18d15b75594");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "c87ea713-f4b0-45e7-96a6-1e801cb25f42");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "e05b7239-c545-435a-b5fc-662cfa50d5d0");

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: "f3224334-5bcd-4417-98a0-269abcdc36b3");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ReligiousGroups",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "CCGCodeId",
                table: "GPPractices",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine5",
                table: "GPPractices",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine4",
                table: "GPPractices",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine3",
                table: "GPPractices",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "GPPractices",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "GPPractices",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "GPPractices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "EClinicalReferralInfoID",
                table: "eTreatments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eTreatments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "EthnicCategories",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "eReferralId",
                table: "eSexualOffences",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<string>(
                name: "BriefSummary",
                table: "eSexualOffences",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eSexualOffences",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ECommonSurvivorImpactId",
                table: "eServices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eServices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "EReferralId",
                table: "eRiskIndicators",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "eRiskIndicators",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eRiskIndicators",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedDate",
                table: "EReferrals",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "EReferrals",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ECommonSurvivorImpactId",
                table: "eProbationServices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<bool>(
                name: "ConsentToContact",
                table: "eProbationServices",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eProbationServices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ECommonSurvivorImpactId",
                table: "eOffences",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eOffences",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "EReferralId",
                table: "eLongTermPhysicalHealths",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "eLongTermPhysicalHealths",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eLongTermPhysicalHealths",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "eReferralId",
                table: "eIsvaReferralInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<bool>(
                name: "VictimSupportBeenContact",
                table: "eIsvaReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "PoliceInvolved",
                table: "eIsvaReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsvaReferralService",
                table: "eIsvaReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "CurrentlyReceivingSupport",
                table: "eIsvaReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "CurrentOpenInvestigation",
                table: "eIsvaReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eIsvaReferralInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReligionId",
                table: "EDiversities",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EthnicCategoryId",
                table: "EDiversities",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EReferralId",
                table: "EDiversities",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "EDiversities",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "GpPracticeId",
                table: "EContactDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EReferralId",
                table: "EContactDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "CityId",
                table: "EContactDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "EContactDetails",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "EContactDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<bool>(
                name: "ServedOrCurrentlyUnderInvestigation",
                table: "eCommonSurvivorImpacts",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "PrescribedAnyMedicalDetails",
                table: "eCommonSurvivorImpacts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HasAnyIssuesWithDrugsDetail",
                table: "eCommonSurvivorImpacts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasAnyIssuesWithDrugs",
                table: "eCommonSurvivorImpacts",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "FinalComments",
                table: "eCommonSurvivorImpacts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EReferralId",
                table: "eCommonSurvivorImpacts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eCommonSurvivorImpacts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "eReferralId",
                table: "eClinicalReferralInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<string>(
                name: "StatedMentalHealth",
                table: "eClinicalReferralInfos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasMentalHealthDiag",
                table: "eClinicalReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "ClinicalSupportService",
                table: "eClinicalReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "AccessingService",
                table: "eClinicalReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "AccessedSMBefore",
                table: "eClinicalReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "AccessedCurrentlyOtherService",
                table: "eClinicalReferralInfos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eClinicalReferralInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<bool>(
                name: "MemberOfArmedForce",
                table: "eArmedForces",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<Guid>(
                name: "EReferralId",
                table: "eArmedForces",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "eArmedForces",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "EReferralId",
                table: "EAgencyInformations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<bool>(
                name: "AgencyHasClientConsent",
                table: "EAgencyInformations",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "EAgencyInformations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "DisabilityCodes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Cities",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "CCGCodes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("47b525ca-a769-45c8-8032-09c823c933b0"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("49dce69f-f982-4945-8cc8-29a45a9d5705"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("285cfc9a-7237-4567-a68f-c54eda7d2e2f"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("5f44cbbc-8bf5-4b87-b6fa-8354aa12e7b0"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("712b4ae3-bea5-4001-b471-b1c038c6e058"), "Other" },
                    { new Guid("3111aeff-d6f4-4360-bc51-a084af2339b5"), "Chester" },
                    { new Guid("cea1846c-59b5-4767-9df6-7a3ec1a7599f"), "Leeds" },
                    { new Guid("5823b5f4-dc89-4529-93f9-4c381562a8cf"), "Oldhan" },
                    { new Guid("81641058-a304-4dbc-b55f-0b9773bc6ddd"), "Salfor" },
                    { new Guid("b133a7a5-363c-41f0-ba32-50ee851f5483"), "Manchester" },
                    { new Guid("203a0f91-d470-426e-b841-c024103bb25b"), "Liverpool" },
                    { new Guid("54f695f6-2d48-4d31-81df-c0d844fa440f"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("9492afb5-855d-4d10-b022-c2328f91e02a"), "01", "Behaviour and Emotional" },
                    { new Guid("07a7d8ab-6f27-4970-9682-bc6f86a0f30c"), "02", "Hearing" },
                    { new Guid("36c78e8f-456c-4ab5-8c3f-f5eff3e1e72e"), "03", "Manual Dexterity" },
                    { new Guid("7102f88f-9dfb-426f-a8fa-80ac255a4b63"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("e985a1df-1069-4de1-b87e-2418054bad6f"), "XX", "Other" },
                    { new Guid("b3e5155a-50bc-4942-80b2-71208c0f4249"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("fe09b199-33c2-4d9e-a1d0-b7c285d2cb1d"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("0bbad857-dab3-4b7d-a5a5-a5b759f1fff6"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("43bacb35-e0f4-4dbb-8786-b0380970acc0"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("ef5cb263-9e66-4771-acb7-c7d3e180db7d"), "B", "White - Irish", 20 },
                    { new Guid("f93f8558-3185-4c53-8846-aae59d79daf8"), "C", "White - Any other White background", 23 },
                    { new Guid("c70732fb-60b5-43cc-b07e-f16aeafa5f03"), "A", "White -British", 15 },
                    { new Guid("8ad2da12-e9ac-4935-8af9-2dd9c454a1ce"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("3316ca5c-6aa5-4009-b775-6dbdeaa9b965"), "L", "None" },
                    { new Guid("39c5c0a7-d811-4542-80df-e8d56e7455bd"), "K", "Other" },
                    { new Guid("88c64437-0164-4141-88f0-74e0e401b9f6"), "J", "Zoroastrian" },
                    { new Guid("53bb2569-7a5f-45e6-9177-8a80f2e3d6a6"), "I", "Sikh" },
                    { new Guid("d5a5dd79-1d13-422b-88e9-d1936c36d505"), "H", "Pagan" },
                    { new Guid("5895559e-0b1e-412e-9007-5c313359eab8"), "G", "Muslim" },
                    { new Guid("45b0580f-a0b2-4e29-a6d9-8ff7559c2fa5"), "F", "Jewish" },
                    { new Guid("be09028c-28e0-43ec-98d1-b553ad0858b0"), "D", "Hindu" },
                    { new Guid("3d64fd68-c8e3-47b9-9346-c8e60365997e"), "C", "Christian" },
                    { new Guid("8e1fa4dc-b9a9-4157-a226-eae4c3786d38"), "B", "Buddhist" },
                    { new Guid("6edfdff5-72f6-4ba0-9035-3dd3581916f4"), "A", "Baha'i" },
                    { new Guid("c6bb0079-4986-49ee-95f7-65b886592e8f"), "M", "Declines to Disclose" },
                    { new Guid("e10a16a8-6a1b-48f2-be84-e38ec0000fdd"), "E", "Jain" },
                    { new Guid("be509ea0-6245-4298-9869-d5da33deeb5f"), "N", "Patient Religion Unknown" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_eProbationServices_eCommonSurvivorImpacts_ECommonSurvivorImpactId",
                table: "eProbationServices",
                column: "ECommonSurvivorImpactId",
                principalTable: "eCommonSurvivorImpacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eProbationServices_eCommonSurvivorImpacts_ECommonSurvivorImpactId",
                table: "eProbationServices");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("285cfc9a-7237-4567-a68f-c54eda7d2e2f"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("47b525ca-a769-45c8-8032-09c823c933b0"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("49dce69f-f982-4945-8cc8-29a45a9d5705"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("5f44cbbc-8bf5-4b87-b6fa-8354aa12e7b0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("203a0f91-d470-426e-b841-c024103bb25b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3111aeff-d6f4-4360-bc51-a084af2339b5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("54f695f6-2d48-4d31-81df-c0d844fa440f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5823b5f4-dc89-4529-93f9-4c381562a8cf"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("712b4ae3-bea5-4001-b471-b1c038c6e058"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("81641058-a304-4dbc-b55f-0b9773bc6ddd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b133a7a5-363c-41f0-ba32-50ee851f5483"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cea1846c-59b5-4767-9df6-7a3ec1a7599f"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("07a7d8ab-6f27-4970-9682-bc6f86a0f30c"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("36c78e8f-456c-4ab5-8c3f-f5eff3e1e72e"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("7102f88f-9dfb-426f-a8fa-80ac255a4b63"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("9492afb5-855d-4d10-b022-c2328f91e02a"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("b3e5155a-50bc-4942-80b2-71208c0f4249"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("e985a1df-1069-4de1-b87e-2418054bad6f"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("0bbad857-dab3-4b7d-a5a5-a5b759f1fff6"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("43bacb35-e0f4-4dbb-8786-b0380970acc0"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ad2da12-e9ac-4935-8af9-2dd9c454a1ce"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c70732fb-60b5-43cc-b07e-f16aeafa5f03"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef5cb263-9e66-4771-acb7-c7d3e180db7d"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("f93f8558-3185-4c53-8846-aae59d79daf8"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe09b199-33c2-4d9e-a1d0-b7c285d2cb1d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3316ca5c-6aa5-4009-b775-6dbdeaa9b965"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("39c5c0a7-d811-4542-80df-e8d56e7455bd"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3d64fd68-c8e3-47b9-9346-c8e60365997e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("45b0580f-a0b2-4e29-a6d9-8ff7559c2fa5"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("53bb2569-7a5f-45e6-9177-8a80f2e3d6a6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5895559e-0b1e-412e-9007-5c313359eab8"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6edfdff5-72f6-4ba0-9035-3dd3581916f4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("88c64437-0164-4141-88f0-74e0e401b9f6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("8e1fa4dc-b9a9-4157-a226-eae4c3786d38"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("be09028c-28e0-43ec-98d1-b553ad0858b0"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("be509ea0-6245-4298-9869-d5da33deeb5f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c6bb0079-4986-49ee-95f7-65b886592e8f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d5a5dd79-1d13-422b-88e9-d1936c36d505"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("e10a16a8-6a1b-48f2-be84-e38ec0000fdd"));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ReligiousGroups",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "CCGCodeId",
                table: "GPPractices",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine5",
                table: "GPPractices",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine4",
                table: "GPPractices",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine3",
                table: "GPPractices",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "GPPractices",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "GPPractices",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "GPPractices",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "EClinicalReferralInfoID",
                table: "eTreatments",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eTreatments",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "EthnicCategories",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "eReferralId",
                table: "eSexualOffences",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "BriefSummary",
                table: "eSexualOffences",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eSexualOffences",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "ECommonSurvivorImpactId",
                table: "eServices",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eServices",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "EReferralId",
                table: "eRiskIndicators",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "eRiskIndicators",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eRiskIndicators",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedDate",
                table: "EReferrals",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "EReferrals",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "ECommonSurvivorImpactId",
                table: "eProbationServices",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<byte>(
                name: "ConsentToContact",
                table: "eProbationServices",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eProbationServices",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "ECommonSurvivorImpactId",
                table: "eOffences",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eOffences",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "EReferralId",
                table: "eLongTermPhysicalHealths",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "eLongTermPhysicalHealths",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eLongTermPhysicalHealths",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "eReferralId",
                table: "eIsvaReferralInfos",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<byte>(
                name: "VictimSupportBeenContact",
                table: "eIsvaReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "PoliceInvolved",
                table: "eIsvaReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "IsvaReferralService",
                table: "eIsvaReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "CurrentlyReceivingSupport",
                table: "eIsvaReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "CurrentOpenInvestigation",
                table: "eIsvaReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eIsvaReferralInfos",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "ReligionId",
                table: "EDiversities",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EthnicCategoryId",
                table: "EDiversities",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EReferralId",
                table: "EDiversities",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "EDiversities",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "GpPracticeId",
                table: "EContactDetails",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EReferralId",
                table: "EContactDetails",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "CityId",
                table: "EContactDetails",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "EContactDetails",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "EContactDetails",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<byte>(
                name: "ServedOrCurrentlyUnderInvestigation",
                table: "eCommonSurvivorImpacts",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "PrescribedAnyMedicalDetails",
                table: "eCommonSurvivorImpacts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HasAnyIssuesWithDrugsDetail",
                table: "eCommonSurvivorImpacts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "HasAnyIssuesWithDrugs",
                table: "eCommonSurvivorImpacts",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "FinalComments",
                table: "eCommonSurvivorImpacts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EReferralId",
                table: "eCommonSurvivorImpacts",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eCommonSurvivorImpacts",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "eReferralId",
                table: "eClinicalReferralInfos",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "StatedMentalHealth",
                table: "eClinicalReferralInfos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "HasMentalHealthDiag",
                table: "eClinicalReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "ClinicalSupportService",
                table: "eClinicalReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "AccessingService",
                table: "eClinicalReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "AccessedSMBefore",
                table: "eClinicalReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<byte>(
                name: "AccessedCurrentlyOtherService",
                table: "eClinicalReferralInfos",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eClinicalReferralInfos",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<byte>(
                name: "MemberOfArmedForce",
                table: "eArmedForces",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "EReferralId",
                table: "eArmedForces",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "eArmedForces",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "EReferralId",
                table: "EAgencyInformations",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<byte>(
                name: "AgencyHasClientConsent",
                table: "EAgencyInformations",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "EAgencyInformations",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DisabilityCodes",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Cities",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "CCGCodes",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { "fa4a6c6f-e133-40aa-9c7f-b0ff21da4c42", "01G", "NHS Salford CCG", "Q73" },
                    { "09749016-2b22-4561-b34f-04b3ff11ad43", "01M", "NHS North Manchester CCG", null },
                    { "020f19e8-1a8e-4b48-ae0d-ef5371b3dccd", "01N", "NHS South Manchester CCG", "Q73" },
                    { "737e33a8-b34f-4e4b-bb37-044d1d1f51ac", "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4b0fb160-ccd3-4acc-8dd0-9b3391466d22", "Other" },
                    { "15c91e11-fb1a-4e05-b77a-48595e69062a", "Chester" },
                    { "6e455f23-a817-41e4-858d-3286d3a4f16a", "Leeds" },
                    { "bd6faa0e-a0ac-4fdd-9d84-ba427abe33d0", "Oldhan" },
                    { "258be96b-7e8d-4177-a0b9-feff6ea4f1e0", "Salfor" },
                    { "f601187f-75c4-4e86-aa69-a4f2f3eaa5bc", "Manchester" },
                    { "0d9a3810-fdb8-4ede-8db4-e6ef3e3f4dcf", "Liverpool" },
                    { "a95f9c73-4923-491a-91a3-cfead369845a", "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { "a47ce8f0-3279-4191-b567-0c9ead311460", "01", "Behaviour and Emotional" },
                    { "e3702e37-f1b2-4ab8-86ce-2d769340c885", "02", "Hearing" },
                    { "3a8b9418-b940-4545-a027-277a140d7bcd", "03", "Manual Dexterity" },
                    { "d2c6bd70-37a5-4345-9f6b-2f45209d05a8", "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { "1af119bf-29da-483e-b301-03c249e8b3af", "XX", "Other" },
                    { "ad6ef5c6-7706-4431-a85c-2bc94f61ff68", "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { "ed41d6f4-dfe3-4fab-9ccd-ff085302f819", "F", "Mixed - White and Asian", 35 },
                    { "9ac55b20-fc0a-47aa-ae34-2b1bbf5d0afc", "G", "Mixed - Any mixed backgroundn", 40 },
                    { "4ad047cb-1960-4b08-a68b-d4c68231176f", "E", "Mixed - White and Black African", 30 },
                    { "305d3e75-cbea-45a3-b6a1-12b12e9bc654", "B", "White - Irish", 20 },
                    { "fb1a21db-2704-4c10-9dd9-be06678a6513", "C", "White - Any other White background", 23 },
                    { "0c6c1a04-4ee5-4ed1-9c91-924d1934f737", "A", "White -British", 15 },
                    { "baeb98f8-33a1-4ef8-9ea1-5b94cc5cf5e6", "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { "8d8836f2-5da7-4ea3-9d1a-d72080869aa5", "L", "None" },
                    { "70479e49-d7b5-4e6a-a13f-4a7d1cde886c", "K", "Other" },
                    { "e05b7239-c545-435a-b5fc-662cfa50d5d0", "J", "Zoroastrian" },
                    { "445a999c-9360-4786-b0e3-79109ee46162", "I", "Sikh" },
                    { "81b0fc2d-2f53-4a03-8b51-471408dab7cf", "H", "Pagan" },
                    { "c87ea713-f4b0-45e7-96a6-1e801cb25f42", "G", "Muslim" },
                    { "7d9627b3-5549-4eef-9d3a-9cc13608f472", "F", "Jewish" },
                    { "870a4107-5cb5-4152-b444-2edcd9271cbe", "D", "Hindu" },
                    { "b51126a6-a2d8-4397-9eb3-b18d15b75594", "C", "Christian" },
                    { "b12d905d-9f36-42aa-a1fe-d8deb61f2def", "B", "Buddhist" },
                    { "45c7ef0d-8cbc-4a19-84f9-93077d49814a", "A", "Baha'i" },
                    { "07429971-268b-47ac-9bde-a0a366ade746", "M", "Declines to Disclose" },
                    { "f3224334-5bcd-4417-98a0-269abcdc36b3", "E", "Jain" },
                    { "19b2788c-60f8-45a0-8c26-ce8f0f3fa980", "N", "Patient Religion Unknown" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_eProbationServices_eCommonSurvivorImpacts_ECommonSurvivorImp~",
                table: "eProbationServices",
                column: "ECommonSurvivorImpactId",
                principalTable: "eCommonSurvivorImpacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
