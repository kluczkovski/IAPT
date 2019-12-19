using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IAPT.EK.API.DTO;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using Microsoft.AspNetCore.Mvc;


namespace IAPT.EK.API.Controllers
{
    [Route("api/[controller]")]
    public class DisabilityCodesController : MainController
    {
        private readonly IDisabilityCodeServices _dcServices;
        private readonly IMapper _mapper;
       

        public DisabilityCodesController(IDisabilityCodeServices disabilityCodeServices,
                                         IMapper mapper,
                                         INotify notify) :base (notify)
        {
            _dcServices = disabilityCodeServices;
            _mapper = mapper;
        }


        // GET: api/disabilitycodes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisabilityCodeDTO>>> GetAll()
        {
            var listOfDisabilityCode = await _dcServices.GetAllOrderByCode();
            var listOfDisabilityCodeDTO = _mapper.Map<IEnumerable<DisabilityCodeDTO>>(listOfDisabilityCode);

            return Ok(listOfDisabilityCodeDTO);
        }


        // GET api/disabilitycodes/5
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<DisabilityCodeDTO>> GetById(Guid id)
        {
            var disabilityCode = await _dcServices.GetById(id);
            if (disabilityCode == null)
            {
                ModelState.AddModelError("", $"Not found Disability Code for {id}");
                return CustomResponse(ModelState);
            }

            var disabilityCodeDTO = _mapper.Map<DisabilityCodeDTO>(disabilityCode);

            return CustomResponse(disabilityCodeDTO);
        }

        // POST api/disabilitycodes
        [HttpPost]
        public async Task<ActionResult<DisabilityCodeDTO>> Add(DisabilityCodeDTO disabilityCodeDTO)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var disabilityCode = _mapper.Map<DisabilityCode>(disabilityCodeDTO);
            try
            {
                await _dcServices.Add(disabilityCode);
                disabilityCodeDTO.Id = disabilityCode.Id;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(disabilityCodeDTO);
        }

        // PUT api/disabilitycodes/5
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<DisabilityCodeDTO>> Put(Guid id, DisabilityCodeDTO disabilityCodeDTO)
        {
            if (id != disabilityCodeDTO.Id)
            {
                ModelState.AddModelError("", "Id from header is not equal body's ID");
                return CustomResponse(ModelState);
            }

            //chech if exist
            if (!await _dcServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found Disability Code for id: {id}");
                return CustomResponse(ModelState);
            }

            var disabilityCode = _mapper.Map<DisabilityCode>(disabilityCodeDTO);
            try
            {
                  await _dcServices.Update(disabilityCode);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(disabilityCodeDTO);
        }

        // DELETE api/disabilitycodes/5
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<DisabilityCodeDTO>>  Delete(Guid id)
        {
            if (!await _dcServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found Disability Code for the id: {id}");
                return CustomResponse(ModelState);
            }

            try
            {
                await _dcServices.Remove(id);
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
