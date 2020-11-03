using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class eDiversityServices: BaseServices, IeContactDetailServices
    {
        private readonly IeContactDetailRespository _eCDRep;

        public eDiversityServices(INotify notify,
                                      IeContactDetailRespository detailRespository) :base(notify)
        {
            _eCDRep = detailRespository;
        }

        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _eCDRep.HasAnyAsync(id);
        }

        public async Task<eContactDetail> GetById(Guid id)
        {
            return await _eCDRep.GetByIdAsync(id);
        }

        public async Task<IEnumerable<eContactDetail>> GetAll()
        {
            return await _eCDRep.GetAllAsync();
        }

        public async Task<bool> Add(eContactDetail contactDetail)
        {
            if (!RunValidation(new eContactDetailValidation(), contactDetail)) return false;

            try
            {
                await _eCDRep.InsertEntityAsync(contactDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public async Task<bool> Update(eContactDetail contactDetail)
        {
            if (!RunValidation(new eContactDetailValidation(), contactDetail)) return false;

            try
            {
                await _eCDRep.UpdateEntityAsync(contactDetail);
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
                await _eCDRep.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public void Dispose()
        {
            _eCDRep?.Dispose();
        }
      
    }
}
