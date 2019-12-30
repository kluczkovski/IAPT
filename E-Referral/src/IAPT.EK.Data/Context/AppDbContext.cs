using System;
using Microsoft.EntityFrameworkCore;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EthnicCategory> EthnicCategories { get; set; }
        public DbSet<ReligiousGroup> ReligiousGroups { get; set; }
        public DbSet<City> Cities { get; set; }


        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            // get all classes that have implmented the IEntityTypeConfiguration interface
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
