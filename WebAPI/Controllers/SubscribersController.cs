using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.DTO.DTOs.SubscriberDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _subscriberService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscriberService.TDelete(id);
            return Ok("Abonelik Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateSubscriberDto createSubscriberDto)
        {
            var createdSubscribers = _mapper.Map<Subscriber>(createSubscriberDto);
            _subscriberService.TCreate(createdSubscribers);
            return Ok("Abonelik Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateSubscriberDto updateSubscriberDto)
        {
            var updatedSubscribers = _mapper.Map<Subscriber>(updateSubscriberDto);
            _subscriberService.TUpdate(updatedSubscribers);
            return Ok("Abonelik Alanı Güncellendi.");
        }
    }
}
