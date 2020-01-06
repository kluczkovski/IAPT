using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class GPPracticeServices : BaseServices, IGPPracticeServices
    {
        private readonly IGPPracticeRepository _gpRepository;


        public GPPracticeServices(  INotify notify,
                                    IGPPracticeRepository cgRepository) : base(notify)
        {
            _gpRepository = cgRepository;
        }


        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _gpRepository.HasAnyAsync(id);
        }


        public async Task<GPPractice> GetById(Guid id)
        {
            return await _gpRepository.GetByIdAsync(id);
        }


        public async Task<IEnumerable<GPPractice>> GetAllOrderByCode()
        {
            var listOfGpPractices = await _gpRepository.GetAllAsync();
            return listOfGpPractices.OrderBy(cg => cg.Code);
        }

        public async Task<IEnumerable<GPPractice>> GetAllGPPracticeAndCCGCodeOrderByCode()
        {
            var listOfGpPractices = await _gpRepository.GetAllGPPracticeAndCCGCode();
            return listOfGpPractices.OrderBy(cg => cg.Code);
        }

        public async Task<bool> Add(GPPractice gpPractice)
        {
            if (!RunValidation(new GPPracticeValidation(), gpPractice)) return false ;

            try
            {
                await _gpRepository.InsertEntityAsync(gpPractice);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public async Task<bool> Update(GPPractice gpPractice)
        {
            if (!RunValidation(new GPPracticeValidation(), gpPractice)) return false;

            try
            {
                await _gpRepository.UpdateEntityAsync(gpPractice);
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
                await _gpRepository.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

      
        public void Dispose()
        {
            _gpRepository?.Dispose();
        }
     
    }
}
