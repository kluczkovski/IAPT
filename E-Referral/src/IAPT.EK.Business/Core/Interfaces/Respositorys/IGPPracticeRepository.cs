using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IGPPracticeRepository : IRepository<GPPractice>
    {
        Task<IEnumerable<GPPractice>> GetAllGPPracticeAndCCGCode();
    }
}
