using System;
namespace IAPT.EK.API.Configuration
{
    public class AppSettingsJWT
    {
        public string Secret { get; set; }

        public int HoursToExpired { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public AppSettingsJWT()
        {
        }
    }
}
