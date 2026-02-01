using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.WebUI.DTOs.CourseDTOs
{
    public class CreateCourseDto
    {
        [Required(ErrorMessage = "Kurs adı gereklidir")]
        [StringLength(50, ErrorMessage = "Kurs adı en fazla 50 karakter olabilir")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Resim URL gereklidir")]
        [StringLength(500, ErrorMessage = "Resim URL en fazla 500 karakter olabilir")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Kategori gereklidir")]
        public int CourseCategoryId { get; set; }

        [Required(ErrorMessage = "Fiyat gereklidir")]
        public decimal Price { get; set; }

        public bool IsShown { get; set; }
    }
}
