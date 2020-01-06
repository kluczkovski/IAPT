﻿// <auto-generated />
using System;
using IAPT.EK.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IAPT.EK.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IAPT.EK.Business.Models.CCGCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

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
                            Id = new Guid("fe5b3a69-9204-448c-b407-6420e35dfb94"),
                            Code = "01G",
                            Description = "NHS Salford CCG",
                            Hub = "Q73"
                        },
                        new
                        {
                            Id = new Guid("dba432b4-514b-49b0-8794-ad634b63d5df"),
                            Code = "01M",
                            Description = "NHS North Manchester CCG"
                        },
                        new
                        {
                            Id = new Guid("60822e7d-9978-4b51-b082-6327ee535c03"),
                            Code = "01N",
                            Description = "NHS North Manchester CCG",
                            Hub = "Q73"
                        },
                        new
                        {
                            Id = new Guid("c96f532a-311d-41b2-a16d-9be9f243ea49"),
                            Code = "12F",
                            Description = "NHS Wirral CCG",
                            Hub = "Q75"
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d88ef3e0-6220-4456-b2cb-93243493b23a"),
                            Name = "Liverpool"
                        },
                        new
                        {
                            Id = new Guid("31d1ed50-5a1b-4075-b421-19b994a27708"),
                            Name = "Manchester"
                        },
                        new
                        {
                            Id = new Guid("bdf5f74d-ebb0-499f-8c57-1187a15a4d57"),
                            Name = "Salfor"
                        },
                        new
                        {
                            Id = new Guid("456b019b-0cbd-472b-9524-e33dc3742072"),
                            Name = "York"
                        },
                        new
                        {
                            Id = new Guid("49601309-7fa3-4bec-b771-3792bdc0f5e1"),
                            Name = "Leeds"
                        },
                        new
                        {
                            Id = new Guid("6a0ccee9-7b79-4ddd-bfcc-603c6264abd1"),
                            Name = "Chester"
                        },
                        new
                        {
                            Id = new Guid("e8450931-eef2-4c58-9bdc-fb0f7743e5e6"),
                            Name = "Oldhan"
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.DisabilityCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("DisabilityCode");

                    b.HasData(
                        new
                        {
                            Id = new Guid("59020817-0b62-4dd1-a43c-fea3b912f5ac"),
                            Code = "01",
                            Description = "Behaviour and Emotional"
                        },
                        new
                        {
                            Id = new Guid("fd13a8f2-245a-4984-ae5f-33f5c7ab5670"),
                            Code = "02",
                            Description = "Hearing"
                        },
                        new
                        {
                            Id = new Guid("00d8f0a0-641a-4324-850b-43d1caaf8ba8"),
                            Code = "03",
                            Description = "Manual Dexterity"
                        },
                        new
                        {
                            Id = new Guid("a20933b9-8ce2-4bf6-8a93-a06133763dbb"),
                            Code = "04",
                            Description = "Memory or ability to concentrate, learn or understand (Learning Disability)"
                        },
                        new
                        {
                            Id = new Guid("c087eaff-5739-48de-a740-8d530753da7e"),
                            Code = "XX",
                            Description = "Other"
                        },
                        new
                        {
                            Id = new Guid("ab2e674d-9640-4b8c-82dc-cebb34874de5"),
                            Code = "NN",
                            Description = "No Disability"
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.EthnicCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

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
                            Id = new Guid("c21e3982-9d49-4df8-bfd8-b393ec78045f"),
                            Code = "A",
                            Description = "White -British",
                            Sequence = 15
                        },
                        new
                        {
                            Id = new Guid("cf833fab-1aa7-4b26-89f7-978baecb2203"),
                            Code = "B",
                            Description = "White - Irish",
                            Sequence = 20
                        },
                        new
                        {
                            Id = new Guid("6bad26f1-5efc-4c8d-adaa-6c4c22d94544"),
                            Code = "C",
                            Description = "White - Any other White background",
                            Sequence = 23
                        },
                        new
                        {
                            Id = new Guid("5061fe58-f0af-4289-b882-61a9aad56d2e"),
                            Code = "D",
                            Description = "Mixed - White and Black Caribbean",
                            Sequence = 25
                        },
                        new
                        {
                            Id = new Guid("5157c9f6-a930-4db3-81e5-aa1770e24a8e"),
                            Code = "E",
                            Description = "Mixed - White and Black African",
                            Sequence = 30
                        },
                        new
                        {
                            Id = new Guid("4e7a2afc-644f-41c3-b4c1-baf9bf8f6436"),
                            Code = "F",
                            Description = "Mixed - White and Asian",
                            Sequence = 35
                        },
                        new
                        {
                            Id = new Guid("00224bb7-d6ac-4267-8f44-e286e14246b3"),
                            Code = "G",
                            Description = "Mixed - Any mixed backgroundn",
                            Sequence = 40
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.GPPractice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressLine3");

                    b.Property<string>("AddressLine4");

                    b.Property<string>("AddressLine5");

                    b.Property<Guid>("CCGCodeId");

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
                        .ValueGeneratedOnAdd();

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
                            Id = new Guid("84ec1d3c-0332-40a4-91df-94f5ad8c6501"),
                            Code = "A",
                            Description = "Baha'i"
                        },
                        new
                        {
                            Id = new Guid("fccddfa8-30c6-4afc-90a6-74e8a2c80153"),
                            Code = "B",
                            Description = "Buddhist"
                        },
                        new
                        {
                            Id = new Guid("d8a70e38-2c0c-451e-9650-cfc6adabc46f"),
                            Code = "C",
                            Description = "Christian"
                        },
                        new
                        {
                            Id = new Guid("5a448806-b59f-47b5-bc6e-01acc5a6adbf"),
                            Code = "D",
                            Description = "Hindu"
                        },
                        new
                        {
                            Id = new Guid("55a3e5a4-d3b3-4b46-a8ab-0a7abf289060"),
                            Code = "E",
                            Description = "Jain"
                        },
                        new
                        {
                            Id = new Guid("c679c2bc-9d15-4a54-b0b3-0cb1849cdd82"),
                            Code = "F",
                            Description = "Jewish"
                        },
                        new
                        {
                            Id = new Guid("cfd1120c-6c8f-4436-953a-74f7c24d4716"),
                            Code = "G",
                            Description = "Muslim"
                        },
                        new
                        {
                            Id = new Guid("2e1bec74-ffc3-4ceb-99f4-122716afe5c8"),
                            Code = "H",
                            Description = "Pagan"
                        },
                        new
                        {
                            Id = new Guid("866ab01d-0f49-4b6c-b424-2b6a45832c0b"),
                            Code = "I",
                            Description = "Sikh"
                        },
                        new
                        {
                            Id = new Guid("c9cf6709-0001-45b1-853e-6e3a3dc00034"),
                            Code = "J",
                            Description = "Zoroastrian"
                        },
                        new
                        {
                            Id = new Guid("88fbb7f9-5045-4d55-bd19-19433260ef48"),
                            Code = "K",
                            Description = "Other"
                        },
                        new
                        {
                            Id = new Guid("3325dc9b-77fb-4aa6-93d2-3a346e8d91e7"),
                            Code = "L",
                            Description = "None"
                        },
                        new
                        {
                            Id = new Guid("e204ccfc-aa53-4c85-8039-4a5a11503c69"),
                            Code = "M",
                            Description = "Declines to Disclose"
                        },
                        new
                        {
                            Id = new Guid("ef411c33-d27e-494c-bb44-5db1fca8daf8"),
                            Code = "N",
                            Description = "Patient Religion Unknown"
                        });
                });

            modelBuilder.Entity("IAPT.EK.Business.Models.GPPractice", b =>
                {
                    b.HasOne("IAPT.EK.Business.Models.CCGCode", "CCGCode")
                        .WithMany("GPPractices")
                        .HasForeignKey("CCGCodeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
