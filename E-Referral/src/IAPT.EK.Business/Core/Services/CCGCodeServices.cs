using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class CCGCodeServices : BaseServices, ICCGCodeSerices
    {
        private readonly ICCGCodeRepository _cRepository;


        public CCGCodeServices(  INotify notify,
                                 ICCGCodeRepository ccgRepository) : base(notify)
        {
            _cRepository = ccgRepository;
        }


        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _cRepository.HasAnyAsync(id);
        }


        public async Task<CCGCode> GetById(Guid id)
        {
            return await _cRepository.GetByIdAsync(id);
        }


        public async Task<IEnumerable<CCGCode>> GetAllOrderByDescription()
        {
            var listOfCCGCodes = await _cRepository.GetAllAsync();
            return listOfCCGCodes.OrderBy(dc => dc.Description);
        }


        public async Task<bool> Add(CCGCode ccgCode)
        {
            if (!RunValidation(new CCGCodeValidation(), ccgCode)) return false ;

            try
            {
                await _cRepository.InsertEntityAsync(ccgCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public async Task<bool> Update(CCGCode ccgCode)
        {
            if (!RunValidation(new CCGCodeValidation(), ccgCode)) return false;

            try
            {
                await _cRepository.UpdateEntityAsync(ccgCode);
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
                await _cRepository.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

      
        public void Dispose()
        {
            _cRepository?.Dispose();
        }

    }
}
