using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IEthnicCategoryRepository : IRepository<EthnicCategory>
    {
        Task<List<EthnicCategory>> GetListBySequence();
    }
}
