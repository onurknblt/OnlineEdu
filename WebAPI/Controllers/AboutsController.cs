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
            var values = _aboutService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _aboutService.TDelete(id);
            return Ok("Hakkımızda Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            var createdAbouts = _mapper.Map<About>(createAboutDto);
            _aboutService.TCreate(createdAbouts);
            return Ok("Hakkımızda Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var updatedAbouts = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(updatedAbouts);
            return Ok("Hakkımızda Alanı Güncellendi.");



        }
    }
}
