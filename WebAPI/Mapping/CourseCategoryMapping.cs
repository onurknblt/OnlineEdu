using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Mapping
{
    public class CourseCategoryMapping: Profile
    {
        public CourseCategoryMapping() 
        {
            CreateMap<CreateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDto, CourseCategory>().ReverseMap();
        }
        
    }
}
