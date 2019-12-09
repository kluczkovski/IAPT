using System;
using AutoMapper;
using Referral.EK.API.DTO;
using Referral.EK.Business.Models;

namespace Referral.EK.API.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<EthnicCategory, EthnicCategoryDTO>().ReverseMap();
        }
    }
}
