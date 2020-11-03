using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace IAPT.EK.Data.Repository
{
    public class GPPracticeRepository : Repository<GPPractice>, IGPPracticeRepository
    {
        public GPPracticeRepository(AppDbContext appDBContext) : base(appDBContext)
        {

        }

    
        public async Task<IEnumerable<GPPractice>> GetAllGPPracticeAndCCGCode()
        {
            return await _dbSet.Include(ccg => ccg.CCGCode)
                        .ToListAsync();
        }
    }
}
