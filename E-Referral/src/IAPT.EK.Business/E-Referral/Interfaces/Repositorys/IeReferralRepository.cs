using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.EReferral.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IeReferralRepository : IRepository<eReferral>
    {
        Task<eReferral> GetReferralWithIncludes(Guid id);

        Task<IEnumerable<eReferral>> GetAllReferralWithIncludes();
    }
}
