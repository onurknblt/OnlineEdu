using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Mapping
{
    public class CourseMapping: Profile
    {
        public CourseMapping() 
        {
            CreateMap<CreateCourseDto, Course>().ReverseMap();
            CreateMap<UpdateCourseDto, Course>().ReverseMap();
            CreateMap<ResultCourseDto, Course>().ReverseMap();
        }
    }
}
