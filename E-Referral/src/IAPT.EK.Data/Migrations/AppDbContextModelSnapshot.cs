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
                            Id = new Guid("282b0878-b892-458d-947e-65e356d3b7ea"),
                            Name = "Liverpool"
                        },
                        new
                        {
                            Id = new Guid("0c75be76-9583-44c7-a3b0-ee0314f5753b"),
                            Name = "Manchester"
                        },
                        new
                        {
                            Id = new Guid("c66c8f74-0edb-4130-a6e1-8282dc74acd1"),
                            Name = "Salfor"
                        },
                        new
                        {
                            Id = new Guid("ba0f970f-ee03-4893-aa32-4f40ff24bda9"),
                            Name = "York"
                        },
                        new
                        {
                            Id = new Guid("6787c018-e458-42da-a450-d428fdffa382"),
                            Name = "Leeds"
                        },
                        new
                        {
                            Id = new Guid("1013f7d6-974e-4590-85ea-ad474a196fc7"),
                            Name = "Chester"
                        },
                        new
                        {
                            Id = new Guid("a0a0361f-9b40-4f64-8d2c-ea1c59c42245"),
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
                            Id = new Guid("f28fa5e8-a351-480b-8edb-422165da0d9a"),
                            Code = "01",
                            Description = "Behaviour and Emotional"
                        },
                        new
                        {
                            Id = new Guid("201cf3ea-0bf2-46d2-aa30-bea138a3a749"),
                            Code = "02",
                            Description = "Hearing"
                        },
                        new
                        {
                            Id = new Guid("02a1e4f1-159e-4067-b0e8-e49cd5fff424"),
                            Code = "03",
                            Description = "Manual Dexterity"
                        },
                        new
                        {
                            Id = new Guid("7eaff7c7-ddba-489c-8953-104380c33beb"),
                            Code = "04",
                            Description = "Memory or ability to concentrate, learn or understand (Learning Disability)"
                        },
                        new
                        {
                            Id = new Guid("13a1e748-e2a8-4799-ba80-94f80cccbbd1"),
                            Code = "XX",
                            Description = "Other"
                        },
                        new
                        {
                            Id = new Guid("4c2390d1-10ad-405e-a36f-6e3103420a44"),
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
                            Id = new Guid("b33ec21f-8036-40d6-b1e3-0a5ac22753a6"),
                            Code = "A",
                            Description = "White -British",
                            Sequence = 15
                        },
                        new
                        {
                            Id = new Guid("0deff82b-6a26-4236-bcb1-b3f7d66a6f00"),
                            Code = "B",
                            Description = "White - Irish",
                            Sequence = 20
                        },
                        new
                        {
                            Id = new Guid("b3d92fdc-2c06-4d5f-8b3b-5b7a7f53542a"),
                            Code = "C",
                            Description = "White - Any other White background",
                            Sequence = 23
                        },
                        new
                        {
                            Id = new Guid("ac744792-f52a-41f6-8483-0733082e695e"),
                            Code = "D",
                            Description = "Mixed - White and Black Caribbean",
                            Sequence = 25
                        },
                        new
                        {
                            Id = new Guid("8aa9466d-fdfa-4815-80c5-c70b789a268e"),
                            Code = "E",
                            Description = "Mixed - White and Black African",
                            Sequence = 30
                        },
                        new
                        {
                            Id = new Guid("e1a4677d-e62c-41cb-820e-a1f92ab9f7bc"),
                            Code = "F",
                            Description = "Mixed - White and Asian",
                            Sequence = 35
                        },
                        new
                        {
                            Id = new Guid("637815df-7a25-457e-9ed8-62080f086282"),
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
                            Id = new Guid("36be50e4-4b2f-428d-837a-77afa360a7e8"),
                            Code = "A",
                            Description = "Baha'i"
                        },
                        new
                        {
                            Id = new Guid("11008e66-5aac-4f52-b24a-00360ee0bb56"),
                            Code = "B",
                            Description = "Buddhist"
                        },
                        new
                        {
                            Id = new Guid("6a20ccf0-f710-49ac-baff-7712e24411c7"),
                            Code = "C",
                            Description = "Christian"
                        },
                        new
                        {
                            Id = new Guid("48b99c82-8b07-4593-930f-64b6b746ccb4"),
                            Code = "D",
                            Description = "Hindu"
                        },
                        new
                        {
                            Id = new Guid("9a482916-07c0-4917-b55b-03252c400918"),
                            Code = "E",
                            Description = "Jain"
                        },
                        new
                        {
                            Id = new Guid("9d48df5b-859d-4507-a880-b16e4303598e"),
                            Code = "F",
                            Description = "Jewish"
                        },
                        new
                        {
                            Id = new Guid("8d328a75-d93a-404a-a400-dc149fddf591"),
                            Code = "G",
                            Description = "Muslim"
                        },
                        new
                        {
                            Id = new Guid("4b5811e7-07dc-4643-a91b-4b1dddc57779"),
                            Code = "H",
                            Description = "Pagan"
                        },
                        new
                        {
                            Id = new Guid("173df8ae-43dd-45e5-805d-28a4e6bff187"),
                            Code = "I",
                            Description = "Sikh"
                        },
                        new
                        {
                            Id = new Guid("812a9fe0-8458-45e7-b06d-ba08f27af27d"),
                            Code = "J",
                            Description = "Zoroastrian"
                        },
                        new
                        {
                            Id = new Guid("969f6b99-cb0b-4cbb-bd2e-ad599db9f2ba"),
                            Code = "K",
                            Description = "Other"
                        },
                        new
                        {
                            Id = new Guid("7d05cc09-35f1-4e58-b05f-299bb6d5ef59"),
                            Code = "L",
                            Description = "None"
                        },
                        new
                        {
                            Id = new Guid("11ac2916-07ea-406b-bd74-9ee4b9b4b0bb"),
                            Code = "M",
                            Description = "Declines to Disclose"
                        },
                        new
                        {
                            Id = new Guid("f1de199d-044e-443b-91e6-704e65580fdc"),
                            Code = "N",
                            Description = "Patient Religion Unknown"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
