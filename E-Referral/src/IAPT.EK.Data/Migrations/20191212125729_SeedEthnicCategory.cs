using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class SeedEthnicCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("7ea1d51a-72d2-4c45-97de-53b1beae521b"), "A", "White -British", 15 },
                    { new Guid("ec7a97ce-60e8-4b16-b752-1cb9d59afccf"), "B", "White - Irish", 20 },
                    { new Guid("625759f1-ae0a-4966-973b-c7043ac76b0e"), "C", "White - Any other White background", 20 },
                    { new Guid("3b680f60-05a0-4bb8-86df-f425155397a8"), "D", "Mixed - White and Black Caribbean", 25 },
                    { new Guid("cf9ecb8c-138a-4b4c-9468-30a12d2288b5"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("4b8a6380-aa49-41e9-aee4-e7aa86e871c7"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("94cbb65a-90ab-47d1-b771-1ecd4876e57c"), "G", "Mixed - Any mixed backgroundn", 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b680f60-05a0-4bb8-86df-f425155397a8"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b8a6380-aa49-41e9-aee4-e7aa86e871c7"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("625759f1-ae0a-4966-973b-c7043ac76b0e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ea1d51a-72d2-4c45-97de-53b1beae521b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("94cbb65a-90ab-47d1-b771-1ecd4876e57c"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf9ecb8c-138a-4b4c-9468-30a12d2288b5"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec7a97ce-60e8-4b16-b752-1cb9d59afccf"));
        }
    }
}
