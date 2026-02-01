using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.DTO.DTOs.CourseCategoryDTOs
{
    public class CreateCourseCategoryDto
    {
        [Required(ErrorMessage = "Kategori adı gereklidir")]
        [StringLength(50, ErrorMessage = "Kategori adı en fazla 50 karakter olabilir")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "İkon gereklidir")]
        [Required(ErrorMessage = "İkon gereklidir")]
        [StringLength(100, ErrorMessage = "İkon en fazla 100 karakter olabilir")]
        public string Icon { get; set; }

        [Required(ErrorMessage = "Açıklama gereklidir")]
        [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olabilir")]
        public string Description { get; set; }

        public bool IsShown { get; set; }

    }
}
