using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.DTO.DTOs.SocialMediaDTOs
{
    public class CreateSocialMediaDto
    {
        public int Icon { get; set; }
        [Required(ErrorMessage = "Başlık gereklidir")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Url gereklidir")]
        [StringLength(500, ErrorMessage = "Url en fazla 500 karakter olabilir")]
        public string Url { get; set; }
    }
}
