using System;
using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eIsvaReferralInfoMapping: IEntityTypeConfiguration<eIsvaReferralInfo>
    {

        public void Configure(EntityTypeBuilder<eIsvaReferralInfo> builder)
        {
            builder.HasKey(isva => isva.Id);

            builder.Property(isva => isva.IsvaReferralService)
                .IsRequired();

            builder.Property(isva => isva.CurrentlyReceivingSupport)
                .IsRequired();

            builder.Property(isva => isva.AttendSexualAssaultRefCenter)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(isva => isva.PoliceInvolved)
                .IsRequired();

            builder.Property(isva => isva.CurrentOpenInvestigation)
                .IsRequired();

            builder.Property(isva => isva.OfficerInChargeName)
                .HasColumnType("varchar(50)");

            builder.Property(isva => isva.OfficerInChargeService)
                .HasColumnType("varchar(50)");

            builder.Property(isva => isva.OfficerInChargeTel)
                .HasColumnType("varchar(50)");

            builder.Property(isva => isva.VictimSupportBeenContact)
                .IsRequired();

        }
    }
}
