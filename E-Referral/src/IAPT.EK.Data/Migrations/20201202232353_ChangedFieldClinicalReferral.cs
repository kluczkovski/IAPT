using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAPT.EK.Data.Migrations
{
    public partial class ChangedFieldClinicalReferral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("0027dfe1-68de-4f10-a18d-272ca006c7a8"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("1ce773c9-8582-4636-9310-7143ff48a77e"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("a02f4d0f-a526-4933-8734-ea9456875bd5"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("fd1ffb7d-04c4-45bd-8727-701c65fc4878"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0707a8d4-7e0c-43e9-983a-a2a739b310e5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b0bd0f6-44f7-4ace-8ff5-c4e549e6d835"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3f19bd16-ccfe-46f1-85cc-f2879ee7d6b5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("44f3954e-c021-49f4-9c7f-c06d74eebc96"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a0c8857e-f9ee-47bc-8cdf-9570abdf278c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c1034983-d1e3-4b91-8098-656bb05eeeeb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c24af278-951d-4ad5-98b7-ccfab5734804"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e79201b8-0a2c-42fd-8c96-855484bf222d"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("58ca681e-f8fd-4583-9286-5a84c9ed0ab2"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("5fbb4513-d5b1-46ca-89d7-8d022e36540a"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("9a7a666a-e44a-4011-a03b-a8b34944c4a0"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("c3ee6e4d-86bd-4360-8c3b-ba4bcfb4f474"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("f0a3185c-9c3a-4bbd-a5ae-1bcf6031fde1"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("f0a79ac6-547f-4aa2-b1c9-41465ea647c2"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("24714fd3-8e12-4a5d-825d-0d8a5e2a252b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("41bdcc76-6f34-48f7-a29f-2e6dc5e78480"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("43c98f07-e1a8-4a1d-bde3-864f17f7928b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ed5c2dd-d3c9-4d54-8556-0c1d72d157e5"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8579c981-81e4-4b38-b01d-c2b81b043c8b"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e5186d0-4f34-427b-bb5d-c4a978f2bd92"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc917565-2789-4f6f-aead-20672c53d034"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("3d4a1395-06d1-4f1c-8f24-7c5737a7fd6d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("43e988e6-c0e5-420c-b66a-40d4d163370b"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("49edd8ef-633c-450f-b798-cb6a4609ab97"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("560aac9e-2275-4999-91ab-28e12e299c90"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("601a4682-364d-42b4-a023-46eb5a98d731"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("69f45d82-ee82-43fd-9016-81da1196ef87"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("73fa427f-343c-4452-9bbb-11cbafce7d32"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("85c4ef45-ef3b-419c-8210-a1ae3ee0e3ff"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("936edc6e-0ee3-44f4-b1fe-ecdf0a387ab2"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("9c34b890-077d-447d-89fd-af56523b8422"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("abc68998-3f3b-43e2-91e5-34ab8e8e946d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c36d074a-8643-4e39-9b68-defb63124314"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c8e54787-abee-4544-9864-c4c4e664e92d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("df7cfdc5-9731-466d-b02e-6b9b4790900b"));

            migrationBuilder.DropColumn(
                name: "StateMentalHealth",
                table: "eClinicalReferralInfos");

            migrationBuilder.AddColumn<string>(
                name: "StatedMentalHealth",
                table: "eClinicalReferralInfos",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("46ef74c1-1310-4e27-9c58-179b26e61746"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("09b4d894-b93d-4282-b279-2a389562038f"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("65bcdff9-9f36-4df7-a397-66121bc7baa5"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("687a322f-930d-4089-b026-f869b18a6101"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7c4bc1bc-4a26-4e31-bdbf-40a96bfd698d"), "Other" },
                    { new Guid("ae8da41a-9e42-4bd3-8a47-5271793f660b"), "Chester" },
                    { new Guid("095cf8f7-817d-42f8-8903-008a83d77f38"), "Leeds" },
                    { new Guid("847ebf67-15a4-4559-8e53-a988625e00b1"), "Oldhan" },
                    { new Guid("b956978e-7ed6-4014-9826-f3ec643df9d9"), "Salfor" },
                    { new Guid("5162f63e-343b-49c8-afd0-792521d30053"), "Manchester" },
                    { new Guid("36c6450c-fe47-40a3-8f52-f8a1f04c0e1b"), "Liverpool" },
                    { new Guid("160d0c2e-ab94-4ecc-957b-aa59d0fe3620"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("3a5c0c94-6ba4-4432-8faa-9baed076118d"), "01", "Behaviour and Emotional" },
                    { new Guid("6635d738-968f-4577-b21f-c273d8eb2803"), "02", "Hearing" },
                    { new Guid("dfdd0ba3-4218-42cc-8b96-f3449a607c85"), "03", "Manual Dexterity" },
                    { new Guid("92f20e72-de92-4533-ae16-80c6a082862c"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("aef1af58-c659-4009-9e36-1e452411357a"), "XX", "Other" },
                    { new Guid("d4b9374e-8de5-4726-929e-095b70dc2492"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("1902a81d-7938-4565-ad19-e5675285224a"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("ef6113cc-f060-49df-b0f0-263a6cfffa5e"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("fdf08ae6-c4f6-4414-a3ba-76785f99fcde"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("1bd330a8-cbed-454d-bcb5-277a63852d1c"), "B", "White - Irish", 20 },
                    { new Guid("2faf37d0-a2b0-4850-b262-e83b93f4798e"), "C", "White - Any other White background", 23 },
                    { new Guid("59f1a64c-1fd9-48db-b816-a41cf41d619e"), "A", "White -British", 15 },
                    { new Guid("da6975a1-d237-46c0-9684-c78a3a335696"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("c8187057-b5fc-477a-8c7a-68c1315351fd"), "L", "None" },
                    { new Guid("5b917900-256e-4664-8974-f3cb2d223e22"), "K", "Other" },
                    { new Guid("2cacc3d0-3890-441f-b0ff-464d793b81e3"), "J", "Zoroastrian" },
                    { new Guid("d49db039-0943-435f-bc11-81e4669833d9"), "I", "Sikh" },
                    { new Guid("d2beb8bc-1d52-4f73-a491-13467302de8f"), "H", "Pagan" },
                    { new Guid("2d7f3dd6-41d8-401f-8c8d-7455a97f321e"), "G", "Muslim" },
                    { new Guid("6062fb4b-2f56-413b-927a-01737fd0cb4e"), "F", "Jewish" },
                    { new Guid("e7a0c98e-b39b-4c9b-95d2-8b8c94c3eabe"), "D", "Hindu" },
                    { new Guid("33993eea-8964-4bc6-a9e3-53209a2db608"), "C", "Christian" },
                    { new Guid("11fc9d27-4d84-4f2d-8600-3c1222ff7320"), "B", "Buddhist" },
                    { new Guid("71acf09b-8148-442e-8e60-aa006f4d50a2"), "A", "Baha'i" },
                    { new Guid("dc0067f6-a3f2-4b98-9feb-f8a94922bf7d"), "M", "Declines to Disclose" },
                    { new Guid("fdf06aa7-1329-4f32-bd3f-4994c3c1c706"), "E", "Jain" },
                    { new Guid("bdfed790-52ae-4d9e-947c-ae476688832e"), "N", "Patient Religion Unknown" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("09b4d894-b93d-4282-b279-2a389562038f"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("46ef74c1-1310-4e27-9c58-179b26e61746"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("65bcdff9-9f36-4df7-a397-66121bc7baa5"));

            migrationBuilder.DeleteData(
                table: "CCGCodes",
                keyColumn: "Id",
                keyValue: new Guid("687a322f-930d-4089-b026-f869b18a6101"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("095cf8f7-817d-42f8-8903-008a83d77f38"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("160d0c2e-ab94-4ecc-957b-aa59d0fe3620"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("36c6450c-fe47-40a3-8f52-f8a1f04c0e1b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5162f63e-343b-49c8-afd0-792521d30053"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7c4bc1bc-4a26-4e31-bdbf-40a96bfd698d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("847ebf67-15a4-4559-8e53-a988625e00b1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ae8da41a-9e42-4bd3-8a47-5271793f660b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b956978e-7ed6-4014-9826-f3ec643df9d9"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("3a5c0c94-6ba4-4432-8faa-9baed076118d"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("6635d738-968f-4577-b21f-c273d8eb2803"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("92f20e72-de92-4533-ae16-80c6a082862c"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("aef1af58-c659-4009-9e36-1e452411357a"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("d4b9374e-8de5-4726-929e-095b70dc2492"));

            migrationBuilder.DeleteData(
                table: "DisabilityCodes",
                keyColumn: "Id",
                keyValue: new Guid("dfdd0ba3-4218-42cc-8b96-f3449a607c85"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("1902a81d-7938-4565-ad19-e5675285224a"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("1bd330a8-cbed-454d-bcb5-277a63852d1c"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("2faf37d0-a2b0-4850-b262-e83b93f4798e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("59f1a64c-1fd9-48db-b816-a41cf41d619e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("da6975a1-d237-46c0-9684-c78a3a335696"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef6113cc-f060-49df-b0f0-263a6cfffa5e"));

            migrationBuilder.DeleteData(
                table: "EthnicCategories",
                keyColumn: "Id",
                keyValue: new Guid("fdf08ae6-c4f6-4414-a3ba-76785f99fcde"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("11fc9d27-4d84-4f2d-8600-3c1222ff7320"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2cacc3d0-3890-441f-b0ff-464d793b81e3"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("2d7f3dd6-41d8-401f-8c8d-7455a97f321e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("33993eea-8964-4bc6-a9e3-53209a2db608"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("5b917900-256e-4664-8974-f3cb2d223e22"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("6062fb4b-2f56-413b-927a-01737fd0cb4e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("71acf09b-8148-442e-8e60-aa006f4d50a2"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("bdfed790-52ae-4d9e-947c-ae476688832e"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("c8187057-b5fc-477a-8c7a-68c1315351fd"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d2beb8bc-1d52-4f73-a491-13467302de8f"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("d49db039-0943-435f-bc11-81e4669833d9"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("dc0067f6-a3f2-4b98-9feb-f8a94922bf7d"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("e7a0c98e-b39b-4c9b-95d2-8b8c94c3eabe"));

            migrationBuilder.DeleteData(
                table: "ReligiousGroups",
                keyColumn: "Id",
                keyValue: new Guid("fdf06aa7-1329-4f32-bd3f-4994c3c1c706"));

            migrationBuilder.DropColumn(
                name: "StatedMentalHealth",
                table: "eClinicalReferralInfos");

            migrationBuilder.AddColumn<string>(
                name: "StateMentalHealth",
                table: "eClinicalReferralInfos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CCGCodes",
                columns: new[] { "Id", "Code", "Description", "Hub" },
                values: new object[,]
                {
                    { new Guid("fd1ffb7d-04c4-45bd-8727-701c65fc4878"), "01G", "NHS Salford CCG", "Q73" },
                    { new Guid("0027dfe1-68de-4f10-a18d-272ca006c7a8"), "01M", "NHS North Manchester CCG", null },
                    { new Guid("a02f4d0f-a526-4933-8734-ea9456875bd5"), "01N", "NHS South Manchester CCG", "Q73" },
                    { new Guid("1ce773c9-8582-4636-9310-7143ff48a77e"), "12F", "NHS Wirral CCG", "Q75" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("44f3954e-c021-49f4-9c7f-c06d74eebc96"), "Other" },
                    { new Guid("c1034983-d1e3-4b91-8098-656bb05eeeeb"), "Chester" },
                    { new Guid("0707a8d4-7e0c-43e9-983a-a2a739b310e5"), "Leeds" },
                    { new Guid("a0c8857e-f9ee-47bc-8cdf-9570abdf278c"), "Oldhan" },
                    { new Guid("c24af278-951d-4ad5-98b7-ccfab5734804"), "Salfor" },
                    { new Guid("e79201b8-0a2c-42fd-8c96-855484bf222d"), "Manchester" },
                    { new Guid("3f19bd16-ccfe-46f1-85cc-f2879ee7d6b5"), "Liverpool" },
                    { new Guid("0b0bd0f6-44f7-4ace-8ff5-c4e549e6d835"), "York" }
                });

            migrationBuilder.InsertData(
                table: "DisabilityCodes",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("9a7a666a-e44a-4011-a03b-a8b34944c4a0"), "01", "Behaviour and Emotional" },
                    { new Guid("58ca681e-f8fd-4583-9286-5a84c9ed0ab2"), "02", "Hearing" },
                    { new Guid("f0a79ac6-547f-4aa2-b1c9-41465ea647c2"), "03", "Manual Dexterity" },
                    { new Guid("5fbb4513-d5b1-46ca-89d7-8d022e36540a"), "04", "Memory or ability to concentrate, learn or understand (Learning Disability)" },
                    { new Guid("c3ee6e4d-86bd-4360-8c3b-ba4bcfb4f474"), "XX", "Other" },
                    { new Guid("f0a3185c-9c3a-4bbd-a5ae-1bcf6031fde1"), "NN", "No Disability" }
                });

            migrationBuilder.InsertData(
                table: "EthnicCategories",
                columns: new[] { "Id", "Code", "Description", "Sequence" },
                values: new object[,]
                {
                    { new Guid("8579c981-81e4-4b38-b01d-c2b81b043c8b"), "F", "Mixed - White and Asian", 35 },
                    { new Guid("43c98f07-e1a8-4a1d-bde3-864f17f7928b"), "G", "Mixed - Any mixed backgroundn", 40 },
                    { new Guid("41bdcc76-6f34-48f7-a29f-2e6dc5e78480"), "E", "Mixed - White and Black African", 30 },
                    { new Guid("24714fd3-8e12-4a5d-825d-0d8a5e2a252b"), "B", "White - Irish", 20 },
                    { new Guid("8e5186d0-4f34-427b-bb5d-c4a978f2bd92"), "C", "White - Any other White background", 23 },
                    { new Guid("cc917565-2789-4f6f-aead-20672c53d034"), "A", "White -British", 15 },
                    { new Guid("6ed5c2dd-d3c9-4d54-8556-0c1d72d157e5"), "D", "Mixed - White and Black Caribbean", 25 }
                });

            migrationBuilder.InsertData(
                table: "ReligiousGroups",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("560aac9e-2275-4999-91ab-28e12e299c90"), "L", "None" },
                    { new Guid("69f45d82-ee82-43fd-9016-81da1196ef87"), "K", "Other" },
                    { new Guid("936edc6e-0ee3-44f4-b1fe-ecdf0a387ab2"), "J", "Zoroastrian" },
                    { new Guid("3d4a1395-06d1-4f1c-8f24-7c5737a7fd6d"), "I", "Sikh" },
                    { new Guid("49edd8ef-633c-450f-b798-cb6a4609ab97"), "H", "Pagan" },
                    { new Guid("9c34b890-077d-447d-89fd-af56523b8422"), "G", "Muslim" },
                    { new Guid("c36d074a-8643-4e39-9b68-defb63124314"), "F", "Jewish" },
                    { new Guid("85c4ef45-ef3b-419c-8210-a1ae3ee0e3ff"), "D", "Hindu" },
                    { new Guid("c8e54787-abee-4544-9864-c4c4e664e92d"), "C", "Christian" },
                    { new Guid("df7cfdc5-9731-466d-b02e-6b9b4790900b"), "B", "Buddhist" },
                    { new Guid("abc68998-3f3b-43e2-91e5-34ab8e8e946d"), "A", "Baha'i" },
                    { new Guid("73fa427f-343c-4452-9bbb-11cbafce7d32"), "M", "Declines to Disclose" },
                    { new Guid("601a4682-364d-42b4-a023-46eb5a98d731"), "E", "Jain" },
                    { new Guid("43e988e6-c0e5-420c-b66a-40d4d163370b"), "N", "Patient Religion Unknown" }
                });
        }
    }
}
