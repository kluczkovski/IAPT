using System;
using System.Threading.Tasks;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class EthnicCategoryServices : BaseServices, IEthnicCategoryServices
    {
        private readonly IEthnicCategoryRepository _ethnicCategoryRepository;
    
        public EthnicCategoryServices(IEthnicCategoryRepository ethnicCategoryRepository,
                                      INotify notify) : base (notify)
        {
            _ethnicCategoryRepository = ethnicCategoryRepository;
        }


        public async Task<bool> Add(EthnicCategory ethnicCategory)
        {
            if (!RunValidation(new EthnicCategoryValidation(), ethnicCategory)) return false;

            try
            {
                await _ethnicCategoryRepository.InsertEntityAsync(ethnicCategory);
                return true;
         
            } catch (Exception e)

            {
                throw e;
            }
        }


        public async Task<bool> Remove(Guid id)
        {
            try
            {
                await _ethnicCategoryRepository.DeleteEntityAsync(id);
                return true;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public async Task<bool> Update(EthnicCategory ethnicCategory)
        {
            if (!RunValidation(new EthnicCategoryValidation(), ethnicCategory)) return false;

            try
            {
                await _ethnicCategoryRepository.UpdateEntityAsync(ethnicCategory);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void Dispose()
        {
            _ethnicCategoryRepository?.Dispose();
        }

    }
}
