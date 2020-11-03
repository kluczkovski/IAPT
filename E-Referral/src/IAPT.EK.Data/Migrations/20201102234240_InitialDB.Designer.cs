﻿// <auto-generated />
using System;
using IAPT.EK.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IAPT.EK.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201102234240_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IAPT.EK.Business.Models.CCGCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Hub")
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("CCGCodes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("26e2917d-6e66-4196-86ae-0356f1ec9849"),
                            Code = "01G",
                            Description = "NHS Salford CCG",
                            Hub = "Q73"
                        },
                        new
                        {
                            Id = new Guid("82ee76be-ebc2-43cc-b7ae-e56f94bc04a0"),
                            Code = "01M",
                            Description = "NHS North Manchester CCG"
                        },
                        new
                        {
                            Id = new Guid("cb70014d-e488-473f-adee-09dec20f14ff"),
                            Code = "01N",
                            Description = "NHS South Manchester CCG",
                            Hub = "Q73"
                        },
                        new
                        {
                            Id = new Guid("513ed5e6-a9f8-4525-bcb1-2be50ca8df4e"),
                            Code = "12F",
                            Description = "NHS Wirral CCG",
                            Hub = "Q75"
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5216453e-af89-4e45-b37c-08f4ce29dcc1"),
                            Name = "Liverpool"
                        },
                        new
                        {
                            Id = new Guid("f94bfa97-444c-488e-9b03-794852666e17"),
                            Name = "Manchester"
                        },
                        new
                        {
                            Id = new Guid("15563676-b516-46ef-8e0d-4e914a3482e4"),
                            Name = "Salfor"
                        },
                        new
                        {
                            Id = new Guid("a48054f3-ef13-448d-aef1-d33d1edde9d4"),
                            Name = "York"
                        },
                        new
                        {
                            Id = new Guid("bc8a4f58-9e77-4f15-af67-c0c2ec69a2d4"),
                            Name = "Leeds"
                        },
                        new
                        {
                            Id = new Guid("bea04ca5-2c4c-471e-b651-83a6e39bdc7a"),
                            Name = "Chester"
                        },
                        new
                        {
                            Id = new Guid("224675de-554c-4634-be80-516d9e470003"),
                            Name = "Oldhan"
                        },
                        new
                        {
                            Id = new Guid("546b0715-c6c0-4579-ac1f-f2848a82a75c"),
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.DisabilityCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("DisabilityCodes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("90409b58-bdf6-4a76-8c52-1eb8e15da4ff"),
                            Code = "01",
                            Description = "Behaviour and Emotional"
                        },
                        new
                        {
                            Id = new Guid("e42896c2-fd95-4a91-b7f1-4b391f42c3d0"),
                            Code = "02",
                            Description = "Hearing"
                        },
                        new
                        {
                            Id = new Guid("62444bc7-c38e-4611-bc08-a3763f02d5e7"),
                            Code = "03",
                            Description = "Manual Dexterity"
                        },
                        new
                        {
                            Id = new Guid("8a551c10-b4d7-4b8e-80e7-0c36e4680a74"),
                            Code = "04",
                            Description = "Memory or ability to concentrate, learn or understand (Learning Disability)"
                        },
                        new
                        {
                            Id = new Guid("eba929b1-bdb0-497c-a068-2b349bd90613"),
                            Code = "XX",
                            Description = "Other"
                        },
                        new
                        {
                            Id = new Guid("8131e6cd-577e-40b2-8508-7b023e4ff6d8"),
                            Code = "NN",
                            Description = "No Disability"
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.EthnicCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Sequence")
                        .HasColumnType("int(5)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("EthnicCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("619c51e0-9d8d-4b65-a89b-e791de749477"),
                            Code = "A",
                            Description = "White -British",
                            Sequence = 15
                        },
                        new
                        {
                            Id = new Guid("4a3dd610-ca57-449d-bcad-1e707b66c3ac"),
                            Code = "B",
                            Description = "White - Irish",
                            Sequence = 20
                        },
                        new
                        {
                            Id = new Guid("7b49fd1f-ebbf-4157-95af-b91199b954cb"),
                            Code = "C",
                            Description = "White - Any other White background",
                            Sequence = 23
                        },
                        new
                        {
                            Id = new Guid("c8dff924-cc48-4868-9192-9303a44443fa"),
                            Code = "D",
                            Description = "Mixed - White and Black Caribbean",
                            Sequence = 25
                        },
                        new
                        {
                            Id = new Guid("4526b3e4-02d5-4485-aaa0-16a8b620d20b"),
                            Code = "E",
                            Description = "Mixed - White and Black African",
                            Sequence = 30
                        },
                        new
                        {
                            Id = new Guid("c4b77fce-ad5d-4c73-9d5d-9ca6261e4005"),
                            Code = "F",
                            Description = "Mixed - White and Asian",
                            Sequence = 35
                        },
                        new
                        {
                            Id = new Guid("e5a49a0f-5b99-464e-8ef2-336a55e7aa0c"),
                            Code = "G",
                            Description = "Mixed - Any mixed backgroundn",
                            Sequence = 40
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.GPPractice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressLine4")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressLine5")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid?>("CCGCodeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PostCode")
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id");

                    b.HasIndex("CCGCodeId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("GPPractices");
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.ReligiousGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("ReligiousGroups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0879953c-3cef-4740-85e0-2d4595d1126d"),
                            Code = "A",
                            Description = "Baha'i"
                        },
                        new
                        {
                            Id = new Guid("e74b9f2a-0c37-47cb-a967-e4b2baaba75c"),
                            Code = "B",
                            Description = "Buddhist"
                        },
                        new
                        {
                            Id = new Guid("41ed053f-bc00-479b-b119-98608e28e197"),
                            Code = "C",
                            Description = "Christian"
                        },
                        new
                        {
                            Id = new Guid("1d71a7cb-74b7-4a09-ada3-3e8f70e26705"),
                            Code = "D",
                            Description = "Hindu"
                        },
                        new
                        {
                            Id = new Guid("10d036e6-9c9e-43b5-984b-9a10bcedd009"),
                            Code = "E",
                            Description = "Jain"
                        },
                        new
                        {
                            Id = new Guid("f940efdd-8bdc-42db-970c-d3632b3f2f13"),
                            Code = "F",
                            Description = "Jewish"
                        },
                        new
                        {
                            Id = new Guid("0fbb6d5d-0d79-4f7f-82d5-b63c0016c8ef"),
                            Code = "G",
                            Description = "Muslim"
                        },
                        new
                        {
                            Id = new Guid("dfd74e1b-8039-44ed-8bb5-e70c98228758"),
                            Code = "H",
                            Description = "Pagan"
                        },
                        new
                        {
                            Id = new Guid("bf6f9139-2bdd-4e6b-b220-2737988796b5"),
                            Code = "I",
                            Description = "Sikh"
                        },
                        new
                        {
                            Id = new Guid("72c9841a-fcb9-49f9-8edc-aa61c625a6c4"),
                            Code = "J",
                            Description = "Zoroastrian"
                        },
                        new
                        {
                            Id = new Guid("f24d4634-adf2-46c9-8872-400d5f0e8949"),
                            Code = "K",
                            Description = "Other"
                        },
                        new
                        {
                            Id = new Guid("9a20a87c-f960-4e95-bae4-aa400ea1a291"),
                            Code = "L",
                            Description = "None"
                        },
                        new
                        {
                            Id = new Guid("4c29898e-a721-4501-986e-a0d019f3e01a"),
                            Code = "M",
                            Description = "Declines to Disclose"
                        },
                        new
                        {
                            Id = new Guid("31bb43dc-c0f3-4832-8518-0a6afbe62944"),
                            Code = "N",
                            Description = "Patient Religion Unknown"
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.eAgencyInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Agency")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("AgencyHasClientConsent")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("EReferralId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EReferralId")
                        .IsUnique();

                    b.ToTable("EAgencyInformations");
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.eContactDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Address2")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CityId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EReferralId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid?>("GpPracticeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("MethodsToContact")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Mobile")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NHSNumber")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("anotherCity")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("EReferralId")
                        .IsUnique();

                    b.HasIndex("GpPracticeId");

                    b.ToTable("EContactDetails");
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.eDiversity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EReferralId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EthnicCategoryId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("IsgenderAssignedAtBirth")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ParentalStatus")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhysicalDisability")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhysicalDisabilityState")
                        .HasColumnType("varchar(500)");

                    b.Property<Guid>("ReligionId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Sexuality")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SpecificSupportNeedState")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("SpecificSupportNeeds")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EReferralId")
                        .IsUnique();

                    b.HasIndex("EthnicCategoryId");

                    b.HasIndex("ReligionId");

                    b.ToTable("EDiversities");
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.eReferral", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ReceivedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Source")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EReferrals");
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.GPPractice", b =>
                {
                    b.HasOne("IAPT.EK.Business.Models.CCGCode", "CCGCode")
                        .WithMany("GPPractices")
                        .HasForeignKey("CCGCodeId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.eAgencyInformation", b =>
                {
                    b.HasOne("IAPT.EK.Business.Models.eReferral", "eReferral")
                        .WithOne("eAgencyInformation")
                        .HasForeignKey("IAPT.EK.Business.Models.eAgencyInformation", "EReferralId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.eContactDetail", b =>
                {
                    b.HasOne("IAPT.EK.Business.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("IAPT.EK.Business.Models.eReferral", "eReferral")
                        .WithOne("eContactDetail")
                        .HasForeignKey("IAPT.EK.Business.Models.eContactDetail", "EReferralId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IAPT.EK.Business.Models.GPPractice", "GpPractice")
                        .WithMany()
                        .HasForeignKey("GpPracticeId");
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.eDiversity", b =>
                {
                    b.HasOne("IAPT.EK.Business.Models.eReferral", "eReferral")
                        .WithOne("eDiversity")
                        .HasForeignKey("IAPT.EK.Business.Models.eDiversity", "EReferralId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IAPT.EK.Business.Models.EthnicCategory", "EthnicCategory")
                        .WithMany()
                        .HasForeignKey("EthnicCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IAPT.EK.Business.Models.ReligiousGroup", "Religion")
                        .WithMany()
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
