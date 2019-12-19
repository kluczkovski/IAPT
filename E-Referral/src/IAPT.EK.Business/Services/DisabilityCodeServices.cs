using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class DisabilityCodeServices : BaseServices, IDisabilityCodeServices
    {
        private readonly IDisabilityCodeRepository _dcRepository;


        public DisabilityCodeServices(  INotify notify,
                                        IDisabilityCodeRepository disabilityCodeRepository) : base(notify)
        {
            _dcRepository = disabilityCodeRepository;
        }


        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _dcRepository.HasAnyAsync(id);
        }


        public async Task<DisabilityCode> GetById(Guid id)
        {
            return await _dcRepository.GetByIdAsync(id);
        }


        public async Task<IEnumerable<DisabilityCode>> GetAllOrderByCode()
        {
            var listOfDisabilityCodes = await _dcRepository.GetAllAsync();
            return listOfDisabilityCodes.OrderBy(dc => dc.Code);
        }


        public async Task<bool> Add(DisabilityCode religiousGroup)
        {
            if (!RunValidation(new DisabilityCodeValidation(), religiousGroup)) return false ;

            try
            {
                await _dcRepository.InsertEntityAsync(religiousGroup);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public async Task<bool> Update(DisabilityCode religiousGroup)
        {
            if (!RunValidation(new DisabilityCodeValidation(), religiousGroup)) return false;

            try
            {
                await _dcRepository.UpdateEntityAsync(religiousGroup);
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
                await _dcRepository.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

      
        public void Dispose()
        {
            _dcRepository?.Dispose();
        }
    }
}
