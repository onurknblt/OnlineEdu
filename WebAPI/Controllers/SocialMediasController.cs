using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.DTO.DTOs.SocialMediaDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IGenericService<SocialMedia> _socialMediaService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _socialMediaService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok("Sosyal Medya Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateSocialMediaDto createSocialMediaDto)
        {
            var createdSocialMedias = _mapper.Map<SocialMedia>(createSocialMediaDto);
            _socialMediaService.TCreate(createdSocialMedias);
            return Ok("Sosyal Medya Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var updatedSocialMedias = _mapper.Map<SocialMedia>(updateSocialMediaDto);
            _socialMediaService.TUpdate(updatedSocialMedias);
            return Ok("Sosyal Medya Alanı Güncellendi.");
        }
    }
}
