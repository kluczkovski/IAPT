using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class AddTableReligiouGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c189574-221a-43a6-a5ba-37f965a56fde"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("222e8eec-4d83-4d38-9a5f-07f5787e1c8f"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ad7274a-f43f-4bd1-b395-6c9e40d5e860"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("9f56d433-da0d-4434-8f37-fdbb2e7ad978"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("cfc7ed35-4967-4d7e-992b-ae994d9f1dda"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("e804fd79-54d1-4a10-8835-65e43d67bed9"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1531aec-ebe6-4a1c-bfb3-b293b589d99c"));

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

            migrationBuilder.CreateIndex(
                name: "IX_ReligiousGroups_Code",
                table: "ReligiousGroups",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReligiousGroups");

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

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("9f56d433-da0d-4434-8f37-fdbb2e7ad978"), "A", "White -British", 15 },
                    { new Guid("cfc7ed35-4967-4d7e-992b-ae994d9f1dda"), "B", "White - Irish", 20 },
                    { new Guid("e804fd79-54d1-4a10-8835-65e43d67bed9"), "C", "White - Any other White background", 23 },
                    { new Guid("f1531aec-ebe6-4a1c-bfb3-b293b589d99c"), "D", "Mixed - White and Black Caribbean", 25 },
                    { new Guid("8ad7274a-f43f-4bd1-b395-6c9e40d5e860"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("0c189574-221a-43a6-a5ba-37f965a56fde"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("222e8eec-4d83-4d38-9a5f-07f5787e1c8f"), "G", "Mixed - Any mixed backgroundn", 40 }
                });
        }
    }
}
