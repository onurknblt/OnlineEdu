using AutoMapper;
using OnlineEdu.DTO.DTOs.BlogCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Mapping
{
    public class BlogCategoryMapping: Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<CreateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDto, BlogCategory>().ReverseMap();
        }
    }
}
