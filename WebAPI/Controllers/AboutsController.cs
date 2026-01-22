using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IGenericService<About> _aboutService, IMapper _mapper) : ControllerBase
    {


        [HttpGet]
        public IActionResult Get()
        {
            var abouts = _aboutService.TGetList();
            return Ok(abouts);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var about = _aboutService.TGetById(id);
            return Ok(about);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _aboutService.TDelete(id);
            return Ok("Hakkımızda Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateAboutDTO createAboutDto)
        {
            var newValue = _mapper.Map<About>(createAboutDto);
            _aboutService.TCreate(newValue);
            return Ok("Hakkımızda Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var updatedValue = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(updatedValue);
            return Ok("Hakkımızda Alanı Güncellendi.");



        }
    }
}
