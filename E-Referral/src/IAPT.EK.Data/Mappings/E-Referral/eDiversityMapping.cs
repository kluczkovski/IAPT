using System;
using IAPT.EK.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eDiversityMapping: IEntityTypeConfiguration<eDiversity>
    { 
        public void Configure(EntityTypeBuilder<eDiversity> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.EReferralId)
                    .IsRequired(true);

            builder.Property(d => d.Gender)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            builder.Property(d => d.IsgenderAssignedAtBirth)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            builder.Property(d => d.EthnicCategoryId)
                    .IsRequired(true);
           
            builder.Property(d => d.Sexuality)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            builder.Property(d => d.ReligionId)
                    .IsRequired(true);
          
            builder.Property(d => d.MaritalStatus)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            builder.Property(d => d.ParentalStatus)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            builder.Property(d => d.PhysicalDisability)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            builder.Property(d => d.PhysicalDisabilityState)
                    .HasColumnType("varchar(500)");

            builder.Property(d => d.SpecificSupportNeeds)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            builder.Property(d => d.SpecificSupportNeedState)
                    .HasColumnType("varchar(500)");

        }
    }
}
