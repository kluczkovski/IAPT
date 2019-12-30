using System;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Data.Context;

namespace IAPT.EK.Data.Repository
{
    public class CCGCodeRepository : Repository<CCGCode>, ICCGCodeRepository
    {
        public CCGCodeRepository(AppDbContext appDbContext) : base (appDbContext)
        {
        }
    }
}
