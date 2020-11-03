using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class InitialDB : Migration
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
                name: "EDiversities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    Gender = table.Column<string>(type: "varchar(50)", nullable: false),
                    IsgenderAssignedAtBirth = table.Column<string>(type: "varchar(50)", nullable: false),
                    EthnicCategoryId = table.Column<Guid>(nullable: false),
                    Sexuality = table.Column<string>(type: "varchar(50)", nullable: false),
                    ReligionId = table.Column<Guid>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EDiversities_ReligiousGroups_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "ReligiousGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("26e2917d-6e66-4196-86ae-0356f1ec9849"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("82ee76be-ebc2-43cc-b7ae-e56f94bc04a0"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("cb70014d-e488-473f-adee-09dec20f14ff"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("513ed5e6-a9f8-4525-bcb1-2be50ca8df4e"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("546b0715-c6c0-4579-ac1f-f2848a82a75c"), "Other" },
                    { new Guid("bea04ca5-2c4c-471e-b651-83a6e39bdc7a"), "Chester" },
                    { new Guid("bc8a4f58-9e77-4f15-af67-c0c2ec69a2d4"), "Leeds" },
                    { new Guid("224675de-554c-4634-be80-516d9e470003"), "Oldhan" },
                    { new Guid("15563676-b516-46ef-8e0d-4e914a3482e4"), "Salfor" },
                    { new Guid("f94bfa97-444c-488e-9b03-794852666e17"), "Manchester" },
                    { new Guid("5216453e-af89-4e45-b37c-08f4ce29dcc1"), "Liverpool" },
                    { new Guid("a48054f3-ef13-448d-aef1-d33d1edde9d4"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("90409b58-bdf6-4a76-8c52-1eb8e15da4ff"), "01", "Behaviour and Emotional" },
                    { new Guid("e42896c2-fd95-4a91-b7f1-4b391f42c3d0"), "02", "Hearing" },
                    { new Guid("62444bc7-c38e-4611-bc08-a3763f02d5e7"), "03", "Manual Dexterity" },
                    { new Guid("8a551c10-b4d7-4b8e-80e7-0c36e4680a74"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("eba929b1-bdb0-497c-a068-2b349bd90613"), "XX", "Other" },
                    { new Guid("8131e6cd-577e-40b2-8508-7b023e4ff6d8"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("c4b77fce-ad5d-4c73-9d5d-9ca6261e4005"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("e5a49a0f-5b99-464e-8ef2-336a55e7aa0c"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("4526b3e4-02d5-4485-aaa0-16a8b620d20b"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("4a3dd610-ca57-449d-bcad-1e707b66c3ac"), "B", "White - Irish", 20 },
                    { new Guid("7b49fd1f-ebbf-4157-95af-b91199b954cb"), "C", "White - Any other White background", 23 },
                    { new Guid("619c51e0-9d8d-4b65-a89b-e791de749477"), "A", "White -British", 15 },
                    { new Guid("c8dff924-cc48-4868-9192-9303a44443fa"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("9a20a87c-f960-4e95-bae4-aa400ea1a291"), "L", "None" },
                    { new Guid("f24d4634-adf2-46c9-8872-400d5f0e8949"), "K", "Other" },
                    { new Guid("72c9841a-fcb9-49f9-8edc-aa61c625a6c4"), "J", "Zoroastrian" },
                    { new Guid("bf6f9139-2bdd-4e6b-b220-2737988796b5"), "I", "Sikh" },
                    { new Guid("dfd74e1b-8039-44ed-8bb5-e70c98228758"), "H", "Pagan" },
                    { new Guid("0fbb6d5d-0d79-4f7f-82d5-b63c0016c8ef"), "G", "Muslim" },
                    { new Guid("f940efdd-8bdc-42db-970c-d3632b3f2f13"), "F", "Jewish" },
                    { new Guid("1d71a7cb-74b7-4a09-ada3-3e8f70e26705"), "D", "Hindu" },
                    { new Guid("41ed053f-bc00-479b-b119-98608e28e197"), "C", "Christian" },
                    { new Guid("e74b9f2a-0c37-47cb-a967-e4b2baaba75c"), "B", "Buddhist" },
                    { new Guid("0879953c-3cef-4740-85e0-2d4595d1126d"), "A", "Baha'i" },
                    { new Guid("4c29898e-a721-4501-986e-a0d019f3e01a"), "M", "Declines to Disclose" },
                    { new Guid("10d036e6-9c9e-43b5-984b-9a10bcedd009"), "E", "Jain" },
                    { new Guid("31bb43dc-c0f3-4832-8518-0a6afbe62944"), "N", "Patient Religion Unknown" }
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
                name: "IX_EthnicCategories_Code",
                table: "EthnicCategories",
                column: "Code",
                unique: true);

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
                name: "EContactDetails");

            migrationBuilder.DropTable(
                name: "EDiversities");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "GPPractices");

            migrationBuilder.DropTable(
                name: "EReferrals");

            migrationBuilder.DropTable(
                name: "EthnicCategories");

            migrationBuilder.DropTable(
                name: "ReligiousGroups");

            migrationBuilder.DropTable(
                name: "CCGCodes");
        }
    }
}
