using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eOffenceMapping: IEntityTypeConfiguration<eOffence>
    {
        public void Configure(EntityTypeBuilder<eOffence> builder)
        {
            builder.HasKey(off => off.Id);

            builder.Property(off => off.Offence)
                .HasColumnType("varchar(150)");

            builder.Property(off => off.Conviction)
               .HasColumnType("varchar(30)");

            builder.Property(off => off.LengthOfSentence)
               .HasColumnType("varchar(30)");

            builder.Property(off => off.MonthYearSentence)
               .HasColumnType("varchar(30)");
        }
    }
}
