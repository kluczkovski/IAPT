using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using IAPT.EK.API.DTO;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IAPT.EK.API.Controllers
{
    [Route("api/[controller]")]
    public class EthnicCategoriesController : MainController
    {
        private readonly IEthnicCategoryRepository _ethnicCategoryRespository;
        private readonly IEthnicCategoryServices _ethnicCategoryServices;
        private readonly IMapper _mapper;

        public EthnicCategoriesController(IEthnicCategoryRepository ethnicCategoryRepository,
                                          IEthnicCategoryServices ethnicCategoryServices,
                                          IMapper mapper,
                                          INotify notify) : base(notify)
        {
            _ethnicCategoryRespository = ethnicCategoryRepository;
            _ethnicCategoryServices = ethnicCategoryServices;
            _mapper = mapper;
        }

        
        // GET: DataSet/EthnicCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EthnicCategoryDTO>>> GetAllEcthnics()
        {
            var ecthnics = await _ethnicCategoryRespository.GetListBySequence();
            var ecthnicsDTO = _mapper.Map<List<EthnicCategoryDTO>>(ecthnics);
            return Ok(ecthnicsDTO);
        }


        // GET api/EthnicCategories/5
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<EthnicCategoryDTO>> GetById(Guid id)
        {
            var ethnic = await _ethnicCategoryRespository.GetByIdAsync(id);
            if (ethnic == null)
            {
                ModelState.AddModelError("", $"Not found EthnicCategory for {id}");
                return CustomResponse(ModelState);
            }
           
            var ecthnicsDTO = _mapper.Map<EthnicCategoryDTO>(ethnic);
            return Ok(ecthnicsDTO);
        }


        // POST api/EthnicCategories
        [HttpPost]
        public async Task<ActionResult> Add(EthnicCategoryDTO ethnicCategoryDTO)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var ethnicCategory = _mapper.Map<EthnicCategory>(ethnicCategoryDTO);
            try
            {
                await _ethnicCategoryServices.Add(ethnicCategory);
                ethnicCategoryDTO.Id = ethnicCategory.Id;
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.InnerException.Message);
                return CustomResponse(ModelState);
            }

            return CustomResponse(ethnicCategoryDTO);
        }


        // PUT api/EthnicCategories/5
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<EthnicCategoryDTO>> Update(Guid id, EthnicCategoryDTO ethnicCategoryDTO)
        {
            if (ethnicCategoryDTO.Id != id)
            {
                ModelState.AddModelError("", $"Id from header is not equal body's ID.");
                return CustomResponse(ModelState);
            }

            //Check if exit record
            var HasAny = await _ethnicCategoryRespository.HasAnyAsync(id);
            if (!HasAny)
            {
                ModelState.AddModelError("", $"Not found EthnicCategory for id: {id}");
                return CustomResponse(ModelState);
            }

            var ethnicCategory = _mapper.Map<EthnicCategory>(ethnicCategoryDTO);
            try
            {
                await _ethnicCategoryServices.Update(ethnicCategory);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.InnerException != null ? e.InnerException.Message : e.Message);
                return CustomResponse(ModelState);
            }

            return CustomResponse(ethnicCategoryDTO);
        }


        // DELETE api/EthnicCategories/5
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<EthnicCategoryDTO>> Delete(Guid id)
        {
            var HasAny = await _ethnicCategoryRespository.HasAnyAsync(id);
            if (!HasAny)
            {
                ModelState.AddModelError("", $"Not found EthnicCategory for the id: {id}");
                return CustomResponse(ModelState);
            }

            try
            {
                await _ethnicCategoryServices.Remove(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.InnerException.Message);
                return CustomResponse(ModelState);
            }

            return Ok();
        }
    }
}
