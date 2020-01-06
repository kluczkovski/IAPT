using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class AddDisabilityCodeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("49cf3c43-4bb2-4d94-ae0e-8a554fc70454"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("4dae1747-8ef1-4f10-8a58-4b1e062dd749"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("76187bb7-ac6a-4c6f-bb15-929c2a2ce280"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("a39e6624-a8a8-4191-a70d-9dab50be7ccb"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("a6b0cb23-d701-4f1e-9ae1-11910bc85d49"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("aaa441fd-95e1-48c6-9c4c-d37f2f1927b8"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0fb42f7-c42e-48bd-9ebd-5a5da39aa99a"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2bfb242c-be83-4a86-aa2d-28eadc916014"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5757f73a-116f-4e3f-8f19-3d705a642c7d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5d6bb69b-8f9b-483c-bb9d-a178b47bbf5a"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9a29d627-55b2-4e1c-abf1-4b1e2cc4c253"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("b30a5743-6971-4e62-9c77-95a9dfbd9d2f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c26ff8c3-4517-4921-a3f4-bd9b9eb446a4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c9202de2-e1da-4aed-862a-7ed43e09587f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("cae8ba41-637a-4e67-817f-aa4dfa041b3a"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d09f6805-ae10-4184-865e-85f56ec2e4d6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d53772b3-4828-4f40-b47e-7b2cf2025613"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("da654ef1-4476-4565-92bb-fdc7ed9d7e85"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("dd62f777-329e-46e4-b5fc-72d42ebb2313"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("e3f5aa51-4687-4633-a20a-417e49cebe6f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("f46e262f-ece4-4f7b-a703-56eab98b33fd"));

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

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("fa56b2a8-5ef2-4caa-b7e6-f50ca8cae2e9"), "01", "Behaviour and Emotional" },
                    { new Guid("cdcf851a-2800-43af-9410-ac54f98d8b21"), "02", "Hearing" },
                    { new Guid("22e17f4d-4c62-461a-81b7-d3f1950bff25"), "03", "Manual Dexterity" },
                    { new Guid("3c571839-ddc2-461d-ae15-bb1da1839972"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("120e9c07-3dba-4b4a-8d13-cd26ce7e5add"), "XX", "Other" },
                    { new Guid("513885d6-2a62-41b5-b2e0-9972ca6fa93f"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("228ad55e-1791-4a77-90da-f1d8769ae18b"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("8b288331-019e-427e-8a05-26dcfbe95fb8"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("e2e9c54d-d8b2-4f00-9db6-ba5f13dfd4af"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("7f88298f-8ec7-456d-b90b-2aa441c2da67"), "D", "Mixed - White and Black Caribbean", 25 },
                    { new Guid("ecc71318-1a0c-499c-9541-931974cfb296"), "C", "White - Any other White background", 23 },
                    { new Guid("a1d1631c-0fc9-4264-8d63-5717227c014f"), "B", "White - Irish", 20 },
                    { new Guid("8c0e1f18-6ed9-4163-9d3c-f8b34c784745"), "A", "White -British", 15 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("6b0b2da6-5462-43c7-8845-29284b18fd5f"), "L", "None" },
                    { new Guid("946b8da0-d027-408f-980d-82d8598a3426"), "K", "Other" },
                    { new Guid("6b6eb6a9-428e-4ecb-bfd3-1a000e241413"), "J", "Zoroastrian" },
                    { new Guid("de18ac3f-ee3f-4688-a2da-a70b6500c554"), "I", "Sikh" },
                    { new Guid("1a4a992b-9d93-4ef6-9874-b6f0c9cc73e6"), "H", "Pagan" },
                    { new Guid("a00324b1-73c8-4cb9-a1df-3a1b5516926c"), "G", "Muslim" },
                    { new Guid("03b844d7-3c86-4a80-8dfe-549c685b5090"), "A", "Baha'i" },
                    { new Guid("70eff45b-6bf3-4858-bf39-e368e75af1ce"), "E", "Jain" },
                    { new Guid("c4ecdef8-5066-4320-8f96-df03309c8798"), "D", "Hindu" },
                    { new Guid("40aca05f-669f-4be8-bfcb-5c5636a347b6"), "C", "Christian" },
                    { new Guid("a4ad8a89-e3d9-4717-a1a2-e29a59e3a873"), "B", "Buddhist" },
                    { new Guid("b34a1dd3-ae8a-4561-a250-0dac8f5f19db"), "M", "Declines to Disclose" },
                    { new Guid("9908d908-ec4f-4331-a3f7-1e68f4b96f7b"), "F", "Jewish" },
                    { new Guid("828cfccd-813e-4432-90e9-9ced65ffd4be"), "N", "Patient Religion Unknown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DisabilityCodes_Code",
                table: "DisabilityCodes",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisabilityCodes");

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("228ad55e-1791-4a77-90da-f1d8769ae18b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("7f88298f-8ec7-456d-b90b-2aa441c2da67"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b288331-019e-427e-8a05-26dcfbe95fb8"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c0e1f18-6ed9-4163-9d3c-f8b34c784745"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("a1d1631c-0fc9-4264-8d63-5717227c014f"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2e9c54d-d8b2-4f00-9db6-ba5f13dfd4af"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ecc71318-1a0c-499c-9541-931974cfb296"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("03b844d7-3c86-4a80-8dfe-549c685b5090"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("1a4a992b-9d93-4ef6-9874-b6f0c9cc73e6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("40aca05f-669f-4be8-bfcb-5c5636a347b6"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6b0b2da6-5462-43c7-8845-29284b18fd5f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6b6eb6a9-428e-4ecb-bfd3-1a000e241413"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("70eff45b-6bf3-4858-bf39-e368e75af1ce"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("828cfccd-813e-4432-90e9-9ced65ffd4be"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("946b8da0-d027-408f-980d-82d8598a3426"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9908d908-ec4f-4331-a3f7-1e68f4b96f7b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a00324b1-73c8-4cb9-a1df-3a1b5516926c"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a4ad8a89-e3d9-4717-a1a2-e29a59e3a873"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("b34a1dd3-ae8a-4561-a250-0dac8f5f19db"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c4ecdef8-5066-4320-8f96-df03309c8798"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("de18ac3f-ee3f-4688-a2da-a70b6500c554"));

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("a6b0cb23-d701-4f1e-9ae1-11910bc85d49"), "A", "White -British", 15 },
                    { new Guid("49cf3c43-4bb2-4d94-ae0e-8a554fc70454"), "B", "White - Irish", 20 },
                    { new Guid("76187bb7-ac6a-4c6f-bb15-929c2a2ce280"), "C", "White - Any other White background", 23 },
                    { new Guid("4dae1747-8ef1-4f10-8a58-4b1e062dd749"), "D", "Mixed - White and Black Caribbean", 25 },
                    { new Guid("a39e6624-a8a8-4191-a70d-9dab50be7ccb"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("aaa441fd-95e1-48c6-9c4c-d37f2f1927b8"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("f0fb42f7-c42e-48bd-9ebd-5a5da39aa99a"), "G", "Mixed - Any mixed backgroundn", 40 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("da654ef1-4476-4565-92bb-fdc7ed9d7e85"), "L", "None" },
                    { new Guid("dd62f777-329e-46e4-b5fc-72d42ebb2313"), "K", "Other" },
                    { new Guid("5757f73a-116f-4e3f-8f19-3d705a642c7d"), "J", "Zoroastrian" },
                    { new Guid("d53772b3-4828-4f40-b47e-7b2cf2025613"), "I", "Sikh" },
                    { new Guid("cae8ba41-637a-4e67-817f-aa4dfa041b3a"), "H", "Pagan" },
                    { new Guid("c26ff8c3-4517-4921-a3f4-bd9b9eb446a4"), "G", "Muslim" },
                    { new Guid("e3f5aa51-4687-4633-a20a-417e49cebe6f"), "D", "Hindu" },
                    { new Guid("b30a5743-6971-4e62-9c77-95a9dfbd9d2f"), "E", "Jain" },
                    { new Guid("9a29d627-55b2-4e1c-abf1-4b1e2cc4c253"), "M", "Declines to Disclose" },
                    { new Guid("f46e262f-ece4-4f7b-a703-56eab98b33fd"), "C", "Christian" },
                    { new Guid("5d6bb69b-8f9b-483c-bb9d-a178b47bbf5a"), "B", "Buddhist" },
                    { new Guid("c9202de2-e1da-4aed-862a-7ed43e09587f"), "A", "Baha'i" },
                    { new Guid("d09f6805-ae10-4184-865e-85f56ec2e4d6"), "F", "Jewish" },
                    { new Guid("2bfb242c-be83-4a86-aa2d-28eadc916014"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
