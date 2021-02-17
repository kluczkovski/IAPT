using IAPT.EK.Business.EReferral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings.EReferral
{
    public class eLongTermPhysicalHealthMapping : IEntityTypeConfiguration<eLongTermPhysicalHealth>
    {
 
        public void Configure(EntityTypeBuilder<eLongTermPhysicalHealth> builder)
        {
            builder.HasKey(lt => lt.Id);

            builder.Property(lt => lt.HasClientLTPH)
                .IsRequired()
                .HasColumnType("varchar(50)");

        }
    }
}
