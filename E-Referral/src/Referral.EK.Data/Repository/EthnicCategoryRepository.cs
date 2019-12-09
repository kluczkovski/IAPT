using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Referral.EK.Business.Interfaces;
using Referral.EK.Business.Models;
using Referral.EK.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Referral.EK.Data.Repository
{
    public class EthnicCategoryRepository :  Repository<EthnicCategory>, IEthnicCategoryRepository
    {

        public EthnicCategoryRepository(AppDbContext _context) : base(_context)
        {
        }

        public async Task<List<EthnicCategory>> GetListBySequence()
        {
            return await _context.EthnicCategories
                    .AsNoTracking()
                    .OrderBy(e => e.Sequence)
                    .ToListAsync();
        }
    }
}
