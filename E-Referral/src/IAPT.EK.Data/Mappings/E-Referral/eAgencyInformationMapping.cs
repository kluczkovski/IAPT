using System;
using IAPT.EK.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings
{
    public class eAgencyInformationMapping: IEntityTypeConfiguration<eAgencyInformation>
    {
      
        public void Configure(EntityTypeBuilder<eAgencyInformation> builder)
        {
            builder.HasKey(ai => ai.Id);

            builder.Property(ai => ai.Agency)
                    .IsRequired(true)
                    .HasColumnType("varchar(150)");

            builder.Property(ai => ai.ContactPerson)
                    .IsRequired(true)
                    .HasColumnType("varchar(150)");

            builder.Property(ai => ai.Phone)
                    .HasColumnType("varchar(50)");

            builder.Property(ai => ai.Email)
                    .HasColumnType("varchar(100)");

            builder.Property(ai => ai.AgencyHasClientConsent)
                    .IsRequired(true);


        }
    }
}
