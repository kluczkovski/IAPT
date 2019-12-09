using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Referral.EK.Business.Models;

namespace Referral.EK.Business.Interfaces
{
    public interface IEthnicCategoryRepository : IRepository<EthnicCategory>
    {
        Task<List<EthnicCategory>> GetListBySequence();
    }
}
