using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class ClinicalReferralTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("1e828b72-16ae-4a82-ae84-83f5dc97dab6"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("4ae491bd-f467-4f1e-ad54-b66d718b3e37"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("8c3c11ce-0803-4c8e-89aa-36c7c0c62351"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("8e9eb68a-e148-42a6-9b3d-1a3c57e6139e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("48aa377a-4e12-4681-ac0e-e6342e900251"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4c1bd626-9819-4eae-b146-0ef4fab04198"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4ed836bf-2f69-4124-8cfb-2348c2c1288e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7f55eb72-b921-4d89-aa92-82be6fbf7970"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9497f9c0-5dd7-4797-a206-e611a14f3631"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b0cf2102-87cb-46e6-b5f0-84772c2e3d2b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b6ecfb57-8719-40da-9500-1f31425bdfad"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e288f01d-eccf-4849-b890-a9caaec1fabc"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("aec6e5ba-01e8-451f-a09c-d46bb88283cc"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("b8e8b563-bee3-4aab-8d28-7f54ac6da481"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d61e5028-0557-4295-a78c-ea8a9c2b52bb"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("e497ed4b-b448-421c-89b3-91646fc4a703"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("ed9fed27-001e-492c-bfe9-1096fb8aff04"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("f367fb1c-7e3d-42cf-be59-9e63e9718a73"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b360b98-ab87-431e-bd40-cba25a3572c0"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("46a1ac8e-7e36-408a-a8c0-dbdcad9c85d3"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("9520472c-58ee-432b-a96e-6674c3e300d4"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ef11ff6-5c1b-4eb1-bddb-e2aedb90cebb"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("affe8141-4e77-402a-b42b-aa7a87d22f92"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("d43b7774-dc0b-42f5-af26-42c676bbe853"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("e318efee-0721-4af9-ba3a-c6f61bc169e5"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("0be04169-dc19-4c13-b007-e8efc5f17697"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2c23012d-3981-4158-a9ca-a311853066ca"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3f7cb448-990e-44bc-8049-1d6333688d2c"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("44017765-b880-49ea-b301-a21c2628a597"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("4d0baea6-a7f1-4b67-8eeb-424d1659a662"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("54eee404-50d8-4141-8011-bede38ec48fe"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5d06cce9-fcfa-406b-ab6c-5cd8204e965a"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("60efb1bf-2649-4a9a-b7bb-48fecb642797"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("852df558-7659-4c11-bb99-06d00527adfb"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9d4d699e-91a7-4027-b8fc-3b74b705c2b4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("afc88582-2585-4686-b2d9-a8372d3fe503"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("bb56183e-23a8-432a-981b-c607b07eb34f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("cf50075e-5c1c-4cc1-ba19-43d8659fde0e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d50eed39-04ad-4859-929b-ab3ef9b9d575"));

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
                    StateMentalHealth = table.Column<string>(nullable: true),
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

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("fd1ffb7d-04c4-45bd-8727-701c65fc4878"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("0027dfe1-68de-4f10-a18d-272ca006c7a8"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("a02f4d0f-a526-4933-8734-ea9456875bd5"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("1ce773c9-8582-4636-9310-7143ff48a77e"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("44f3954e-c021-49f4-9c7f-c06d74eebc96"), "Other" },
                    { new Guid("c1034983-d1e3-4b91-8098-656bb05eeeeb"), "Chester" },
                    { new Guid("0707a8d4-7e0c-43e9-983a-a2a739b310e5"), "Leeds" },
                    { new Guid("a0c8857e-f9ee-47bc-8cdf-9570abdf278c"), "Oldhan" },
                    { new Guid("c24af278-951d-4ad5-98b7-ccfab5734804"), "Salfor" },
                    { new Guid("e79201b8-0a2c-42fd-8c96-855484bf222d"), "Manchester" },
                    { new Guid("3f19bd16-ccfe-46f1-85cc-f2879ee7d6b5"), "Liverpool" },
                    { new Guid("0b0bd0f6-44f7-4ace-8ff5-c4e549e6d835"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("9a7a666a-e44a-4011-a03b-a8b34944c4a0"), "01", "Behaviour and Emotional" },
                    { new Guid("58ca681e-f8fd-4583-9286-5a84c9ed0ab2"), "02", "Hearing" },
                    { new Guid("f0a79ac6-547f-4aa2-b1c9-41465ea647c2"), "03", "Manual Dexterity" },
                    { new Guid("5fbb4513-d5b1-46ca-89d7-8d022e36540a"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("c3ee6e4d-86bd-4360-8c3b-ba4bcfb4f474"), "XX", "Other" },
                    { new Guid("f0a3185c-9c3a-4bbd-a5ae-1bcf6031fde1"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("8579c981-81e4-4b38-b01d-c2b81b043c8b"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("43c98f07-e1a8-4a1d-bde3-864f17f7928b"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("41bdcc76-6f34-48f7-a29f-2e6dc5e78480"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("24714fd3-8e12-4a5d-825d-0d8a5e2a252b"), "B", "White - Irish", 20 },
                    { new Guid("8e5186d0-4f34-427b-bb5d-c4a978f2bd92"), "C", "White - Any other White background", 23 },
                    { new Guid("cc917565-2789-4f6f-aead-20672c53d034"), "A", "White -British", 15 },
                    { new Guid("6ed5c2dd-d3c9-4d54-8556-0c1d72d157e5"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("560aac9e-2275-4999-91ab-28e12e299c90"), "L", "None" },
                    { new Guid("69f45d82-ee82-43fd-9016-81da1196ef87"), "K", "Other" },
                    { new Guid("936edc6e-0ee3-44f4-b1fe-ecdf0a387ab2"), "J", "Zoroastrian" },
                    { new Guid("3d4a1395-06d1-4f1c-8f24-7c5737a7fd6d"), "I", "Sikh" },
                    { new Guid("49edd8ef-633c-450f-b798-cb6a4609ab97"), "H", "Pagan" },
                    { new Guid("9c34b890-077d-447d-89fd-af56523b8422"), "G", "Muslim" },
                    { new Guid("c36d074a-8643-4e39-9b68-defb63124314"), "F", "Jewish" },
                    { new Guid("85c4ef45-ef3b-419c-8210-a1ae3ee0e3ff"), "D", "Hindu" },
                    { new Guid("c8e54787-abee-4544-9864-c4c4e664e92d"), "C", "Christian" },
                    { new Guid("df7cfdc5-9731-466d-b02e-6b9b4790900b"), "B", "Buddhist" },
                    { new Guid("abc68998-3f3b-43e2-91e5-34ab8e8e946d"), "A", "Baha'i" },
                    { new Guid("73fa427f-343c-4452-9bbb-11cbafce7d32"), "M", "Declines to Disclose" },
                    { new Guid("601a4682-364d-42b4-a023-46eb5a98d731"), "E", "Jain" },
                    { new Guid("43e988e6-c0e5-420c-b66a-40d4d163370b"), "N", "Patient Religion Unknown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_eClinicalReferralInfos_eReferralId",
                table: "eClinicalReferralInfos",
                column: "eReferralId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_eTreatments_EClinicalReferralInfoID",
                table: "eTreatments",
                column: "EClinicalReferralInfoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eTreatments");

            migrationBuilder.DropTable(
                name: "eClinicalReferralInfos");

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("0027dfe1-68de-4f10-a18d-272ca006c7a8"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("1ce773c9-8582-4636-9310-7143ff48a77e"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("a02f4d0f-a526-4933-8734-ea9456875bd5"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("fd1ffb7d-04c4-45bd-8727-701c65fc4878"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0707a8d4-7e0c-43e9-983a-a2a739b310e5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b0bd0f6-44f7-4ace-8ff5-c4e549e6d835"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3f19bd16-ccfe-46f1-85cc-f2879ee7d6b5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("44f3954e-c021-49f4-9c7f-c06d74eebc96"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a0c8857e-f9ee-47bc-8cdf-9570abdf278c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c1034983-d1e3-4b91-8098-656bb05eeeeb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c24af278-951d-4ad5-98b7-ccfab5734804"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e79201b8-0a2c-42fd-8c96-855484bf222d"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("58ca681e-f8fd-4583-9286-5a84c9ed0ab2"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("5fbb4513-d5b1-46ca-89d7-8d022e36540a"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("9a7a666a-e44a-4011-a03b-a8b34944c4a0"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("c3ee6e4d-86bd-4360-8c3b-ba4bcfb4f474"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("f0a3185c-9c3a-4bbd-a5ae-1bcf6031fde1"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("f0a79ac6-547f-4aa2-b1c9-41465ea647c2"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("24714fd3-8e12-4a5d-825d-0d8a5e2a252b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("41bdcc76-6f34-48f7-a29f-2e6dc5e78480"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("43c98f07-e1a8-4a1d-bde3-864f17f7928b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ed5c2dd-d3c9-4d54-8556-0c1d72d157e5"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8579c981-81e4-4b38-b01d-c2b81b043c8b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e5186d0-4f34-427b-bb5d-c4a978f2bd92"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc917565-2789-4f6f-aead-20672c53d034"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3d4a1395-06d1-4f1c-8f24-7c5737a7fd6d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("43e988e6-c0e5-420c-b66a-40d4d163370b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("49edd8ef-633c-450f-b798-cb6a4609ab97"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("560aac9e-2275-4999-91ab-28e12e299c90"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("601a4682-364d-42b4-a023-46eb5a98d731"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("69f45d82-ee82-43fd-9016-81da1196ef87"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("73fa427f-343c-4452-9bbb-11cbafce7d32"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("85c4ef45-ef3b-419c-8210-a1ae3ee0e3ff"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("936edc6e-0ee3-44f4-b1fe-ecdf0a387ab2"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9c34b890-077d-447d-89fd-af56523b8422"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("abc68998-3f3b-43e2-91e5-34ab8e8e946d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c36d074a-8643-4e39-9b68-defb63124314"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c8e54787-abee-4544-9864-c4c4e664e92d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("df7cfdc5-9731-466d-b02e-6b9b4790900b"));

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("4ae491bd-f467-4f1e-ad54-b66d718b3e37"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("8e9eb68a-e148-42a6-9b3d-1a3c57e6139e"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("1e828b72-16ae-4a82-ae84-83f5dc97dab6"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("8c3c11ce-0803-4c8e-89aa-36c7c0c62351"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b0cf2102-87cb-46e6-b5f0-84772c2e3d2b"), "Other" },
                    { new Guid("e288f01d-eccf-4849-b890-a9caaec1fabc"), "Chester" },
                    { new Guid("48aa377a-4e12-4681-ac0e-e6342e900251"), "Leeds" },
                    { new Guid("7f55eb72-b921-4d89-aa92-82be6fbf7970"), "Oldhan" },
                    { new Guid("b6ecfb57-8719-40da-9500-1f31425bdfad"), "Salfor" },
                    { new Guid("4c1bd626-9819-4eae-b146-0ef4fab04198"), "Manchester" },
                    { new Guid("4ed836bf-2f69-4124-8cfb-2348c2c1288e"), "Liverpool" },
                    { new Guid("9497f9c0-5dd7-4797-a206-e611a14f3631"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("b8e8b563-bee3-4aab-8d28-7f54ac6da481"), "01", "Behaviour and Emotional" },
                    { new Guid("d61e5028-0557-4295-a78c-ea8a9c2b52bb"), "02", "Hearing" },
                    { new Guid("aec6e5ba-01e8-451f-a09c-d46bb88283cc"), "03", "Manual Dexterity" },
                    { new Guid("ed9fed27-001e-492c-bfe9-1096fb8aff04"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("e497ed4b-b448-421c-89b3-91646fc4a703"), "XX", "Other" },
                    { new Guid("f367fb1c-7e3d-42cf-be59-9e63e9718a73"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("46a1ac8e-7e36-408a-a8c0-dbdcad9c85d3"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("d43b7774-dc0b-42f5-af26-42c676bbe853"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("9520472c-58ee-432b-a96e-6674c3e300d4"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("e318efee-0721-4af9-ba3a-c6f61bc169e5"), "B", "White - Irish", 20 },
                    { new Guid("affe8141-4e77-402a-b42b-aa7a87d22f92"), "C", "White - Any other White background", 23 },
                    { new Guid("3b360b98-ab87-431e-bd40-cba25a3572c0"), "A", "White -British", 15 },
                    { new Guid("9ef11ff6-5c1b-4eb1-bddb-e2aedb90cebb"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("9d4d699e-91a7-4027-b8fc-3b74b705c2b4"), "L", "None" },
                    { new Guid("2c23012d-3981-4158-a9ca-a311853066ca"), "K", "Other" },
                    { new Guid("0be04169-dc19-4c13-b007-e8efc5f17697"), "J", "Zoroastrian" },
                    { new Guid("54eee404-50d8-4141-8011-bede38ec48fe"), "I", "Sikh" },
                    { new Guid("bb56183e-23a8-432a-981b-c607b07eb34f"), "H", "Pagan" },
                    { new Guid("4d0baea6-a7f1-4b67-8eeb-424d1659a662"), "G", "Muslim" },
                    { new Guid("afc88582-2585-4686-b2d9-a8372d3fe503"), "F", "Jewish" },
                    { new Guid("60efb1bf-2649-4a9a-b7bb-48fecb642797"), "D", "Hindu" },
                    { new Guid("852df558-7659-4c11-bb99-06d00527adfb"), "C", "Christian" },
                    { new Guid("44017765-b880-49ea-b301-a21c2628a597"), "B", "Buddhist" },
                    { new Guid("5d06cce9-fcfa-406b-ab6c-5cd8204e965a"), "A", "Baha'i" },
                    { new Guid("3f7cb448-990e-44bc-8049-1d6333688d2c"), "M", "Declines to Disclose" },
                    { new Guid("cf50075e-5c1c-4cc1-ba19-43d8659fde0e"), "E", "Jain" },
                    { new Guid("d50eed39-04ad-4859-929b-ab3ef9b9d575"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
