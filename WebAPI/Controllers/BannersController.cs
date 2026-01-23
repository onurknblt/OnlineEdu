using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.DTO.DTOs.BannerDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var banners = _bannerService.TGetList();
            return Ok(banners);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var banners = _bannerService.TGetById(id);
            return Ok(banners);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bannerService.TDelete(id);
            return Ok("Banner Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var createdBanners = _mapper.Map<Banner>(createBannerDto);
            _bannerService.TCreate(createdBanners);
            return Ok("Banner Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var updatedBanners = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(updatedBanners);
            return Ok("Banner Alanı Güncellendi.");

        }
    }
}
