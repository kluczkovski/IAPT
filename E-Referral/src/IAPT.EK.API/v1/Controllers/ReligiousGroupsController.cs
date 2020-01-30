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
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ReligiousGroupsController : MainController
    {
        private readonly IReligiousGroupServices _religGroupServ;
        private readonly IMapper _mapper;


        public ReligiousGroupsController(IReligiousGroupServices religiousGroupServices,
                                         IMapper mapper,
                                         INotify notify) : base(notify)
        {
            _religGroupServ = religiousGroupServices;
            _mapper = mapper;
        }


        // GET: api/religiousgroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReligiousGroupDTO>>> GetAll()
        {
            var listOfReligiousGroups = await _religGroupServ.GetAllOrderByCode();
            var listOfReligiousGroupsDTO = _mapper.Map<IEnumerable<ReligiousGroupDTO>>(listOfReligiousGroups);

            return Ok(listOfReligiousGroupsDTO);
        }


        // GET api/religiousgroup/5
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ReligiousGroupDTO>> GetById(Guid id)
        {
            var religiousGroup = await _religGroupServ.GetById(id);
            if (religiousGroup == null)
            {
                ModelState.AddModelError("", $"Not found Religious Grupo for {id}");
                return CustomResponse(ModelState);
            }

            var religiousGroupDTO = _mapper.Map<ReligiousGroupDTO>(religiousGroup);

            return CustomResponse(religiousGroupDTO);
        }

        // POST api/religiousgroup
        [HttpPost]
        public async Task<ActionResult<ReligiousGroupDTO>> Add(ReligiousGroupDTO religiousGroupDTO)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var religiousGroup = _mapper.Map<ReligiousGroup>(religiousGroupDTO);
            try
            {
                await _religGroupServ.Add(religiousGroup);
                religiousGroupDTO.Id = religiousGroup.Id;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(religiousGroupDTO);
        }

        // PUT api/values/5
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ReligiousGroupDTO>> Put(Guid id, ReligiousGroupDTO religiousGroupDTO)
        {
            if (id != religiousGroupDTO.Id)
            {
                ModelState.AddModelError("", "Id from header is not equal body's ID");
                return CustomResponse(ModelState);
            }

            //chech if exist
            if (!await _religGroupServ.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found ReligiousGroup for id: {id}");
                return CustomResponse(ModelState);
            }

            var religiousGroup = _mapper.Map<ReligiousGroup>(religiousGroupDTO);
            try
            {
                await _religGroupServ.Update(religiousGroup);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return CustomResponse(ModelState);
            }
            return CustomResponse(religiousGroupDTO);
        }

        // DELETE api/values/5
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ReligiousGroupDTO>> Delete(Guid id)
        {
            if (!await _religGroupServ.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found ReligiousGroup for the id: {id}");
                return CustomResponse(ModelState);
            }

            try
            {
                await _religGroupServ.Remove(id);
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
