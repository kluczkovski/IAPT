using System;
using Microsoft.EntityFrameworkCore;
using Referral.EK.Business.Models;

namespace Referral.EK.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EthnicCategory> EthnicCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            // get all classes that have implmented the IEntityTypeConfiguration interface
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
