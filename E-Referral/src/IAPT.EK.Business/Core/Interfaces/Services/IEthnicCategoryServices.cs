using System;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IEthnicCategoryServices : IDisposable
    {
        Task<bool> Add(EthnicCategory ethnicCategory);

        Task<bool> Update(EthnicCategory ethnicCategory);

        Task<bool> Remove(Guid id);

    }
}
