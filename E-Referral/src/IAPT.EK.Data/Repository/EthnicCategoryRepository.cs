using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IAPT.EK.Data.Repository
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
