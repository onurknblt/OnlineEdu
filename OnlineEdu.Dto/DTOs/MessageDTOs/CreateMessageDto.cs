using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.DTO.DTOs.MessageDTOs
{
    public class CreateMessageDto
    {
        [Required(ErrorMessage = "Ad Soyad gereklidir")]
        [StringLength(100, ErrorMessage = "Ad Soyad en fazla 100 karakter olabilir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email gereklidir")]
        [StringLength(100, ErrorMessage = "Email en fazla 100 karakter olabilir")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Konu gereklidir")]
        [StringLength(100, ErrorMessage = "Konu en fazla 100 karakter olabilir")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Mesaj içeriği gereklidir")]
        [StringLength(1000, ErrorMessage = "Mesaj içeriği en fazla 1000 karakter olabilir")]
        public string Content { get; set; }
    }

}
