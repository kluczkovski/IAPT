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
    public class ReligiousGroupsController : MainController
    {
        private readonly IReligiousGroupServices _religGroupServ;
        private readonly IMapper _mapper;
       

        public ReligiousGroupsController(IReligiousGroupServices religiousGroupServices,
                                         IMapper mapper,
                                         INotify notify) :base (notify)
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

            return CustomResponse(religiousGroupDTO);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
