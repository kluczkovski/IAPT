using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class AddRiskIndicatorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_eRiskIndicators_EReferralId",
                table: "eRiskIndicators",
                column: "EReferralId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eRiskIndicators");

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
        }
    }
}
