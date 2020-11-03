using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Data.Mappings
{
    public class GPPracticeMapping : IEntityTypeConfiguration<GPPractice>
    {

        public void Configure(EntityTypeBuilder<GPPractice> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.Code)
                  .IsUnique();

            builder.HasOne(gp => gp.CCGCode)
                    .WithMany(ccg => ccg.GPPractices)
                    .OnDelete(DeleteBehavior.SetNull);

            builder.Property(c => c.Code)
                    .IsRequired()
                    .HasColumnType("varchar(6)");

            builder.Property(c => c.Description)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

            builder.Property(c => c.PostCode)
                   .HasColumnType("varchar(8)");
        }
    }
}
