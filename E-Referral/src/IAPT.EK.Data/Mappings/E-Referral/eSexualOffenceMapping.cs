using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eSexualOffenceMapping: IEntityTypeConfiguration<eSexualOffence>
    {
        public void Configure(EntityTypeBuilder<eSexualOffence> builder)
        {
            builder.HasKey(so => so.Id);

            builder.Property(so => so.BriefSummary)
               .IsRequired();
           
            builder.Property(so => so.WhenWasIt)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(so => so.OffenceType)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.Property(so => so.AgeAtTimeOfOffence)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.Property(so => so.WhatWasGenderOfPerpetror)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.Property(so => so.WhatWasRelationshipToPerpetror)
               .IsRequired()
               .HasColumnType("varchar(250)");

        }
    }
}
