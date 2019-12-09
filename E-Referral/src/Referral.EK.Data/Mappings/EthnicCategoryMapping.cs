using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Referral.EK.Business.Models;

namespace Referral.EK.Data.Mappings
{
    public class EthnicCategoryMapping : IEntityTypeConfiguration<EthnicCategory>
    {
        public EthnicCategoryMapping()
        {
        }

        public void Configure(EntityTypeBuilder<EthnicCategory> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasIndex(a => a.Code).IsUnique();

            builder.Property(a => a.Code)
                   .IsRequired()
                   .HasColumnType("varchar(5)");

            builder.Property(a => a.Description)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(a => a.Sequence)
                   .IsRequired()
                   .HasColumnType("int(5)");

        }
    }
}
