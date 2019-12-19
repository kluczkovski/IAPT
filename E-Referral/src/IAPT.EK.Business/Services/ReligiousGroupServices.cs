using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class ReligiousGroupServices : BaseServices, IReligiousGroupServices
    {
        private readonly INotify _notify;
        private readonly IReligiousGroupRepository _religiousGroupRep;


        public ReligiousGroupServices(INotify notify, IReligiousGroupRepository religiousGroupRep) :base(notify)
        {
            _religiousGroupRep = religiousGroupRep;
        }


        public async Task<IEnumerable<ReligiousGroup>> GetAllOrderByCode()
        {
            var listOfReligiousGroup = await _religiousGroupRep.GetAllAsync();
            return listOfReligiousGroup.OrderBy(rg => rg.Code);
        }


        public async Task<ReligiousGroup> GetById(Guid id)
        {
            var obj = await _religiousGroupRep.GetByIdAsync(id);
            return obj;
        }

        public async Task<bool> Add(ReligiousGroup religiousGroup)
        {
            if (!RunValidation(new ReligiousGroupValidation(), religiousGroup)) return false;

            try
            {
                await _religiousGroupRep.InsertEntityAsync(religiousGroup);
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
                await _religiousGroupRep.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }


        public async  Task<bool> Update(ReligiousGroup religiousGroup)
        {
            if (!RunValidation(new ReligiousGroupValidation(), religiousGroup)) return false;

            try
            {
                await _religiousGroupRep.UpdateEntityAsync(religiousGroup);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }


        public void Dispose()
        {
            _religiousGroupRep?.Dispose();
        }

      
    }
}
