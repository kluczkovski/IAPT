using System;
using IAPT.EK.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAPT.EK.Data.Mappings
{
    public class eContactDetailMapping: IEntityTypeConfiguration<eContactDetail>
    {
       
        public void Configure(EntityTypeBuilder<eContactDetail> builder)
        {
            builder.HasKey(cd => cd.Id);

            // NHS Number
            builder.Property(cd => cd.NHSNumber)
                    .HasColumnType("varchar(50)");

            // FirstName
            builder.Property(cd => cd.FirstName)
                   .IsRequired(true)
                   .HasColumnType("varchar(150)");

            // LastName
            builder.Property(cd => cd.LastName)
                   .IsRequired(true)
                   .HasColumnType("varchar(150)");

            // BirthDate
            builder.Property(cd => cd.BirthDay)
                   .IsRequired(true);

            // PostCode
            builder.Property(cd => cd.PostCode)
                    .IsRequired(true)
                    .HasColumnType("varchar(50)");

            // Address 1
            builder.Property(cd => cd.Address1)
                   .IsRequired(true)
                   .HasColumnType("varchar(100)");

            // Address 2
            builder.Property(cd => cd.Address2)
                   .HasColumnType("varchar(100)");

            // another City
            builder.Property(cd => cd.anotherCity)
                    .HasColumnType("varchar(100)");

            // Phone
            builder.Property(cd => cd.Phone)
                    .HasColumnType("varchar(50)");

            // Mobile
            builder.Property(cd => cd.Mobile)
                    .HasColumnType("varchar(50)");

            // Email
            builder.Property(cd => cd.Email)
                .HasColumnType("varchar(150)");

            // Method
            builder.Property(cd => cd.MethodsToContact)
                .HasColumnType("varchar(256)");


        }
    }
}
