using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IReligiousGroupServices : IDisposable
    {
        Task<IEnumerable<ReligiousGroup>> GetAllOrderByCode();

        Task<ReligiousGroup> GetById(Guid id);

        Task<bool> Add(ReligiousGroup religiousGroup);

        Task<bool> Update(ReligiousGroup religiousGroup);

        Task<bool> Remove(Guid id);

    }
}
