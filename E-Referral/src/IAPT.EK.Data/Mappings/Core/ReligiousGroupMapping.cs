using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IAPT.EK.Business.Models;


namespace IAPT.EK.Data.Mappings
{
    public class ReligiousGroupMapping : IEntityTypeConfiguration<ReligiousGroup>
    {
        public void Configure(EntityTypeBuilder<ReligiousGroup> builder)
        {
            builder.HasKey(rg => rg.Id);

            builder.HasIndex(rg => rg.Code).IsUnique();

            builder.Property(rg => rg.Code)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(rg => rg.Description)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasMany(rg => rg.EDiversities)
                .WithOne(d => d.Religion)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasData(
                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "A",
                    Description = "Baha'i"
                },

                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "B",
                    Description = "Buddhist"
                },

                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "C",
                    Description = "Christian"
                },

                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "D",
                    Description = "Hindu"
                },

                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "E",
                    Description = "Jain"
                },

                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "F",
                    Description = "Jewish"
                },

                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "G",
                    Description = "Muslim"
                },

                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "H",
                    Description = "Pagan"
                },

                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "I",
                    Description = "Sikh"
                },
                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "J",
                    Description = "Zoroastrian"
                },
                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "K",
                    Description = "Other"
                },
                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "L",
                    Description = "None"
                }, new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "M",
                    Description = "Declines to Disclose"
                },
                new ReligiousGroup
                {
                    Id = Guid.NewGuid(),
                    Code = "N",
                    Description = "Patient Religion Unknown"
                }
                ); 
        }
    }
}
