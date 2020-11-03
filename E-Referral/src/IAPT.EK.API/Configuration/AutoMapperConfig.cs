using System;
using System.Linq;
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

            CreateMap<City, CityDTO>().ReverseMap();

            CreateMap<CCGCode, CCGCodeDTO>().ReverseMap();

            CreateMap<GPPractice, GPPracticeDTO>().ReverseMap();

            CreateMap<eReferral, eReferralDTO>().ReverseMap();

            CreateMap<eReferral, eReferralReturnDTO>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.eContactDetail.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.eContactDetail.LastName))
                .ForMember(dest => dest.BirthDay, opt => opt.MapFrom(src => src.eContactDetail.BirthDay))
                .ForMember(dest => dest.GPPracticeName, opt => opt.MapFrom(src => src.eContactDetail.GpPractice.Description))
                .ForMember(dest => dest.CCGCommissioner, opt => opt.MapFrom(src => src.eContactDetail.GpPractice.CCGCode.Description));

            CreateMap<eAgencyInformation, eAgencyInformationDTO>().ReverseMap();

            CreateMap<eContactDetail, eContactDetailDTO>().ReverseMap()
                .ForMember(dest => dest.MethodsToContact, opt => opt.MapFrom(src => String.Join(";",src.MethodsToContact)));

            CreateMap<eDiversity, eDiversityDTO>().ReverseMap()
                .ForMember(dest => dest.EthnicCategoryId, opt => opt.MapFrom(src => src.EthnicityId));
         
        }
    }
}
