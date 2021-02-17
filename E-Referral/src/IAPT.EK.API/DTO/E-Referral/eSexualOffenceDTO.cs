using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO.EReferral
{
    public class eSexualOffenceDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Referral Information.")]
        public string BriefSummary { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Referral Information.")]
        public string WhenWasIt { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Referral Information.")]
        public string[] OffenceType { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Referral Information.")]
        public string[] AgeAtTimeOfOffence { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Referral Information.")]
        public string[] WhatWasGenderOfPerpetror { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Referral Information.")]
        public string[] WhatWasRelationshipToPerpetror { get; set; }

        public eSexualOffenceDTO()
        {
        }
    }
}
