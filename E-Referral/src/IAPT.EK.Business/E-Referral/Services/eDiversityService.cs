using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.EReferral.Interfaces.Repositorys;
using IAPT.EK.Business.EReferral.Interfaces.Services;
using IAPT.EK.Business.EReferral.Models.Validations;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Services;

namespace IAPT.EK.Business.EReferral.Services
{
    public class eDiversityService: BaseServices, IeDiversityService
    {
        private readonly IeDiversityRepository _diversityRespository;

        public eDiversityService(INotify notify, IeDiversityRepository diversityRespository)
            :base(notify)
        {
            _diversityRespository = diversityRespository;
        }

        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _diversityRespository.HasAnyAsync(id);
        }

        public async Task<eDiversity> GetById(Guid id)
        {
            return await _diversityRespository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<eDiversity>> GetAll()
        {
            return await _diversityRespository.GetAllAsync();
        }

        public async Task<bool> Add(eDiversity diversity)
        {
            if (RunValidation(new eDiversityValidation(), diversity)) return false;
            try
            {
                await _diversityRespository.InsertEntityAsync(diversity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
      
        public async Task<bool> Update(eDiversity diversity)
        {
            if (RunValidation(new eDiversityValidation(), diversity)) return false;
            try
            {
                await _diversityRespository.UpdateEntityAsync(diversity);
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
                await _diversityRespository.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
