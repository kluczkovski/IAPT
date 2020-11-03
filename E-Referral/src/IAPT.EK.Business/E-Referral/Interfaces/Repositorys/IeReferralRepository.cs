using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IeReferralRepository : IRepository<eReferral>
    {
        Task<IEnumerable<eReferral>> GetAllReferralWithIncludes();
    }
}
