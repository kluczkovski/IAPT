using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAPT.EK.Business.EReferral.Models;
using IAPT.EK.Business.Interfaces;
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

        public async Task<eReferral> GetReferralWithIncludes(Guid id)
        {
         
            return await _dbSet.Where(eref => eref.Id == id)
                                .Include(ai => ai.eAgencyInformation)
                                .Include(cd => cd.eContactDetail)
                                .Include(div => div.eDiversity)
                                .Include(arm => arm.eArmedForce)
                                .Include(ltp => ltp.eLongTermPhysicalHealth)
                                .Include(risk => risk.eRiskIndicator)
                                .Include(cli => cli.EClinicalReferralInfo)
                                .Include(isva => isva.eIsvaReferralInfo)
                                .Include(sexual => sexual.eSexualOffence)
                                .Include(impact => impact.eCommonSurvivorImpact)
                                .SingleAsync();
        }

   
    }
}
