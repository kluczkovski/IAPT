using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class Initial : Migration
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

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("2f0b7875-2e33-4a97-8c26-e95f688665c3"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("48f89668-5737-41f8-9f6d-069d46dfda6e"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("580f2341-73ba-4f9c-983d-5221d9879988"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("6036945e-1dc8-44ec-8166-f47c3d0b1981"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7d4ca7a2-39d2-45de-8a54-3d11ac658857"), "Oldhan" },
                    { new Guid("c5f5d536-acd3-462c-8334-21de09bd860d"), "Leeds" },
                    { new Guid("faca3ac0-63bf-4dbf-8a17-f83b19121b63"), "York" },
                    { new Guid("355494cf-15ae-4d5b-984c-4e420c14393c"), "Chester" },
                    { new Guid("c5962c8f-d67f-4392-98d9-f1fe036a0c69"), "Manchester" },
                    { new Guid("aeee164a-ca31-4261-b6e6-fcae67e4bda4"), "Liverpool" },
                    { new Guid("68a4401c-e24d-4904-b0df-fbde6e1b23cd"), "Salfor" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("f3bde453-fe53-4d9f-9ef6-f0b4e81b6517"), "01", "Behaviour and Emotional" },
                    { new Guid("0ee5ffaf-8e64-446f-96a1-7b44f2c73824"), "02", "Hearing" },
                    { new Guid("65ae4755-4fe8-49e7-b992-bb64e250957b"), "03", "Manual Dexterity" },
                    { new Guid("e3c89e35-d2b0-46a8-a1f8-f9e586a4939b"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("f3236ea3-3af1-4514-9a1a-e6d4d9d7eb5a"), "XX", "Other" },
                    { new Guid("1977f8e9-011c-4507-abdb-abc7cc43b394"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("902123b2-208b-483c-a0da-f46727b37481"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("78419d54-a03c-4411-85b9-bb52031679a3"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("310514a7-2991-4bf2-b299-d7dc9aefaca3"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("4203fc7d-93f3-48ec-8e7b-5c3b417d64c6"), "B", "White - Irish", 20 },
                    { new Guid("57e5e71b-164f-4da8-9b7d-8f9d5411c7e6"), "C", "White - Any other White background", 23 },
                    { new Guid("fdd42e43-0a16-4ea1-bf1d-01183a3083e7"), "A", "White -British", 15 },
                    { new Guid("03e1616c-5347-4ec6-aa5e-4f6813c73379"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("fb995a54-6918-49e4-b09e-6612db39bf39"), "L", "None" },
                    { new Guid("d62048ac-3c9b-4557-89d9-34cb150e2c9a"), "K", "Other" },
                    { new Guid("144d1b00-7c78-450c-b8ab-fa341d1fc45c"), "J", "Zoroastrian" },
                    { new Guid("78658167-fe62-472d-a680-c7553d26f35b"), "I", "Sikh" },
                    { new Guid("d6abf2d5-d0aa-42c4-8114-c1e0d8284c21"), "H", "Pagan" },
                    { new Guid("000c3f56-11ae-4995-8863-9ed340cb9da0"), "G", "Muslim" },
                    { new Guid("f9e5296d-3f75-48fc-8084-6fe3ebc44003"), "F", "Jewish" },
                    { new Guid("b24561e9-55a0-42aa-ad8e-e199b3cd4570"), "D", "Hindu" },
                    { new Guid("6bfa9978-0a8d-4854-a5aa-0906e2c0fd5a"), "C", "Christian" },
                    { new Guid("88c955ea-3109-41fc-85e7-b586d196a356"), "B", "Buddhist" },
                    { new Guid("52bc6ba0-5b8d-41f3-9dda-7650ffd6f6a4"), "A", "Baha'i" },
                    { new Guid("ef4aed92-36f3-40b5-8950-8c5bd47e1736"), "M", "Declines to Disclose" },
                    { new Guid("d5429163-11e9-463b-a202-b852ffb91e20"), "E", "Jain" },
                    { new Guid("ad4f91d6-b6d8-41f4-8bea-35889feb9fe2"), "N", "Patient Religion Unknown" }
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
                name: "Cities");

            migrationBuilder.DropTable(
                name: "DisabilityCodes");

            migrationBuilder.DropTable(
                name: "EthnicCategories");

            migrationBuilder.DropTable(
                name: "GPPractices");

            migrationBuilder.DropTable(
                name: "ReligiousGroups");

            migrationBuilder.DropTable(
                name: "CCGCodes");
        }
    }
}
