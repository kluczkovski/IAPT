using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IAPT.EK.Business.Models;


namespace IAPT.EK.Data.Mappings
{
    public class CityCodeMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasData(
                new City
                {
                    Id = Guid.NewGuid(),
                    Name = "Liverpool"
                },
                new City
                {
                    Id = Guid.NewGuid(),
                    Name = "Manchester"
                },
                new City
                {
                    Id = Guid.NewGuid(),
                    Name = "Salfor"
                },
                new City
                {
                    Id = Guid.NewGuid(),
                    Name = "York"
                },
                new City
                {
                    Id = Guid.NewGuid(),
                    Name = "Leeds"
                },
                new City
                {
                    Id = Guid.NewGuid(),
                    Name = "Chester"
                },
                new City
                {
                    Id = Guid.NewGuid(),
                    Name = "Oldhan"
                }

                ); 
        }
        
    }
}
