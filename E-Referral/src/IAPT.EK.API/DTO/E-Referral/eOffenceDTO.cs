using System;
namespace IAPT.EK.API.DTO.EReferral
{
    public class eOffenceDTO
    {
        public Guid ID { get; set; }

        public string Offence { get; set; }

        public string Conviction { get; set; }

        public string LengthOfSentence { get; set; }

        public string MonthYearSentence { get; set; }

        public eOffenceDTO()
        {
        }
    }
}
