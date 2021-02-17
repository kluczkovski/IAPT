using System;
using Microsoft.EntityFrameworkCore;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.EReferral.Models;

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
        public DbSet<eArmedForce> eArmedForces { get; set; }
        public DbSet<eLongTermPhysicalHealth> eLongTermPhysicalHealths { get; set; }
        public DbSet<eRiskIndicator> eRiskIndicators { get; set; }
        public DbSet<eClinicalReferralInfo> eClinicalReferralInfos { get; set; }
        public DbSet<eTreatment> eTreatments { get; set; }
        public DbSet<eIsvaReferralInfo> eIsvaReferralInfos { get; set; }
        public DbSet<eSexualOffence> eSexualOffences { get; set; }
        public DbSet<eService> eServices { get; set; }
        public DbSet<eOffence> eOffences { get; set; }
        public DbSet<eProbationService> eProbationServices { get; set; }
        public DbSet<eCommonSurvivorImpact> eCommonSurvivorImpacts { get; set; }

        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            // get all classes that have implmented the IEntityTypeConfiguration interface
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
