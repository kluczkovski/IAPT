using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Data.Mappings
{
    public class EthnicCategoryMapping : IEntityTypeConfiguration<EthnicCategory>
    {
        public EthnicCategoryMapping()
        {
        }

        public void Configure(EntityTypeBuilder<EthnicCategory> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasIndex(a => a.Code).IsUnique();

            builder.Property(a => a.Code)
                   .IsRequired()
                   .HasColumnType("varchar(5)");

            builder.Property(a => a.Description)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(a => a.Sequence)
                   .IsRequired()
                   .HasColumnType("int(5)");

            builder.HasMany(a => a.EDiversities)
                   .WithOne(d => d.EthnicCategory)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasData(
                new EthnicCategory
                {
                    Id = Guid.NewGuid(),
                    Code = "A",
                    Description = "White -British",
                    Sequence = 15
                },
                new EthnicCategory
                {
                    Id = Guid.NewGuid(),
                    Code = "B",
                    Description = "White - Irish",
                    Sequence = 20
                },
                new EthnicCategory
                {
                    Id = Guid.NewGuid(),
                    Code = "C",
                    Description = "White - Any other White background",
                    Sequence = 23
                },
                new EthnicCategory
                {
                    Id = Guid.NewGuid(),
                    Code = "D",
                    Description = "Mixed - White and Black Caribbean",
                    Sequence = 25
                },
                new EthnicCategory
                {
                    Id = Guid.NewGuid(),
                    Code = "E",
                    Description = "Mixed - White and Black African",
                    Sequence = 30
                },
                new EthnicCategory
                {
                    Id = Guid.NewGuid(),
                    Code = "F",
                    Description = "Mixed - White and Asian",
                    Sequence = 35
                }, new EthnicCategory
                {
                    Id = Guid.NewGuid(),
                    Code = "G",
                    Description = "Mixed - Any mixed backgroundn",
                    Sequence = 40
                }
                );  

        }
    }
}
