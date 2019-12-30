using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Data.Mappings
{
    public class CCGCodeMapping : IEntityTypeConfiguration<CCGCode>
    {
      
        public void Configure(EntityTypeBuilder<CCGCode> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.Code)
                  .IsUnique();

            builder.Property(c => c.Code)
                    .IsRequired()
                    .HasColumnType("varchar(5)");
          
            builder.Property(c => c.Description)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

            builder.Property(c => c.Hub)
                   .HasColumnType("varchar(5)");

            builder.HasData(
                    new CCGCode
                    {
                        Id = Guid.NewGuid(),
                        Code = "01G",
                        Description = "NHS Salford CCG",
                        Hub = "Q73"
                    },
                    new CCGCode
                    {
                        Id = Guid.NewGuid(),
                        Code = "01M",
                        Description = "NHS North Manchester CCG"
                    },
                    new CCGCode
                    {
                        Id = Guid.NewGuid(),
                        Code = "01N",
                        Description = "NHS North Manchester CCG",
                        Hub = "Q73"
                    },
                    new CCGCode
                    {
                        Id = Guid.NewGuid(),
                        Code = "12F",
                        Description = "NHS Wirral CCG",
                        Hub = "Q75"
                    }
                ); 
        }
    }
}
