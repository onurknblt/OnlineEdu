using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.WebUI.DTOs.BlogDTOs
{
    public class CreateBlogDto
    {
        [Required(ErrorMessage = "Başlık gereklidir")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "İçerik gereklidir")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Resim URL gereklidir")]
        public string ImageUrl { get; set; }

        public DateTime BlogDate { get; set; }

        [Required(ErrorMessage = "Blog kategorisi gereklidir")]
        public int BlogCategoryId { get; set; }
    }
}
