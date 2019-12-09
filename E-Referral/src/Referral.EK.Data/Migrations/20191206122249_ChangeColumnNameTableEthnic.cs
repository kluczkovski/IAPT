using Microsoft.EntityFrameworkCore.Migrations;

namespace Referral.EK.Data.Migrations
{
    public partial class ChangeColumnNameTableEthnic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "int(5)",
                table: "EthnicCategories",
                newName: "Sequence");

            migrationBuilder.RenameColumn(
                name: "varchar(100)",
                table: "EthnicCategories",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "Sequence",
                table: "EthnicCategories",
                type: "int(5)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "EthnicCategories",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sequence",
                table: "EthnicCategories",
                newName: "int(5)");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "EthnicCategories",
                newName: "varchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "int(5)",
                table: "EthnicCategories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(5)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(100)",
                table: "EthnicCategories",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}
