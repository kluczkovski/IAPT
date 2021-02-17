using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Validations;
using IAPT.EK.Business.EReferral.Models.Validations;
using IAPT.EK.Business.EReferral.Models;

namespace IAPT.EK.Business.Services
{
    public class eReferralServices : BaseServices, IeReferralServices
    {
        private readonly IeReferralRepository _ieRefRepository;

        public eReferralServices(INotify notify,
                                 IeReferralRepository referralRepository) : base(notify)
        {
            _ieRefRepository = referralRepository;
        }

        public async Task<bool> HasAnyAsync(Guid id)
        {
            return await _ieRefRepository.HasAnyAsync(id);
        }

        public async Task<eReferral> GetById(Guid id)
        {
            return await _ieRefRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<eReferral>> GetAll()
        {
            var listOfEReferral = await _ieRefRepository.GetAllAsync();
            return listOfEReferral;
        }

        public async Task<eReferral> GetReferralWithIncludes(Guid id)
        {
            var ereferral = await _ieRefRepository.GetReferralWithIncludes(id);
            return ereferral;
        }

        public async Task<IEnumerable<eReferral>> GetAllReferralWithIncludes()
        {
            var listOfEReferral = await _ieRefRepository.GetAllReferralWithIncludes();
            return listOfEReferral;
        }

        public async Task<bool> Add(eReferral eReferral)
        {
            // Validation the aggregate
            bool checkResult = CheckAggregate(eReferral);
            if (checkResult == false) return false;

            if (!RunValidation(new eReferralValidation(), eReferral)) return false;
            try
            {
                await _ieRefRepository.InsertEntityAsync(eReferral);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }


        public async Task<bool> Update(eReferral eReferral)
        {
            if (!RunValidation(new eReferralValidation(), eReferral)) return false;
            try
            {
                await _ieRefRepository.UpdateEntityAsync(eReferral);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public async Task<bool> Remove(Guid id)
        {
            try
            {
                await _ieRefRepository.DeleteEntityAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public void Dispose()
        {
            _ieRefRepository?.Dispose();
        }


        private bool CheckAggregate(eReferral eReferral)
        {
            // Type of Referral
            if (eReferral.eAgencyInformation != null)
            {
                if (!RunValidation(new eAgencyInformationValidation(), eReferral.eAgencyInformation)) return false;
            }

            // Contact Detail
            if (!RunValidation(new eContactDetailValidation(), eReferral.eContactDetail)) return false;

            // Diversity Detail
            if (!RunValidation(new eDiversityValidation(), eReferral.eDiversity)) return false;

            // Armed Force
            if (!RunValidation(new eArmedForceValidation(), eReferral.eArmedForce)) return false;

            // Long Term Health Condition Indicator
            if (!RunValidation(new eLongTermPhysicalHealthValidation(), eReferral.eLongTermPhysicalHealth)) return false;

            // Risk Indicator
            if (!RunValidation(new eRiskIndicatorValidation(), eReferral.eRiskIndicator)) return false;

            // Clinical Referral
            if (!RunValidation(new eClinicalReferralInfoValidation(), eReferral.EClinicalReferralInfo)) return false;

            // ISVA Referral
            if (!RunValidation(new eIsvaReferralInfoValidation(), eReferral.eIsvaReferralInfo)) return false;

            // Referral Information
            if (!RunValidation(new eSexualOffenceValidation(), eReferral.eSexualOffence)) return false;

            // Common Survivor Impact Indicators
            if (!RunValidation(new eCommonSurviorImpactValidation(), eReferral.eCommonSurvivorImpact)) return false;

            return true;
        }

       
    }
}
