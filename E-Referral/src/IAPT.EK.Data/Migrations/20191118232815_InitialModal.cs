using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class InitialModal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EthnicCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(5)", nullable: false),
                    varchar100 = table.Column<string>(name: "varchar(100)", nullable: false),
                    int5 = table.Column<int>(name: "int(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EthnicCategories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EthnicCategories");
        }
    }
}
