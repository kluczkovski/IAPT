using Microsoft.EntityFrameworkCore.Migrations;

namespace Referral.EK.Data.Migrations
{
    public partial class UniqueIndexEthnicCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EthnicCategories_Code",
                table: "EthnicCategories",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EthnicCategories_Code",
                table: "EthnicCategories");
        }
    }
}
