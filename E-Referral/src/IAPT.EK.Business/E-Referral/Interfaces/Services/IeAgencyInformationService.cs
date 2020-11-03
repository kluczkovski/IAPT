using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface IeAgencyInformationService: IDisposable
    {
        Task<eAgencyInformation> GetById(Guid id);

        Task<IEnumerable<eAgencyInformation>> GetAll();

        Task<bool> HasAnyAsync(Guid id);

        Task<bool> Add(eAgencyInformation agencyInformation);

        Task<bool> Update(eAgencyInformation agencyInformation);

        Task<bool> Remove(Guid id);
    }
}
