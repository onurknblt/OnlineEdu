using AutoMapper;
using OnlineEdu.DTO.DTOs.BannerDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();

        }
    }
}
