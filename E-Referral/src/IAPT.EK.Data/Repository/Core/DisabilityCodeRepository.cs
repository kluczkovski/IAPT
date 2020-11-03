using System;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Data.Context;

namespace IAPT.EK.Data.Repository
{
    public class DisabilityCodeRepository : Repository<DisabilityCode>, IDisabilityCodeRepository
    {
        public DisabilityCodeRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
