using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eRiskIndicatorMapping : IEntityTypeConfiguration<eRiskIndicator>
    {
    
        public void Configure(EntityTypeBuilder<eRiskIndicator> builder)
        {
            builder.HasKey(ri => ri.Id);

            builder.Property(ri => ri.HasClientRisk)
                .IsRequired()
                .HasColumnType("varchar(50)");
        }
    }
}
