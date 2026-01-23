using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.DTO.DTOs.BlogDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IGenericService<Blog> _blogService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var blogs = _blogService.TGetList();
            return Ok(blogs);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var blogs = _blogService.TGetById(id);
            return Ok(blogs);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogDto createBlogDto)
        {
            var createdBlogs = _mapper.Map<Blog>(createBlogDto);
            _blogService.TCreate(createdBlogs);
            return Ok("Blog Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogDto updateBlogDto)
        {
            var updatedBlogs = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(updatedBlogs);
            return Ok("Blog Alanı Güncellendi.");

        }
    }
}
