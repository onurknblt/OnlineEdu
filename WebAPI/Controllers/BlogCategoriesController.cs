using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.DTO.DTOs.BlogCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(IGenericService<BlogCategory> _blogCategoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogCategoryService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _blogCategoryService.TGetById(id);
            return Ok(value);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogCategoryService.TDelete(id);
            return Ok("Blog Kategori Alanı Silindi.");
        }


        [HttpPost]
        public IActionResult Create(CreateBlogCategoryDto createBlogCategoryDto)
        {
            var createdBlogCategories = _mapper.Map<BlogCategory>(createBlogCategoryDto);
            _blogCategoryService.TCreate(createdBlogCategories);
            return Ok("Blog Kategori Alanı Oluşturuldu.");
        }


        [HttpPut]
        public IActionResult Update(UpdateBlogCategoryDto updateBlogCategoryDto)
        {
            var updatedBlogCategories = _mapper.Map<BlogCategory>(updateBlogCategoryDto);
            _blogCategoryService.TUpdate(updatedBlogCategories);
            return Ok("Blog Kategori Alanı Güncellendi.");

        }
    }
}
