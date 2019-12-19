using System;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Data.Context;

namespace IAPT.EK.Data.Repository
{
    public class ReligiousGroupRepository : Repository<ReligiousGroup>, IReligiousGroupRepository
    {
        public ReligiousGroupRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
