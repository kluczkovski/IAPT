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

        // Core Tables
        public DbSet<EthnicCategory> EthnicCategories { get; set; }
        public DbSet<ReligiousGroup> ReligiousGroups { get; set; }
        public DbSet<DisabilityCode> DisabilityCodes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CCGCode> CCGCodes { get; set; }
        public DbSet<GPPractice> GPPractices { get; set; }

        // Tables related to e-Referral
        public DbSet<eReferral> EReferrals { get; set; }
        public DbSet<eAgencyInformation> EAgencyInformations { get; set; }
        public DbSet<eContactDetail> EContactDetails { get; set; }
        public DbSet<eDiversity> EDiversities { get; set; }


        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            // get all classes that have implmented the IEntityTypeConfiguration interface
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
