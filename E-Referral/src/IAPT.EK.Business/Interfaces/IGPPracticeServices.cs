using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IGPPracticeServices : IDisposable
    {
        Task<IEnumerable<GPPractice>> GetAllOrderByCode();

        Task<IEnumerable<GPPractice>> GetAllGPPracticeAndCCGCodeOrderByCode();

        Task<GPPractice> GetById(Guid id);

        Task<bool> HasAnyAsync(Guid id);

        Task<bool> Add(GPPractice gpPractice);

        Task<bool> Update(GPPractice gpPractice);

        Task<bool> Remove(Guid id);
    }
}
