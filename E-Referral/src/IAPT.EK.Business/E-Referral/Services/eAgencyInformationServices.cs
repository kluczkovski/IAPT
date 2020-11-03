using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class eAgencyInformationServices: BaseServices, IeAgencyInformationService
    {
        private readonly IeAgencyInformationRespository _eAgencyInfRep;

        public eAgencyInformationServices(INotify notify,
                                          IeAgencyInformationRespository ieAgency) :base (notify)
        {
            _eAgencyInfRep = ieAgency;
        }

        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _eAgencyInfRep.HasAnyAsync(id);
        }

        public async Task<eAgencyInformation> GetById(Guid id)
        {
            return await _eAgencyInfRep.GetByIdAsync(id);
        }

        public async Task<IEnumerable<eAgencyInformation>> GetAll()
        {
            return await _eAgencyInfRep.GetAllAsync();
        }

        public async Task<bool> Add(eAgencyInformation agencyInformation)
        {
            if (!RunValidation(new eAgencyInformationValidation(), agencyInformation)) return false;

            try
            {
                await _eAgencyInfRep.InsertEntityAsync(agencyInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public async Task<bool> Update(eAgencyInformation agencyInformation)
        {
            if (!RunValidation(new eAgencyInformationValidation(), agencyInformation)) return false;

            try
            {
                await _eAgencyInfRep.UpdateEntityAsync(agencyInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public async Task<bool> Remove(Guid id)
        {
            try
            {
                await _eAgencyInfRep.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public void Dispose()
        {
            _eAgencyInfRep?.Dispose();
        }
    }
}
