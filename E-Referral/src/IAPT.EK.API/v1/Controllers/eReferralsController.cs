using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IAPT.EK.API.Controllers;
using IAPT.EK.API.DTO;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IAPT.EK.API.V1.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class eReferralsController : MainController
    {
        private readonly IeReferralServices _referralServices;
        //private readonly IeAgencyInformationService _agencyInformation;
        //private readonly IeContactDetailServices _contactDetailServices;
        private readonly IMapper _mapper;

        public eReferralsController(INotify noticy,
                                    IMapper mapper,
                                    IeReferralServices referralServices) : base(noticy)
        {
            _mapper = mapper;
            _referralServices = referralServices;
            //_agencyInformation = ieAgencyInformation;
            //_contactDetailServices = contactDetailServices;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<eReferralDTO>>> List()
        {
            try
            {
                var listOfReferrals = await _referralServices.GetAllReferralWithIncludes();
                var listOfReferralsDTO = _mapper.Map<IEnumerable<eReferralReturnDTO>>(listOfReferrals);
                return Ok(listOfReferralsDTO);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return CustomResponse(ModelState);
            }
        }


        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<eReferralDTO>> Add (eReferralDTO _eReferralDTO)
        {
            // Pre-validation
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var ereferral = _mapper.Map<eReferral>(_eReferralDTO);
            var econtactDetail = _mapper.Map<eContactDetail>(_eReferralDTO.ContactDetail);
            var eagencyInformation = _mapper.Map<eAgencyInformation>(_eReferralDTO.AgencyInformation);
            var ediversity = _mapper.Map<eDiversity>(_eReferralDTO.DiversityDetail);

            try
            {
                // Add eAgencyInformation if there is
                if (!String.IsNullOrEmpty(_eReferralDTO.AgencyInformation.Agency))
                {
                    ereferral.eAgencyInformation = eagencyInformation;
                }
          
                // Add eContactDetail
                ereferral.eContactDetail = econtactDetail;

                // Add eDiversity
                ereferral.eDiversity = ediversity;

                // Add eReferral
                ereferral.Status = StatusEReferralEnum.Pending;
                await _referralServices.Add(ereferral);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return CustomResponse(ModelState);
            }

            return CustomResponse(_eReferralDTO);
        }


        // DELETE api/disabilitycodes/5
        //[ClaimsAuthorize("City", "Delete")]
        [AllowAnonymous]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<eReferralReturnDTO>> Delete(Guid id)
        {
            if (!await _referralServices.HasAnyAsync(id))
            {
                ModelState.AddModelError("", $"Not found Referral for the id: {id}");
                return CustomResponse(ModelState);
            }

            try
            {
                await _referralServices.Remove(id);
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
