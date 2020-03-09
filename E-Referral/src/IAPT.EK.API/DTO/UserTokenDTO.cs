using System;
using System.Collections.Generic;

namespace IAPT.EK.API.DTO
{
    public class UserTokenDTO
    {
        public string? Id { get; set; }

        public string Email { get; set; }

        public IEnumerable<ClaimDTO> Claims { get; set; }

        public UserTokenDTO()
        {
        }
    }
}
