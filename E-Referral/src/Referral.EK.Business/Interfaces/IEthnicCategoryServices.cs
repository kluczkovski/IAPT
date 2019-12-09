using System;
using System.Threading.Tasks;
using Referral.EK.Business.Models;

namespace Referral.EK.Business.Interfaces
{
    public interface IEthnicCategoryServices : IDisposable
    {
        Task<bool> Add(EthnicCategory ethnicCategory);

        Task<bool> Update(EthnicCategory ethnicCategory);

        Task<bool> Remove(Guid id);


    }
}
