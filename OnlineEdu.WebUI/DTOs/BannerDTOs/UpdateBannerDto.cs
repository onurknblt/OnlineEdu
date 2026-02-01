using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.WebUI.DTOs.BannerDTOs
{
    public class UpdateBannerDto
    {
        public int BannerId { get; set; }
        [Required(ErrorMessage = "Başlık gereklidir")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Resim URL gereklidir")]
        [StringLength(500, ErrorMessage = "Resim URL en fazla 500 karakter olabilir")]
        public string ImageUrl { get; set; }
    }
}
