using System;
using IAPT.EK.Business.EReferral.Models;
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

            builder.HasOne(eref => eref.eArmedForce)
                    .WithOne(af => af.EReferral)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(eref => eref.eLongTermPhysicalHealth)
                    .WithOne(lf => lf.eReferral)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(eref => eref.eRiskIndicator)
                    .WithOne(ri => ri.eReferral)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(eref => eref.EClinicalReferralInfo)
                    .WithOne(cli => cli.eReferral)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(eref => eref.eIsvaReferralInfo)
                    .WithOne(isva => isva.EReferral)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(eref => eref.eSexualOffence)
                    .WithOne(so => so.EReferral)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(eref => eref.eCommonSurvivorImpact)
                    .WithOne(csi => csi.eReferral)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
