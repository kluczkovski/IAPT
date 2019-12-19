using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IAPT.EK.Business.Models;


namespace IAPT.EK.Data.Mappings
{
    public class DisabilityCodeMapping : IEntityTypeConfiguration<DisabilityCode>
    {
        public void Configure(EntityTypeBuilder<DisabilityCode> builder)
        {
            builder.HasKey(rg => rg.Id);

            builder.HasIndex(rg => rg.Code).IsUnique();

            builder.Property(rg => rg.Code)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(rg => rg.Description)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasData(
                new DisabilityCode
                {
                    Id = Guid.NewGuid(),
                    Code = "01",
                    Description = "Behaviour and Emotional"
                },
                new DisabilityCode
                {
                    Id = Guid.NewGuid(),
                    Code = "02",
                    Description = "Hearing"
                },
                new DisabilityCode
                {
                    Id = Guid.NewGuid(),
                    Code = "03",
                    Description = "Manual Dexterity"
                },
                new DisabilityCode
                {
                    Id = Guid.NewGuid(),
                    Code = "04",
                    Description = "Memory or ability to concentrate, learn or understand (Learning Disability)"
                },
                new DisabilityCode
                {
                    Id = Guid.NewGuid(),
                    Code = "XX",
                    Description = "Other"
                },
                new DisabilityCode
                {
                    Id = Guid.NewGuid(),
                    Code = "NN",
                    Description = "No Disability"
                }
               

                ); 
        }
        
    }
}
