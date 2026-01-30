using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.DTO.DTOs.CourseCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> _courseCategoryService, IMapper _mapper) : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseCategoryService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseCategoryService.TGetById(id);
            return Ok(value);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseCategoryService.TDelete(id);
            return Ok("Kurs Kategori Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateCourseCategoryDto createCourseCategoryDto)
        {
            var createdvalues = _mapper.Map<CourseCategory>(createCourseCategoryDto);
            _courseCategoryService.TCreate(createdvalues);
            return Ok("Kurs Kategori Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var updatedValues = _mapper.Map<CourseCategory>(updateCourseCategoryDto);
            _courseCategoryService.TUpdate(updatedValues);
            return Ok("Kurs Kategori Alanı Güncellendi.");

        }
    }
}
