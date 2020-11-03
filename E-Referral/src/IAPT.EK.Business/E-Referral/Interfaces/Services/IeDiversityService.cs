using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Interfaces.Services
{
    public interface IeDiversityService: IDisposable
    {
        Task<bool> HasAnyAsync(Guid id);

        Task<eDiversity> GetById(Guid id);

        Task<IEnumerable<eDiversity>> GetAll();

        Task<bool> Add(eDiversity diversity);

        Task<bool> Update(eDiversity diversity);

        Task<bool> Remove(Guid id);
    }
}
