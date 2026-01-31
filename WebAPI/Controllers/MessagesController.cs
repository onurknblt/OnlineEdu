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
    public class MessagesController(IGenericService<Message> _messageService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _messageService.TDelete(id);
            return Ok("Mesaj Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateAboutDto createMessageDto)
        {
            var createdMessages = _mapper.Map<Message>(createMessageDto);
            _messageService.TCreate(createdMessages);
            return Ok("Mesaj Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateMessageDto)
        {
            var updatedMessages = _mapper.Map<Message>(updateMessageDto);
            _messageService.TUpdate(updatedMessages);
            return Ok("Mesaj Alanı Güncellendi.");



        }
    }
}
