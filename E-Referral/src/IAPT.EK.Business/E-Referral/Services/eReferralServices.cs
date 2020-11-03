using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class eReferralServices : BaseServices, IeReferralServices
    {
        private readonly IeReferralRepository _ieRefRepository;

        public eReferralServices(INotify notify,
                                 IeReferralRepository referralRepository) : base(notify)
        {
            _ieRefRepository = referralRepository;
        }

        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _ieRefRepository.HasAnyAsync(id);
        }

        public async Task<eReferral> GetById(Guid id)
        {
            return await _ieRefRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<eReferral>> GetAll()
        {
            var listOfEReferral = await _ieRefRepository.GetAllAsync();
            return listOfEReferral;
        }


        public async Task<IEnumerable<eReferral>> GetAllReferralWithIncludes()
        {
            var listOfEReferral = await _ieRefRepository.GetAllReferralWithIncludes();
            return listOfEReferral;
        }

        public async Task<bool> Add(eReferral eReferral)
        {
            if (!RunValidation(new eReferralValidation(), eReferral)) return false;
            try
            {
                await _ieRefRepository.InsertEntityAsync(eReferral);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public async Task<bool> Update(eReferral eReferral)
        {
            if (!RunValidation(new eReferralValidation(), eReferral)) return false;
            try
            {
                await _ieRefRepository.UpdateEntityAsync(eReferral);
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
                await _ieRefRepository.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public void Dispose()
        {
            _ieRefRepository?.Dispose();
        }

    }
}
