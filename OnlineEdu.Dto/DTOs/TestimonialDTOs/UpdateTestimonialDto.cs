using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.DTO.DTOs.TestimonialDTOs
{
    public class UpdateTestimonialDto
    {
        public int TestimonialId { get; set; }
        [Required(ErrorMessage = "Ad Soyad gereklidir")]
        [StringLength(100, ErrorMessage = "Ad Soyad en fazla 100 karakter olabilir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Unvan gereklidir")]
        [StringLength(100, ErrorMessage = "Unvan en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Resim URL gereklidir")]
        [StringLength(500, ErrorMessage = "Resim URL en fazla 500 karakter olabilir")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Yorum gereklidir")]
        [StringLength(1000, ErrorMessage = "Yorum en fazla 1000 karakter olabilir")]
        public string Comment { get; set; }
        public int Star { get; set; }
    }
}
