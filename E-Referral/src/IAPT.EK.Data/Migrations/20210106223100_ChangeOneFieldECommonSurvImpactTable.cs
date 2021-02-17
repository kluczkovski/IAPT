using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class ChangeOneFieldECommonSurvImpactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("3fa5e29c-f71f-4f44-b717-829aa5fba2e8"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("4bf23608-2f42-470c-b55f-fc14e88cb323"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("5366780f-a36a-4767-b7eb-bdb6f813a135"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("f681d9e8-6b6a-41f4-87fe-551ac0ef3cf1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("030b0207-c79a-4722-a52b-95d6c54aed78"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c499a70-3111-472c-a24d-ea41d06f2d68"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4ecf19aa-9cfc-48fa-bc6f-78dfaabdb099"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f8be03a-a4ee-4952-8364-9d83a38b04e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5102c5d0-88f2-41b3-a63b-ce22549f6d69"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6f3d5515-d99e-4f52-9222-abf0eea33402"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("70aa335c-a610-49de-9398-77e4154a8eca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ea3e7090-e1ba-437c-812c-806afdb20295"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("24e38103-cbec-477c-8bd1-0948d7101dc3"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("32d14317-4bf1-4e90-babd-c3a3b7380cb8"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("7dc56695-0e88-448d-ab0e-b99d9eed8c26"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("7e9b6d2c-e59c-49d5-898b-0c738ebbf622"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("910999fc-54e7-40f0-b246-1bc57c40b368"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d1e77164-a459-46c5-8d5d-587823ad43eb"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d5561cb-8ed4-4935-b37d-f0d0fab20515"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c9fc4cc-7885-400d-a125-58aaf5d802ea"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("542bd9b7-d271-4012-bc05-e4ff636cb8be"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("6839b0bb-6a2a-4a23-be6f-fa1a8013d53e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("93d7fbf9-45ce-45d1-b44e-deec376eb29f"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e069cd1-b5a3-4b87-804c-7c2ae61aaa2c"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("c395e2ff-5663-4246-9b27-c0eaa52cedaa"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("0233aadb-55c3-420f-b3d0-ee7923a84b52"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("1d84ff37-2a98-4622-b75a-85b8ac036266"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3010ba47-2720-4931-9dc4-053eb217dc32"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("425b2089-5a84-4bfe-abcf-443b70ace405"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("57f085e9-a409-4dd8-88d6-c7fead481dcc"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("59f621d9-ab53-4a08-9d63-e973fc63c3c4"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("60690df1-205c-4b56-9374-2a9b8e8eb804"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("632971b6-80fe-48b2-96a7-92dc7959e988"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("966d9938-5008-49ad-b5bb-bd6bb8360220"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("981747c0-afc8-4074-ac63-a8c3e3e77e52"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9da349a3-3f9e-49b3-ab31-7b833a54c3d3"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("a396d536-8ee0-446e-8fbf-7e262351a429"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("b4c16ee9-4239-4084-81ea-189f7c131db1"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c42195e0-e3b6-4425-8ccb-b4476e79c876"));

            migrationBuilder.DropColumn(
                name: "ServedOrCurrentlyUnderInvestiagtion",
                table: "eCommonSurvivorImpacts");

            migrationBuilder.AddColumn<bool>(
                name: "ServedOrCurrentlyUnderInvestigation",
                table: "eCommonSurvivorImpacts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("fa4a6c6f-e133-40aa-9c7f-b0ff21da4c42"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("09749016-2b22-4561-b34f-04b3ff11ad43"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("020f19e8-1a8e-4b48-ae0d-ef5371b3dccd"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("737e33a8-b34f-4e4b-bb37-044d1d1f51ac"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4b0fb160-ccd3-4acc-8dd0-9b3391466d22"), "Other" },
                    { new Guid("15c91e11-fb1a-4e05-b77a-48595e69062a"), "Chester" },
                    { new Guid("6e455f23-a817-41e4-858d-3286d3a4f16a"), "Leeds" },
                    { new Guid("bd6faa0e-a0ac-4fdd-9d84-ba427abe33d0"), "Oldhan" },
                    { new Guid("258be96b-7e8d-4177-a0b9-feff6ea4f1e0"), "Salfor" },
                    { new Guid("f601187f-75c4-4e86-aa69-a4f2f3eaa5bc"), "Manchester" },
                    { new Guid("0d9a3810-fdb8-4ede-8db4-e6ef3e3f4dcf"), "Liverpool" },
                    { new Guid("a95f9c73-4923-491a-91a3-cfead369845a"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("a47ce8f0-3279-4191-b567-0c9ead311460"), "01", "Behaviour and Emotional" },
                    { new Guid("e3702e37-f1b2-4ab8-86ce-2d769340c885"), "02", "Hearing" },
                    { new Guid("3a8b9418-b940-4545-a027-277a140d7bcd"), "03", "Manual Dexterity" },
                    { new Guid("d2c6bd70-37a5-4345-9f6b-2f45209d05a8"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("1af119bf-29da-483e-b301-03c249e8b3af"), "XX", "Other" },
                    { new Guid("ad6ef5c6-7706-4431-a85c-2bc94f61ff68"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("ed41d6f4-dfe3-4fab-9ccd-ff085302f819"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("9ac55b20-fc0a-47aa-ae34-2b1bbf5d0afc"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("4ad047cb-1960-4b08-a68b-d4c68231176f"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("305d3e75-cbea-45a3-b6a1-12b12e9bc654"), "B", "White - Irish", 20 },
                    { new Guid("fb1a21db-2704-4c10-9dd9-be06678a6513"), "C", "White - Any other White background", 23 },
                    { new Guid("0c6c1a04-4ee5-4ed1-9c91-924d1934f737"), "A", "White -British", 15 },
                    { new Guid("baeb98f8-33a1-4ef8-9ea1-5b94cc5cf5e6"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("8d8836f2-5da7-4ea3-9d1a-d72080869aa5"), "L", "None" },
                    { new Guid("70479e49-d7b5-4e6a-a13f-4a7d1cde886c"), "K", "Other" },
                    { new Guid("e05b7239-c545-435a-b5fc-662cfa50d5d0"), "J", "Zoroastrian" },
                    { new Guid("445a999c-9360-4786-b0e3-79109ee46162"), "I", "Sikh" },
                    { new Guid("81b0fc2d-2f53-4a03-8b51-471408dab7cf"), "H", "Pagan" },
                    { new Guid("c87ea713-f4b0-45e7-96a6-1e801cb25f42"), "G", "Muslim" },
                    { new Guid("7d9627b3-5549-4eef-9d3a-9cc13608f472"), "F", "Jewish" },
                    { new Guid("870a4107-5cb5-4152-b444-2edcd9271cbe"), "D", "Hindu" },
                    { new Guid("b51126a6-a2d8-4397-9eb3-b18d15b75594"), "C", "Christian" },
                    { new Guid("b12d905d-9f36-42aa-a1fe-d8deb61f2def"), "B", "Buddhist" },
                    { new Guid("45c7ef0d-8cbc-4a19-84f9-93077d49814a"), "A", "Baha'i" },
                    { new Guid("07429971-268b-47ac-9bde-a0a366ade746"), "M", "Declines to Disclose" },
                    { new Guid("f3224334-5bcd-4417-98a0-269abcdc36b3"), "E", "Jain" },
                    { new Guid("19b2788c-60f8-45a0-8c26-ce8f0f3fa980"), "N", "Patient Religion Unknown" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("020f19e8-1a8e-4b48-ae0d-ef5371b3dccd"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("09749016-2b22-4561-b34f-04b3ff11ad43"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("737e33a8-b34f-4e4b-bb37-044d1d1f51ac"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("fa4a6c6f-e133-40aa-9c7f-b0ff21da4c42"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0d9a3810-fdb8-4ede-8db4-e6ef3e3f4dcf"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("15c91e11-fb1a-4e05-b77a-48595e69062a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("258be96b-7e8d-4177-a0b9-feff6ea4f1e0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4b0fb160-ccd3-4acc-8dd0-9b3391466d22"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6e455f23-a817-41e4-858d-3286d3a4f16a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a95f9c73-4923-491a-91a3-cfead369845a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bd6faa0e-a0ac-4fdd-9d84-ba427abe33d0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f601187f-75c4-4e86-aa69-a4f2f3eaa5bc"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("1af119bf-29da-483e-b301-03c249e8b3af"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("3a8b9418-b940-4545-a027-277a140d7bcd"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("a47ce8f0-3279-4191-b567-0c9ead311460"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("ad6ef5c6-7706-4431-a85c-2bc94f61ff68"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d2c6bd70-37a5-4345-9f6b-2f45209d05a8"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("e3702e37-f1b2-4ab8-86ce-2d769340c885"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c6c1a04-4ee5-4ed1-9c91-924d1934f737"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("305d3e75-cbea-45a3-b6a1-12b12e9bc654"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("4ad047cb-1960-4b08-a68b-d4c68231176f"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ac55b20-fc0a-47aa-ae34-2b1bbf5d0afc"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("baeb98f8-33a1-4ef8-9ea1-5b94cc5cf5e6"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed41d6f4-dfe3-4fab-9ccd-ff085302f819"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb1a21db-2704-4c10-9dd9-be06678a6513"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("07429971-268b-47ac-9bde-a0a366ade746"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("19b2788c-60f8-45a0-8c26-ce8f0f3fa980"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("445a999c-9360-4786-b0e3-79109ee46162"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("45c7ef0d-8cbc-4a19-84f9-93077d49814a"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("70479e49-d7b5-4e6a-a13f-4a7d1cde886c"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("7d9627b3-5549-4eef-9d3a-9cc13608f472"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("81b0fc2d-2f53-4a03-8b51-471408dab7cf"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("870a4107-5cb5-4152-b444-2edcd9271cbe"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("8d8836f2-5da7-4ea3-9d1a-d72080869aa5"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("b12d905d-9f36-42aa-a1fe-d8deb61f2def"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("b51126a6-a2d8-4397-9eb3-b18d15b75594"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c87ea713-f4b0-45e7-96a6-1e801cb25f42"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("e05b7239-c545-435a-b5fc-662cfa50d5d0"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("f3224334-5bcd-4417-98a0-269abcdc36b3"));

            migrationBuilder.DropColumn(
                name: "ServedOrCurrentlyUnderInvestigation",
                table: "eCommonSurvivorImpacts");

            migrationBuilder.AddColumn<bool>(
                name: "ServedOrCurrentlyUnderInvestiagtion",
                table: "eCommonSurvivorImpacts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("f681d9e8-6b6a-41f4-87fe-551ac0ef3cf1"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("3fa5e29c-f71f-4f44-b717-829aa5fba2e8"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("4bf23608-2f42-470c-b55f-fc14e88cb323"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("5366780f-a36a-4767-b7eb-bdb6f813a135"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ecf19aa-9cfc-48fa-bc6f-78dfaabdb099"), "Other" },
                    { new Guid("70aa335c-a610-49de-9398-77e4154a8eca"), "Chester" },
                    { new Guid("4f8be03a-a4ee-4952-8364-9d83a38b04e2"), "Leeds" },
                    { new Guid("030b0207-c79a-4722-a52b-95d6c54aed78"), "Oldhan" },
                    { new Guid("5102c5d0-88f2-41b3-a63b-ce22549f6d69"), "Salfor" },
                    { new Guid("1c499a70-3111-472c-a24d-ea41d06f2d68"), "Manchester" },
                    { new Guid("ea3e7090-e1ba-437c-812c-806afdb20295"), "Liverpool" },
                    { new Guid("6f3d5515-d99e-4f52-9222-abf0eea33402"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("7e9b6d2c-e59c-49d5-898b-0c738ebbf622"), "01", "Behaviour and Emotional" },
                    { new Guid("d1e77164-a459-46c5-8d5d-587823ad43eb"), "02", "Hearing" },
                    { new Guid("7dc56695-0e88-448d-ab0e-b99d9eed8c26"), "03", "Manual Dexterity" },
                    { new Guid("910999fc-54e7-40f0-b246-1bc57c40b368"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("24e38103-cbec-477c-8bd1-0948d7101dc3"), "XX", "Other" },
                    { new Guid("32d14317-4bf1-4e90-babd-c3a3b7380cb8"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("c395e2ff-5663-4246-9b27-c0eaa52cedaa"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("93d7fbf9-45ce-45d1-b44e-deec376eb29f"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("6839b0bb-6a2a-4a23-be6f-fa1a8013d53e"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("2c9fc4cc-7885-400d-a125-58aaf5d802ea"), "B", "White - Irish", 20 },
                    { new Guid("9e069cd1-b5a3-4b87-804c-7c2ae61aaa2c"), "C", "White - Any other White background", 23 },
                    { new Guid("542bd9b7-d271-4012-bc05-e4ff636cb8be"), "A", "White -British", 15 },
                    { new Guid("0d5561cb-8ed4-4935-b37d-f0d0fab20515"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("981747c0-afc8-4074-ac63-a8c3e3e77e52"), "L", "None" },
                    { new Guid("966d9938-5008-49ad-b5bb-bd6bb8360220"), "K", "Other" },
                    { new Guid("60690df1-205c-4b56-9374-2a9b8e8eb804"), "J", "Zoroastrian" },
                    { new Guid("c42195e0-e3b6-4425-8ccb-b4476e79c876"), "I", "Sikh" },
                    { new Guid("9da349a3-3f9e-49b3-ab31-7b833a54c3d3"), "H", "Pagan" },
                    { new Guid("b4c16ee9-4239-4084-81ea-189f7c131db1"), "G", "Muslim" },
                    { new Guid("3010ba47-2720-4931-9dc4-053eb217dc32"), "F", "Jewish" },
                    { new Guid("57f085e9-a409-4dd8-88d6-c7fead481dcc"), "D", "Hindu" },
                    { new Guid("a396d536-8ee0-446e-8fbf-7e262351a429"), "C", "Christian" },
                    { new Guid("1d84ff37-2a98-4622-b75a-85b8ac036266"), "B", "Buddhist" },
                    { new Guid("425b2089-5a84-4bfe-abcf-443b70ace405"), "A", "Baha'i" },
                    { new Guid("59f621d9-ab53-4a08-9d63-e973fc63c3c4"), "M", "Declines to Disclose" },
                    { new Guid("0233aadb-55c3-420f-b3d0-ee7923a84b52"), "E", "Jain" },
                    { new Guid("632971b6-80fe-48b2-96a7-92dc7959e988"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
