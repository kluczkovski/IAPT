using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IDisabilityCodeServices : IDisposable
    {
        Task<IEnumerable<DisabilityCode>> GetAllOrderByCode();

        Task<DisabilityCode> GetById(Guid id);

        Task<bool> HasAnyAsync(Guid id);

        Task<bool> Add(DisabilityCode religiousGroup);

        Task<bool> Update(DisabilityCode religiousGroup);

        Task<bool> Remove(Guid id);
    }
}
