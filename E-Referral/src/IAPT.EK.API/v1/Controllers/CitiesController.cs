using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IAPT.EK.API.Controllers;
using IAPT.EK.API.DTO;
using IAPT.EK.API.Extensions;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace IAPT.EK.API.V1.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CitiesController : MainController
    {
        private readonly ICityServices _cServices;
        private readonly IMapper _mapper;

        public CitiesController(ICityServices cityServices,
                                    IMapper mapper,
                                    INotify notify) : base(notify)
        {
            _cServices = cityServices;
            _mapper = mapper;
        }


        // GET: api/cities
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDTO>>> GetAll()
        {
            var listOfCities = await _cServices.GetAllOrderByName();
            var listOfCitiesDTO = _mapper.Map<IEnumerable<CityDTO>>(listOfCities);

            return Ok(listOfCitiesDTO);
        }


        // GET api/cities/5
        [ClaimsAuthorize("City", "Consult")]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CityDTO>> GetById(Guid id)
        {
            var city = await _cServices.GetById(id);
            if (city == null)
            {
                ModelState.AddModelError("", $"Not found City Code for {id}");
                return CustomResponse(ModelState);
            }

            var cityDTO = _mapper.Map<CityDTO>(city);

            return CustomResponse(cityDTO);
        }

        // POST api/cities
        [ClaimsAuthorize("City", "Add")]
        [HttpPost]
        public async Task<ActionResult<CityDTO>> Add(CityDTO cityDTO)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var city = _mapper.Map<City>(cityDTO);
            try
            {
                await _cServices.Add(city);
                cityDTO.Id = city.Id;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(cityDTO);
        }

        // PUT api/cities/5
        [ClaimsAuthorize("City", "Update")]
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<CityDTO>> Update(Guid id, CityDTO cityDTO)
        {
            if (id != cityDTO.Id)
            {
                ModelState.AddModelError("", "Id from header is not equal body's ID");
                return CustomResponse(ModelState);
            }

            //chech if exist
            if (!await _cServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found City for id: {id}");
                return CustomResponse(ModelState);
            }

            var city = _mapper.Map<City>(cityDTO);
            try
            {
                await _cServices.Update(city);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(cityDTO);
        }

        // DELETE api/disabilitycodes/5
        [ClaimsAuthorize("City", "Delete")]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<CityDTO>> Delete(Guid id)
        {
            if (!await _cServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found City Code for the id: {id}");
                return CustomResponse(ModelState);
            }

            try
            {
                await _cServices.Remove(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return CustomResponse(ModelState);
            }

            return Ok();
        }
    }
}
