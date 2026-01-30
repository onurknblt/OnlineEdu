using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDTOs;
using OnlineEdu.DTO.DTOs.ContactDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IGenericService<Contact> _contactService, IMapper _mapper): ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.TDelete(id);
            return Ok("İletişim Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateContactDto createContactDto)
        {
            var createdContact = _mapper.Map<Contact>(createContactDto);
            _contactService.TCreate(createdContact);
            return Ok("İletişim Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateContactDto updateContactDto)
        {
            var updatedContact = _mapper.Map<Contact>(updateContactDto);
            _contactService.TUpdate(updatedContact);
            return Ok("İletişim Alanı Güncellendi.");

        }
    }
}
