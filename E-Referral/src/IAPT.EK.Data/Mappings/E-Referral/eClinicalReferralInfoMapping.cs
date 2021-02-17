using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eClinicalReferralInfoMapping: IEntityTypeConfiguration<eClinicalReferralInfo>
    {
      
        public void Configure(EntityTypeBuilder<eClinicalReferralInfo> builder)
        {
            builder.HasKey(cli => cli.Id);

            builder.Property(cli => cli.ClinicalSupportService)
                .IsRequired();

            builder.Property(cli => cli.AccessedSMBefore)
                .IsRequired();

            builder.Property(cli => cli.SMBeforeWhen)
                .HasColumnType("varchar(50)");

            builder.Property(cli => cli.HasMentalHealthDiag)
                .IsRequired();
 
            builder.Property(cli => cli.AccessedCurrentlyOtherService)
                .IsRequired();

            builder.Property(cli => cli.AccessingService)
               .IsRequired();

            builder.Property(cli => cli.AccessingServiceWorkName)
             .HasColumnType("varchar(100)");

            builder.Property(cli => cli.AccessingServiceWorkService)
             .HasColumnType("varchar(100)");

            builder.Property(cli => cli.AccessingServiceWorkTel)
             .HasColumnType("varchar(100)");

            // Relation
            builder.HasMany(cli => cli.OtherServices)
                    .WithOne(os => os.eClinicalReferralInfo)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
