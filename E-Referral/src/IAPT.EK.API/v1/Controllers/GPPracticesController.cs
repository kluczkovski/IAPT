using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IAPT.EK.API.DTO;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.API.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace IAPT.EK.API.V1.Controllers
{
    [Route("api/[controller]")]
    public class GPPracticesController : MainController
    {
        private readonly IGPPracticeServices _gpServices;
        private readonly IMapper _mapper;
       

        public GPPracticesController(   IGPPracticeServices  gPPracticeServices,
                                        IMapper mapper,
                                        INotify notify) :base (notify)
        {
            _gpServices = gPPracticeServices;
            _mapper = mapper;
        }


        // GET: api/ccgcodes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GPPracticeDTO>>> GetAll()
        {
            var listOfCCGCodes = await _gpServices.GetAllGPPracticeAndCCGCodeOrderByCode();
            var listOfCCGCodesDTO = _mapper.Map<IEnumerable<GPPracticeDTO>>(listOfCCGCodes);

            return Ok(listOfCCGCodesDTO);
        }


        // GET api/ccgcodes/5
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<GPPracticeDTO>> GetById(Guid id)
        {
            var ccgCode = await _gpServices.GetById(id);
            if (ccgCode == null)
            {
                ModelState.AddModelError("", $"Not found CCG Code for {id}");
                return CustomResponse(ModelState);
            }

            var ccgCodeDTO = _mapper.Map<GPPracticeDTO>(ccgCode);

            return CustomResponse(ccgCodeDTO);
        }

        // POST api/cities
        [HttpPost]
        public async Task<ActionResult<GPPracticeDTO>> Add(GPPracticeDTO gpPracticeDTO)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var gpPractice = _mapper.Map<GPPractice>(gpPracticeDTO);
            try
            {
                await _gpServices.Add(gpPractice);
                gpPracticeDTO.Id = gpPractice.Id;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(gpPracticeDTO);
        }

        // PUT api/ccgcodes/5
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<GPPracticeDTO>> Put(Guid id, GPPracticeDTO gpPracticeDTO)
        {
            if (id != gpPracticeDTO.Id)
            {
                ModelState.AddModelError("", "Id from header is not equal body's ID");
                return CustomResponse(ModelState);
            }

            //chech if exist
            if (!await _gpServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found CCG Code for id: {id}");
                return CustomResponse(ModelState);
            }

            var gpPractice = _mapper.Map<GPPractice>(gpPracticeDTO);
            try
            {
                  await _gpServices.Update(gpPractice);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(gpPracticeDTO);
        }

        // DELETE api/ccgcodes/5
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<GPPracticeDTO>>  Delete(Guid id)
        {
            if (!await _gpServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found CCG Code for the id: {id}");
                return CustomResponse(ModelState);
            }

            try
            {
                await _gpServices.Remove(id);
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
