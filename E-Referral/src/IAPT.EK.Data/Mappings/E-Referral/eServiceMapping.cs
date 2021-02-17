using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eServiceMapping: IEntityTypeConfiguration<eService>
    {
        public void Configure(EntityTypeBuilder<eService> builder)
        {
            builder.HasKey(ser => ser.Id);

            builder.Property(ser => ser.Service)
                .HasColumnType("varchar(150)");

            builder.Property(ser => ser.TreatmentProvided)
               .HasColumnType("varchar(100)");

            builder.Property(ser => ser.Start)
               .HasColumnType("varchar(50)");

            builder.Property(ser => ser.End)
               .HasColumnType("varchar(50)"); 
        }
    }
}
