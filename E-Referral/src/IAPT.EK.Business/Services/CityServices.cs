using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;

namespace IAPT.EK.Business.Services
{
    public class CityServices : BaseServices, ICityServices
    {
        private readonly ICityRepository _cRepository;


        public CityServices(  INotify notify,
                              ICityRepository cityRepository) : base(notify)
        {
            _cRepository = cityRepository;
        }


        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _cRepository.HasAnyAsync(id);
        }


        public async Task<City> GetById(Guid id)
        {
            return await _cRepository.GetByIdAsync(id);
        }


        public async Task<IEnumerable<City>> GetAllOrderByName()
        {
            var listOfCities = await _cRepository.GetAllAsync();
            return listOfCities.OrderBy(dc => dc.Name);
        }


        public async Task<bool> Add(City city)
        {
            if (!RunValidation(new CityValidation(), city)) return false ;

            try
            {
                await _cRepository.InsertEntityAsync(city);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        public async Task<bool> Update(City city)
        {
            if (!RunValidation(new CityValidation(), city)) return false;

            try
            {
                await _cRepository.UpdateEntityAsync(city);
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
