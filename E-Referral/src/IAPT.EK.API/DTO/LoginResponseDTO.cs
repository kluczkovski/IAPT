using System;
namespace IAPT.EK.API.DTO
{
    public class LoginResponseDTO
    {
        public string AccessToken { get; set; }

        public double ExpiresIn { get; set; }

        public UserTokenDTO UserToken { get; set; }


        public LoginResponseDTO()
        {
        }
    }
}
