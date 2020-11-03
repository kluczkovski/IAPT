using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IeReferralServices : IDisposable
    {
        Task<IEnumerable<eReferral>> GetAll();

        Task<IEnumerable<eReferral>> GetAllReferralWithIncludes();

        Task<eReferral> GetById(Guid id);

        Task<bool> HasAnyAsync(Guid id);

        Task<bool> Add(eReferral ereferral);

        Task<bool> Update(eReferral ereferral);

        Task<bool> Remove(Guid id);
    }
}
