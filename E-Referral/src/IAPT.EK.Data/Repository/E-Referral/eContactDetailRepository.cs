using System;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Data.Context;

namespace IAPT.EK.Data.Repository
{
    public class eContactDetailRepository: Repository<eContactDetail>, IeContactDetailRespository
    {
        public eContactDetailRepository(AppDbContext appDBContext) : base(appDBContext)
        {
        }
    }
}

