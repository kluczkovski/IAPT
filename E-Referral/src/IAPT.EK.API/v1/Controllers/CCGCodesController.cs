using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IAPT.EK.API.Controllers;
using IAPT.EK.API.DTO;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using Microsoft.AspNetCore.Mvc;


namespace IAPT.EK.API.V1.Controllers
{
    [Route("api/[controller]")]
    public class CCGCodesController : MainController
    {
        private readonly ICCGCodeSerices _cServices;
        private readonly IMapper _mapper;
       

        public CCGCodesController(ICCGCodeSerices ccgCodeServices,
                                  IMapper mapper,
                                  INotify notify) :base (notify)
        {
            _cServices = ccgCodeServices;
            _mapper = mapper;
        }


        // GET: api/ccgcodes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CCGCodeDTO>>> GetAll()
        {
            var listOfCCGCodes = await _cServices.GetAllOrderByDescription();
            var listOfCCGCodesDTO = _mapper.Map<IEnumerable<CCGCodeDTO>>(listOfCCGCodes);

            return Ok(listOfCCGCodesDTO);
        }


        // GET api/ccgcodes/5
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CCGCodeDTO>> GetById(Guid id)
        {
            var ccgCode = await _cServices.GetById(id);
            if (ccgCode == null)
            {
                ModelState.AddModelError("", $"Not found CCG Code for {id}");
                return CustomResponse(ModelState);
            }

            var ccgCodeDTO = _mapper.Map<CCGCodeDTO>(ccgCode);

            return CustomResponse(ccgCodeDTO);
        }

        // POST api/cities
        [HttpPost]
        public async Task<ActionResult<CCGCodeDTO>> Add(CCGCodeDTO ccgCodeDTO)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var ccgCode = _mapper.Map<CCGCode>(ccgCodeDTO);
            try
            {
                await _cServices.Add(ccgCode);
                ccgCodeDTO.Id = ccgCode.Id;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(ccgCodeDTO);
        }

        // PUT api/ccgcodes/5
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<CCGCodeDTO>> Put(Guid id, CCGCodeDTO ccgCodeDTO)
        {
            if (id != ccgCodeDTO.Id)
            {
                ModelState.AddModelError("", "Id from header is not equal body's ID");
                return CustomResponse(ModelState);
            }

            //chech if exist
            if (!await _cServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found CCG Code for id: {id}");
                return CustomResponse(ModelState);
            }

            var ccgCode = _mapper.Map<CCGCode>(ccgCodeDTO);
            try
            {
                  await _cServices.Update(ccgCode);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(ccgCodeDTO);
        }

        // DELETE api/ccgcodes/5
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<CCGCodeDTO>>  Delete(Guid id)
        {
            if (!await _cServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found CCG Code for the id: {id}");
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
