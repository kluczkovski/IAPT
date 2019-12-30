using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class AddTableCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("120e9c07-3dba-4b4a-8d13-cd26ce7e5add"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("22e17f4d-4c62-461a-81b7-d3f1950bff25"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("3c571839-ddc2-461d-ae15-bb1da1839972"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("513885d6-2a62-41b5-b2e0-9972ca6fa93f"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("cdcf851a-2800-43af-9410-ac54f98d8b21"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("fa56b2a8-5ef2-4caa-b7e6-f50ca8cae2e9"));

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("282b0878-b892-458d-947e-65e356d3b7ea"), "Liverpool" },
                    { new Guid("0c75be76-9583-44c7-a3b0-ee0314f5753b"), "Manchester" },
                    { new Guid("c66c8f74-0edb-4130-a6e1-8282dc74acd1"), "Salfor" },
                    { new Guid("ba0f970f-ee03-4893-aa32-4f40ff24bda9"), "York" },
                    { new Guid("6787c018-e458-42da-a450-d428fdffa382"), "Leeds" },
                    { new Guid("1013f7d6-974e-4590-85ea-ad474a196fc7"), "Chester" },
                    { new Guid("a0a0361f-9b40-4f64-8d2c-ea1c59c42245"), "Oldhan" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCode",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("f28fa5e8-a351-480b-8edb-422165da0d9a"), "01", "Behaviour and Emotional" },
                    { new Guid("201cf3ea-0bf2-46d2-aa30-bea138a3a749"), "02", "Hearing" },
                    { new Guid("02a1e4f1-159e-4067-b0e8-e49cd5fff424"), "03", "Manual Dexterity" },
                    { new Guid("7eaff7c7-ddba-489c-8953-104380c33beb"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("13a1e748-e2a8-4799-ba80-94f80cccbbd1"), "XX", "Other" },
                    { new Guid("4c2390d1-10ad-405e-a36f-6e3103420a44"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("637815df-7a25-457e-9ed8-62080f086282"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("e1a4677d-e62c-41cb-820e-a1f92ab9f7bc"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("8aa9466d-fdfa-4815-80c5-c70b789a268e"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("ac744792-f52a-41f6-8483-0733082e695e"), "D", "Mixed - White and Black Caribbean", 25 },
                    { new Guid("b3d92fdc-2c06-4d5f-8b3b-5b7a7f53542a"), "C", "White - Any other White background", 23 },
                    { new Guid("0deff82b-6a26-4236-bcb1-b3f7d66a6f00"), "B", "White - Irish", 20 },
                    { new Guid("b33ec21f-8036-40d6-b1e3-0a5ac22753a6"), "A", "White -British", 15 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("7d05cc09-35f1-4e58-b05f-299bb6d5ef59"), "L", "None" },
                    { new Guid("969f6b99-cb0b-4cbb-bd2e-ad599db9f2ba"), "K", "Other" },
                    { new Guid("812a9fe0-8458-45e7-b06d-ba08f27af27d"), "J", "Zoroastrian" },
                    { new Guid("173df8ae-43dd-45e5-805d-28a4e6bff187"), "I", "Sikh" },
                    { new Guid("4b5811e7-07dc-4643-a91b-4b1dddc57779"), "H", "Pagan" },
                    { new Guid("8d328a75-d93a-404a-a400-dc149fddf591"), "G", "Muslim" },
                    { new Guid("9d48df5b-859d-4507-a880-b16e4303598e"), "F", "Jewish" },
                    { new Guid("9a482916-07c0-4917-b55b-03252c400918"), "E", "Jain" },
                    { new Guid("48b99c82-8b07-4593-930f-64b6b746ccb4"), "D", "Hindu" },
                    { new Guid("6a20ccf0-f710-49ac-baff-7712e24411c7"), "C", "Christian" },
                    { new Guid("11008e66-5aac-4f52-b24a-00360ee0bb56"), "B", "Buddhist" },
                    { new Guid("36be50e4-4b2f-428d-837a-77afa360a7e8"), "A", "Baha'i" },
                    { new Guid("11ac2916-07ea-406b-bd74-9ee4b9b4b0bb"), "M", "Declines to Disclose" },
                    { new Guid("f1de199d-044e-443b-91e6-704e65580fdc"), "N", "Patient Religion Unknown" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("02a1e4f1-159e-4067-b0e8-e49cd5fff424"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("13a1e748-e2a8-4799-ba80-94f80cccbbd1"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("201cf3ea-0bf2-46d2-aa30-bea138a3a749"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("4c2390d1-10ad-405e-a36f-6e3103420a44"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("7eaff7c7-ddba-489c-8953-104380c33beb"));

            migrationBuilder.DeleteData(
                table: "DisabilityCode",
                keyColumn: "Id",
                keyValue: new Guid("f28fa5e8-a351-480b-8edb-422165da0d9a"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("0deff82b-6a26-4236-bcb1-b3f7d66a6f00"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("637815df-7a25-457e-9ed8-62080f086282"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8aa9466d-fdfa-4815-80c5-c70b789a268e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac744792-f52a-41f6-8483-0733082e695e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("b33ec21f-8036-40d6-b1e3-0a5ac22753a6"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3d92fdc-2c06-4d5f-8b3b-5b7a7f53542a"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1a4677d-e62c-41cb-820e-a1f92ab9f7bc"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("11008e66-5aac-4f52-b24a-00360ee0bb56"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("11ac2916-07ea-406b-bd74-9ee4b9b4b0bb"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("173df8ae-43dd-45e5-805d-28a4e6bff187"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("36be50e4-4b2f-428d-837a-77afa360a7e8"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("48b99c82-8b07-4593-930f-64b6b746ccb4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b5811e7-07dc-4643-a91b-4b1dddc57779"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6a20ccf0-f710-49ac-baff-7712e24411c7"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("7d05cc09-35f1-4e58-b05f-299bb6d5ef59"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("812a9fe0-8458-45e7-b06d-ba08f27af27d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("8d328a75-d93a-404a-a400-dc149fddf591"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("969f6b99-cb0b-4cbb-bd2e-ad599db9f2ba"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9a482916-07c0-4917-b55b-03252c400918"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9d48df5b-859d-4507-a880-b16e4303598e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1de199d-044e-443b-91e6-704e65580fdc"));

            migrationBuilder.InsertData(
                table: "DisabilityCode",
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
        }
    }
}
