using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eArmedForceMapping : IEntityTypeConfiguration<eArmedForce>
    {
   
        public void Configure(EntityTypeBuilder<eArmedForce> builder)
        {
            builder.HasKey(af => af.Id);

            builder.Property(af => af.EReferralId)
                    .IsRequired(true);

            builder.Property(af => af.MemberOfArmedForce)
                    .IsRequired(true);

            builder.Property(af => af.HasLinkedWithArmedForce)
                    .HasColumnType("varchar(10)");

            //builder.Property(af => af.Branch)
            //   .HasColumnType("varchar(50)")
            //   .HasConversion<string>();     //convert Enum in a string;

            builder.Property(af => af.ServiceNumber)
                    .HasColumnType("varchar(20)");

        }



    }
}
