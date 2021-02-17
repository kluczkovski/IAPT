using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using IAPT.EK.API.Controllers;
using IAPT.EK.API.DTO;
using IAPT.EK.Business.EReferral.Models;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wkhtmltopdf.NetCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IAPT.EK.API.V1.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class eReferralsController : MainController
    {
        private readonly IeReferralServices _referralServices;
        private readonly IGeneratePdf _generatePdf;
        private readonly IMapper _mapper;

        public eReferralsController(INotify noticy,
                                    IMapper mapper,
                                    IGeneratePdf generatePdf,
                                    IeReferralServices referralServices) : base(noticy)
        {
            _mapper = mapper;
            _generatePdf = generatePdf;
            _referralServices = referralServices;
        }


        [AllowAnonymous]
        [HttpGet]
        [Route("GetAllReferrals")]
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
        [HttpGet]
        [Route("pdfReferral/{id:guid}")]
        public async Task<IActionResult> ReferralPDF(Guid id)
        {
            var ereferral = await _referralServices.GetReferralWithIncludes(id);
            
            return  await _generatePdf.GetPdf("Views/Referral/Referral.cshtml", ereferral);
        }


        [AllowAnonymous]
        [HttpPost]
        [ActionName("Add")]
        public async Task<ActionResult<eReferralDTO>> Add (eReferralDTO _eReferralDTO)
        {
            // Pre-validation
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var ereferral = _mapper.Map<eReferral>(_eReferralDTO);
            var econtactDetail = _mapper.Map<eContactDetail>(_eReferralDTO.ContactDetail);
            var eagencyInformation = _mapper.Map<eAgencyInformation>(_eReferralDTO.AgencyInformation);
            var ediversity = _mapper.Map<eDiversity>(_eReferralDTO.DiversityDetail);
            var earmedForce = _mapper.Map<eArmedForce>(_eReferralDTO.ArmedForceDetail);
            var elongTermPhysicalHealth = _mapper.Map<eLongTermPhysicalHealth>(_eReferralDTO.LongTermPhysicalHealth);
            var eriskIndicator = _mapper.Map<eRiskIndicator>(_eReferralDTO.RiskIndicator);
            var eclinicalReferral = _mapper.Map<eClinicalReferralInfo>(_eReferralDTO.ClinicalReferral);
            var etreatments = _mapper.Map<IEnumerable<eTreatment>>(_eReferralDTO.ClinicalReferral?.ListOfServices);
            var eisvaReferral = _mapper.Map<eIsvaReferralInfo>(_eReferralDTO.IsvaReferral);
            var esexualOffence = _mapper.Map<eSexualOffence>(_eReferralDTO.ReferralInformation);
            var ecommonsurrvivorimpact = _mapper.Map<eCommonSurvivorImpact>(_eReferralDTO.CommonSurvivorImpact);
            var eservices = _mapper.Map<IEnumerable<eService>>(_eReferralDTO.CommonSurvivorImpact?.ListOfTreatments);
            var eoffences = _mapper.Map<IEnumerable<eOffence>>(_eReferralDTO.CommonSurvivorImpact?.ListOfOffences);
            var eprobationservices = _mapper.Map<IEnumerable<eProbationService>>(_eReferralDTO.CommonSurvivorImpact?.ListOfProbations);

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

                // Add eArmedForce
                ereferral.eArmedForce = earmedForce;

                // Add Long Term Physical Health
                ereferral.eLongTermPhysicalHealth = elongTermPhysicalHealth;

                // Add Risk Indicator
                ereferral.eRiskIndicator = eriskIndicator;

                // Add Clinical Referral for Treatments - Clinical Referral Info
                eclinicalReferral.OtherServices = etreatments;
                // Add Clinical Referral Info
                ereferral.EClinicalReferralInfo = eclinicalReferral;

                // Add ISVA Referral
                ereferral.eIsvaReferralInfo = eisvaReferral;

                // Add Sexual Offence
                ereferral.eSexualOffence = esexualOffence;

                // Add Services - Common Impact Survivor
                ecommonsurrvivorimpact.EServices = eservices;
                // Add Offences - Common Impact Surviros
                ecommonsurrvivorimpact.EOffences = eoffences;
                // Add Probation Services - Common Impact Survivors
                ecommonsurrvivorimpact.EProbationServices = eprobationservices;
                // Add Common Impact Survivor
                ereferral.eCommonSurvivorImpact = ecommonsurrvivorimpact;

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
