using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eCommonSurvivorImpactMapping: IEntityTypeConfiguration<eCommonSurvivorImpact>
    {
        public void Configure(EntityTypeBuilder<eCommonSurvivorImpact> builder)
        {
            builder.HasKey(csi => csi.Id);

            builder.Property(csi => csi.HasOrHadEngagedAnyDrugTreatment)
                .HasColumnType("varchar(20)");

            builder.Property(csi => csi.CurrentTreatmentName)
               .HasColumnType("varchar(50)");

            builder.Property(csi => csi.CurrentTreatmentService)
               .HasColumnType("varchar(100)");

            builder.Property(csi => csi.CurrentTreatmentTel)
               .HasColumnType("varchar(30)");

            builder.Property(csi => csi.PrescribedAnyMedical)
               .HasColumnType("varchar(20)");

            builder.Property(csi => csi.ProbationServiceOrCRC)
               .HasColumnType("varchar(20)");

            // EF Relation
            builder.HasMany(csi => csi.EServices)
                .WithOne(eser => eser.ECommonSurvivorImpact)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(csi => csi.EOffences)
                .WithOne(eof => eof.ECommonSurvivorImpact)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(csi => csi.EProbationServices)
                .WithOne(eps => eps.ECommonSurvivorImpact)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
