using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class InitialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CCGCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(5)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: false),
                    Hub = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCGCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisabilityCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(5)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EReferrals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ReceivedDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(type: "varchar(50)", nullable: false),
                    Source = table.Column<string>(type: "varchar(100)", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EReferrals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EthnicCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(5)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: false),
                    Sequence = table.Column<int>(type: "int(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EthnicCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReligiousGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(5)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReligiousGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPPractices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(6)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: false),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    AddressLine5 = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(type: "varchar(8)", nullable: true),
                    CCGCodeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPPractices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GPPractices_CCGCodes_CCGCodeId",
                        column: x => x.CCGCodeId,
                        principalTable: "CCGCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "EAgencyInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    Agency = table.Column<string>(type: "varchar(150)", nullable: false),
                    ContactPerson = table.Column<string>(type: "varchar(150)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(50)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    AgencyHasClientConsent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EAgencyInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EAgencyInformations_EReferrals_EReferralId",
                        column: x => x.EReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "eArmedForces",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    MemberOfArmedForce = table.Column<bool>(nullable: false),
                    HasLinkedWithArmedForce = table.Column<string>(type: "varchar(10)", nullable: true),
                    Branch = table.Column<int>(nullable: false),
                    ServiceNumber = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eArmedForces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eArmedForces_EReferrals_EReferralId",
                        column: x => x.EReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "eClinicalReferralInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    eReferralId = table.Column<Guid>(nullable: false),
                    ClinicalSupportService = table.Column<bool>(nullable: false),
                    AccessedSMBefore = table.Column<bool>(nullable: false),
                    SMBeforeWhen = table.Column<string>(type: "varchar(50)", nullable: true),
                    HasMentalHealthDiag = table.Column<bool>(nullable: false),
                    StatedMentalHealth = table.Column<string>(nullable: true),
                    AccessedCurrentlyOtherService = table.Column<bool>(nullable: false),
                    AccessingService = table.Column<bool>(nullable: false),
                    AccessingServiceWorkName = table.Column<string>(type: "varchar(100)", nullable: true),
                    AccessingServiceWorkService = table.Column<string>(type: "varchar(100)", nullable: true),
                    AccessingServiceWorkTel = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eClinicalReferralInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eClinicalReferralInfos_EReferrals_eReferralId",
                        column: x => x.eReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    ServedOrCurrentlyUnderInvestigation = table.Column<bool>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "eRiskIndicators",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    HasClientRisk = table.Column<string>(type: "varchar(50)", nullable: false),
                    Details = table.Column<string>(nullable: true),
                    SuicideRisk = table.Column<int>(nullable: false),
                    SelfHarmRisk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eRiskIndicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eRiskIndicators_EReferrals_EReferralId",
                        column: x => x.EReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "EDiversities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    Gender = table.Column<string>(type: "varchar(50)", nullable: false),
                    IsgenderAssignedAtBirth = table.Column<string>(type: "varchar(50)", nullable: false),
                    EthnicCategoryId = table.Column<Guid>(nullable: true),
                    Sexuality = table.Column<string>(type: "varchar(50)", nullable: false),
                    ReligionId = table.Column<Guid>(nullable: true),
                    MaritalStatus = table.Column<string>(type: "varchar(50)", nullable: false),
                    ParentalStatus = table.Column<string>(type: "varchar(50)", nullable: false),
                    PhysicalDisability = table.Column<string>(type: "varchar(50)", nullable: false),
                    PhysicalDisabilityState = table.Column<string>(type: "varchar(500)", nullable: true),
                    SpecificSupportNeeds = table.Column<string>(type: "varchar(50)", nullable: false),
                    SpecificSupportNeedState = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDiversities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EDiversities_EReferrals_EReferralId",
                        column: x => x.EReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EDiversities_EthnicCategories_EthnicCategoryId",
                        column: x => x.EthnicCategoryId,
                        principalTable: "EthnicCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_EDiversities_ReligiousGroups_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "ReligiousGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "EContactDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    NHSNumber = table.Column<string>(type: "varchar(50)", nullable: true),
                    GpPracticeId = table.Column<Guid>(nullable: true),
                    FirstName = table.Column<string>(type: "varchar(150)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(150)", nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    PostCode = table.Column<string>(type: "varchar(50)", nullable: false),
                    Address1 = table.Column<string>(type: "varchar(100)", nullable: false),
                    Address2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    CityId = table.Column<Guid>(nullable: true),
                    anotherCity = table.Column<string>(type: "varchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(50)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(50)", nullable: true),
                    Email = table.Column<string>(type: "varchar(150)", nullable: true),
                    MethodsToContact = table.Column<string>(type: "varchar(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EContactDetails_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_EContactDetails_EReferrals_EReferralId",
                        column: x => x.EReferralId,
                        principalTable: "EReferrals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EContactDetails_GPPractices_GpPracticeId",
                        column: x => x.GpPracticeId,
                        principalTable: "GPPractices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "eTreatments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EClinicalReferralInfoID = table.Column<Guid>(nullable: false),
                    Service = table.Column<string>(type: "varchar(100)", nullable: true),
                    TreatmentProvided = table.Column<string>(type: "varchar(100)", nullable: true),
                    Start = table.Column<string>(type: "varchar(50)", nullable: true),
                    End = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_eTreatments_eClinicalReferralInfos_EClinicalReferralInfoID",
                        column: x => x.EClinicalReferralInfoID,
                        principalTable: "eClinicalReferralInfos",
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
                        name: "FK_eProbationServices_eCommonSurvivorImpacts_ECommonSurvivorImpactId",
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
                    { new Guid("bb55d1e0-52e7-460e-a803-b68b0a26e5a7"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("93f3a833-5efd-422b-8f17-213df5eff2cd"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("880546c0-5a1d-4362-ac36-5877b4568f78"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("f4cfab55-a07a-49fe-80c6-fcb7d68be2c4"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1824dc7b-4373-4323-ada8-401a945c044b"), "Other" },
                    { new Guid("a44c7024-5ba2-410f-8b9f-1594dc122e13"), "Chester" },
                    { new Guid("462a8b76-827f-4028-b9ed-e09b60944f09"), "Leeds" },
                    { new Guid("5a47ce65-1672-47f6-b865-b7e9f077c173"), "Oldhan" },
                    { new Guid("13664d32-c73e-4b52-b9e3-4ba588832001"), "Salfor" },
                    { new Guid("d41c4240-a8cd-4b79-93d5-f81667fda458"), "Manchester" },
                    { new Guid("e4d7ae5d-7ec5-4bbf-a215-ee5172c5efe2"), "Liverpool" },
                    { new Guid("eda94419-7997-46b9-8b00-1ccec00af0a9"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("2f67b95c-b76d-4376-b964-93a78f92ad48"), "01", "Behaviour and Emotional" },
                    { new Guid("a1d7e58e-d0e0-4515-bf59-fe98c52f24a8"), "02", "Hearing" },
                    { new Guid("20465deb-31d6-42a7-95be-a369731f64f4"), "03", "Manual Dexterity" },
                    { new Guid("8bc1ad23-9bc2-4395-bf57-189a25e8dab7"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("b6524e99-0b78-4862-a8f0-fe875ab243e3"), "XX", "Other" },
                    { new Guid("19bd1950-78ef-4281-a570-26bd91da9abf"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("3acdf39a-98f2-49a5-bef6-45c1e331df94"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("7e608cba-bb1b-4848-ad05-da6cce0f09f3"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("812827a5-9ec0-4879-b21c-d6633960f59f"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("f5e2d10f-7334-4043-95c6-b4a9734d37c7"), "B", "White - Irish", 20 },
                    { new Guid("9b466dfa-d984-4c27-af7f-a0c6c1ef5839"), "C", "White - Any other White background", 23 },
                    { new Guid("c4fe5163-4135-4265-a7ef-c4248501712d"), "A", "White -British", 15 },
                    { new Guid("639b2727-aea7-4331-96c2-bdf99f9ae00b"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("92e88df6-23ca-46a9-aebf-f4ecabd87e69"), "L", "None" },
                    { new Guid("838f4a3a-7cc1-4483-ac89-275bd8fe6685"), "K", "Other" },
                    { new Guid("587ee53a-677b-47e4-9d4c-ff26e6e20224"), "J", "Zoroastrian" },
                    { new Guid("e3b0bace-bf59-4308-b06b-70c373533e0d"), "I", "Sikh" },
                    { new Guid("1906c7fc-297d-4e41-bbf5-c8e602021627"), "H", "Pagan" },
                    { new Guid("b66f1a95-44cf-46c3-80c9-d05e1e734225"), "G", "Muslim" },
                    { new Guid("56f8b973-0643-418e-964a-60d1c8cb77cd"), "F", "Jewish" },
                    { new Guid("16e82073-a6b0-4579-ade5-d180fe534995"), "D", "Hindu" },
                    { new Guid("e9086520-7a6d-41fd-a62f-b38f6fb60874"), "C", "Christian" },
                    { new Guid("35a20e9f-b8d5-48b4-95c3-5f57f3877571"), "B", "Buddhist" },
                    { new Guid("0c5f0c60-7cda-4954-aa96-eb807b7d2a8b"), "A", "Baha'i" },
                    { new Guid("04c15bc2-d3a5-4298-9e0d-0b0959a907da"), "M", "Declines to Disclose" },
                    { new Guid("46aa7699-af81-4c79-8d44-dac4894aa280"), "E", "Jain" },
                    { new Guid("4ed7f383-982c-485b-95c1-7de0f987aac4"), "N", "Patient Religion Unknown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CCGCodes_Code",
                table: "CCGCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisabilityCodes_Code",
                table: "DisabilityCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EAgencyInformations_EReferralId",
                table: "EAgencyInformations",
                column: "EReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eArmedForces_EReferralId",
                table: "eArmedForces",
                column: "EReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eClinicalReferralInfos_eReferralId",
                table: "eClinicalReferralInfos",
                column: "eReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eCommonSurvivorImpacts_EReferralId",
                table: "eCommonSurvivorImpacts",
                column: "EReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EContactDetails_CityId",
                table: "EContactDetails",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_EContactDetails_EReferralId",
                table: "EContactDetails",
                column: "EReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EContactDetails_GpPracticeId",
                table: "EContactDetails",
                column: "GpPracticeId");

            migrationBuilder.CreateIndex(
                name: "IX_EDiversities_EReferralId",
                table: "EDiversities",
                column: "EReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EDiversities_EthnicCategoryId",
                table: "EDiversities",
                column: "EthnicCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EDiversities_ReligionId",
                table: "EDiversities",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_eIsvaReferralInfos_eReferralId",
                table: "eIsvaReferralInfos",
                column: "eReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eLongTermPhysicalHealths_EReferralId",
                table: "eLongTermPhysicalHealths",
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
                name: "IX_eRiskIndicators_EReferralId",
                table: "eRiskIndicators",
                column: "EReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eServices_ECommonSurvivorImpactId",
                table: "eServices",
                column: "ECommonSurvivorImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_eSexualOffences_eReferralId",
                table: "eSexualOffences",
                column: "eReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EthnicCategories_Code",
                table: "EthnicCategories",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eTreatments_EClinicalReferralInfoID",
                table: "eTreatments",
                column: "EClinicalReferralInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_GPPractices_CCGCodeId",
                table: "GPPractices",
                column: "CCGCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_GPPractices_Code",
                table: "GPPractices",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReligiousGroups_Code",
                table: "ReligiousGroups",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisabilityCodes");

            migrationBuilder.DropTable(
                name: "EAgencyInformations");

            migrationBuilder.DropTable(
                name: "eArmedForces");

            migrationBuilder.DropTable(
                name: "EContactDetails");

            migrationBuilder.DropTable(
                name: "EDiversities");

            migrationBuilder.DropTable(
                name: "eIsvaReferralInfos");

            migrationBuilder.DropTable(
                name: "eLongTermPhysicalHealths");

            migrationBuilder.DropTable(
                name: "eOffences");

            migrationBuilder.DropTable(
                name: "eProbationServices");

            migrationBuilder.DropTable(
                name: "eRiskIndicators");

            migrationBuilder.DropTable(
                name: "eServices");

            migrationBuilder.DropTable(
                name: "eSexualOffences");

            migrationBuilder.DropTable(
                name: "eTreatments");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "GPPractices");

            migrationBuilder.DropTable(
                name: "EthnicCategories");

            migrationBuilder.DropTable(
                name: "ReligiousGroups");

            migrationBuilder.DropTable(
                name: "eCommonSurvivorImpacts");

            migrationBuilder.DropTable(
                name: "eClinicalReferralInfos");

            migrationBuilder.DropTable(
                name: "CCGCodes");

            migrationBuilder.DropTable(
                name: "EReferrals");
        }
    }
}
