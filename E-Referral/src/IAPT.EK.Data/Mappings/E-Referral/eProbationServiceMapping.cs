using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eProbationServiceMapping: IEntityTypeConfiguration<eProbationService>
    {
        public void Configure(EntityTypeBuilder<eProbationService> builder)
        {
            builder.HasKey(pro => pro.Id);

            builder.Property(pro => pro.Name)
                .HasColumnType("varchar(50)");

            builder.Property(pro => pro.Service)
               .HasColumnType("varchar(100)");

            builder.Property(pro => pro.Telephone)
               .HasColumnType("varchar(50)");

        }
    }
}
