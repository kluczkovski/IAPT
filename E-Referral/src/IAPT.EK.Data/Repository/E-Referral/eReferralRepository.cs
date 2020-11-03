using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace IAPT.EK.Data.Repository
{
    public class eReferralRepository: Repository<eReferral>, IeReferralRepository
    {
        public eReferralRepository(AppDbContext appDBContext) : base(appDBContext)
        {
        }

        public async Task<IEnumerable<eReferral>> GetAllReferralWithIncludes()
        {
            return await _dbSet.Include(ai => ai.eAgencyInformation)
                                .Include(cd => cd.eContactDetail)
                                    .ThenInclude(cd1 => cd1.GpPractice)
                                        .ThenInclude(ccg => ccg.CCGCode)
                                .OrderByDescending(a => a.ReceivedDate)
                                .ToListAsync();
        }
     }
}
