using AutoMapper;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.Entity.Entities;
using System.Runtime;

namespace OnlineEdu.WebAPI.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
