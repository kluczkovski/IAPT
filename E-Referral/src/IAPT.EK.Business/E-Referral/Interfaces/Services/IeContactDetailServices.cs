using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IeContactDetailServices: IDisposable
    {
        Task<eContactDetail> GetById(Guid id);

        Task<IEnumerable<eContactDetail>> GetAll();

        Task<bool> HasAnyAsync(Guid id);

        Task<bool> Add(eContactDetail contactDetail);

        Task<bool> Update(eContactDetail contactDetail);

        Task<bool> Remove(Guid id);
    }
}
