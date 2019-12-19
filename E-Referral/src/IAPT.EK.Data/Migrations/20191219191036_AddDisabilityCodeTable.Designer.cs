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
    [Migration("20191219191036_AddDisabilityCodeTable")]
    partial class AddDisabilityCodeTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
                            Id = new Guid("fa56b2a8-5ef2-4caa-b7e6-f50ca8cae2e9"),
                            Code = "01",
                            Description = "Behaviour and Emotional"
                        },
                        new
                        {
                            Id = new Guid("cdcf851a-2800-43af-9410-ac54f98d8b21"),
                            Code = "02",
                            Description = "Hearing"
                        },
                        new
                        {
                            Id = new Guid("22e17f4d-4c62-461a-81b7-d3f1950bff25"),
                            Code = "03",
                            Description = "Manual Dexterity"
                        },
                        new
                        {
                            Id = new Guid("3c571839-ddc2-461d-ae15-bb1da1839972"),
                            Code = "04",
                            Description = "Memory or ability to concentrate, learn or understand (Learning Disability)"
                        },
                        new
                        {
                            Id = new Guid("120e9c07-3dba-4b4a-8d13-cd26ce7e5add"),
                            Code = "XX",
                            Description = "Other"
                        },
                        new
                        {
                            Id = new Guid("513885d6-2a62-41b5-b2e0-9972ca6fa93f"),
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
                            Id = new Guid("8c0e1f18-6ed9-4163-9d3c-f8b34c784745"),
                            Code = "A",
                            Description = "White -British",
                            Sequence = 15
                        },
                        new
                        {
                            Id = new Guid("a1d1631c-0fc9-4264-8d63-5717227c014f"),
                            Code = "B",
                            Description = "White - Irish",
                            Sequence = 20
                        },
                        new
                        {
                            Id = new Guid("ecc71318-1a0c-499c-9541-931974cfb296"),
                            Code = "C",
                            Description = "White - Any other White background",
                            Sequence = 23
                        },
                        new
                        {
                            Id = new Guid("7f88298f-8ec7-456d-b90b-2aa441c2da67"),
                            Code = "D",
                            Description = "Mixed - White and Black Caribbean",
                            Sequence = 25
                        },
                        new
                        {
                            Id = new Guid("e2e9c54d-d8b2-4f00-9db6-ba5f13dfd4af"),
                            Code = "E",
                            Description = "Mixed - White and Black African",
                            Sequence = 30
                        },
                        new
                        {
                            Id = new Guid("8b288331-019e-427e-8a05-26dcfbe95fb8"),
                            Code = "F",
                            Description = "Mixed - White and Asian",
                            Sequence = 35
                        },
                        new
                        {
                            Id = new Guid("228ad55e-1791-4a77-90da-f1d8769ae18b"),
                            Code = "G",
                            Description = "Mixed - Any mixed backgroundn",
                            Sequence = 40
                        });
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
                            Id = new Guid("03b844d7-3c86-4a80-8dfe-549c685b5090"),
                            Code = "A",
                            Description = "Baha'i"
                        },
                        new
                        {
                            Id = new Guid("a4ad8a89-e3d9-4717-a1a2-e29a59e3a873"),
                            Code = "B",
                            Description = "Buddhist"
                        },
                        new
                        {
                            Id = new Guid("40aca05f-669f-4be8-bfcb-5c5636a347b6"),
                            Code = "C",
                            Description = "Christian"
                        },
                        new
                        {
                            Id = new Guid("c4ecdef8-5066-4320-8f96-df03309c8798"),
                            Code = "D",
                            Description = "Hindu"
                        },
                        new
                        {
                            Id = new Guid("70eff45b-6bf3-4858-bf39-e368e75af1ce"),
                            Code = "E",
                            Description = "Jain"
                        },
                        new
                        {
                            Id = new Guid("9908d908-ec4f-4331-a3f7-1e68f4b96f7b"),
                            Code = "F",
                            Description = "Jewish"
                        },
                        new
                        {
                            Id = new Guid("a00324b1-73c8-4cb9-a1df-3a1b5516926c"),
                            Code = "G",
                            Description = "Muslim"
                        },
                        new
                        {
                            Id = new Guid("1a4a992b-9d93-4ef6-9874-b6f0c9cc73e6"),
                            Code = "H",
                            Description = "Pagan"
                        },
                        new
                        {
                            Id = new Guid("de18ac3f-ee3f-4688-a2da-a70b6500c554"),
                            Code = "I",
                            Description = "Sikh"
                        },
                        new
                        {
                            Id = new Guid("6b6eb6a9-428e-4ecb-bfd3-1a000e241413"),
                            Code = "J",
                            Description = "Zoroastrian"
                        },
                        new
                        {
                            Id = new Guid("946b8da0-d027-408f-980d-82d8598a3426"),
                            Code = "K",
                            Description = "Other"
                        },
                        new
                        {
                            Id = new Guid("6b0b2da6-5462-43c7-8845-29284b18fd5f"),
                            Code = "L",
                            Description = "None"
                        },
                        new
                        {
                            Id = new Guid("b34a1dd3-ae8a-4561-a250-0dac8f5f19db"),
                            Code = "M",
                            Description = "Declines to Disclose"
                        },
                        new
                        {
                            Id = new Guid("828cfccd-813e-4432-90e9-9ced65ffd4be"),
                            Code = "N",
                            Description = "Patient Religion Unknown"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
