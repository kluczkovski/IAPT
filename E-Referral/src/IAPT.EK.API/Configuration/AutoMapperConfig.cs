using System;
using AutoMapper;
using IAPT.EK.API.DTO;
using IAPT.EK.Business.Models;

namespace IAPT.EK.API.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<EthnicCategory, EthnicCategoryDTO>().ReverseMap();
            CreateMap<ReligiousGroup, ReligiousGroupDTO>().ReverseMap();
            CreateMap<DisabilityCode, DisabilityCodeDTO>().ReverseMap();
        }
    }
}
