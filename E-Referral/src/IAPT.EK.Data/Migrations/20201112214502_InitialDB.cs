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
                name: "eArmedForces",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EReferralId = table.Column<Guid>(nullable: false),
                    MemberOfArmedForce = table.Column<bool>(nullable: false),
                    HasLinkedWithArmedForce = table.Column<bool>(nullable: false),
                    Branch = table.Column<int>(nullable: false),
                    ServiceNumber = table.Column<string>(nullable: true)
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
                name: "eArmedForces");

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
