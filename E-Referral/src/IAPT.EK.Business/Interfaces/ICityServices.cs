using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.Interfaces
{
    public interface ICityServices : IDisposable
    {
        Task<IEnumerable<City>> GetAllOrderByName();

        Task<City> GetById(Guid id);

        Task<bool> HasAnyAsync(Guid id);

        Task<bool> Add(City city);

        Task<bool> Update(City city);

        Task<bool> Remove(Guid id);
    }
}
