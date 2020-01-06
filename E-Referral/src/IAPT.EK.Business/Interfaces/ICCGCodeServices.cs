using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface ICCGCodeSerices : IDisposable
    {
        Task<IEnumerable<CCGCode>> GetAllOrderByDescription();

        Task<CCGCode> GetById(Guid id);

        Task<bool> HasAnyAsync(Guid id);

        Task<bool> Add(CCGCode ccgCode);

        Task<bool> Update(CCGCode ccgCode);

        Task<bool> Remove(Guid id);
    }
}
