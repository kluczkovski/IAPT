using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eTreatmentMapping: IEntityTypeConfiguration<eTreatment>
    {
        public void Configure(EntityTypeBuilder<eTreatment> builder)
        {
            builder.HasKey(tre => tre.Id);

            builder.Property(tre => tre.Service)
                .HasColumnType("varchar(100)");

            builder.Property(tre => tre.TreatmentProvided)
               .HasColumnType("varchar(100)");

            builder.Property(tre => tre.Start)
               .HasColumnType("varchar(50)");

            builder.Property(tre => tre.End)
               .HasColumnType("varchar(50)");

        }
    }
}
