using System;
using AutoMapper;
using ConnectivityChallenge.API.TranslateAPIService.Model;
using ConnectivityChallenge.BLL.Model;

namespace ConnectivityChallenge.BLL
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<TranslateResponse, TranslatedResponse>()
                .ForMember(dest => dest.Name, opt => opt.Ignore())
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Contents.Translated));
        }
    }
}
