using System;
using IAPT.EK.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings
{
    public class eReferralMapping: IEntityTypeConfiguration<eReferral>
    {
        
        public void Configure(EntityTypeBuilder<eReferral> builder)
        {
            builder.HasKey(er => er.Id);

            builder.Property(er => er.ReceivedDate)
                .IsRequired(true);

            builder.Property(er => er.Type)
                .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(er => er.Source)
                .HasColumnType("varchar(100)");

            builder.Property(er => er.Status)
                .IsRequired(true)
                .HasColumnType("varchar(50)")
                .HasConversion<string>();     //convert Enum in a string;


            // Relations
            builder.HasOne(eref => eref.eAgencyInformation)
                   .WithOne(ai => ai.eReferral)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(eref => eref.eContactDetail)
                    .WithOne(cd => cd.eReferral)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(eref => eref.eDiversity)
                    .WithOne(div => div.eReferral)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
