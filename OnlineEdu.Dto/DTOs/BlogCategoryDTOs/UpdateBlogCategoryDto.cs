using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.DTO.DTOs.BlogCategoryDTOs
{
    public class UpdateBlogCategoryDto
    {
        public int BlogCategoryId { get; set; }
        [Required(ErrorMessage = "Kategori adı gereklidir")]
        [StringLength(50, ErrorMessage = "Kategori adı en fazla 50 karakter olabilir")]
        public string Name { get; set; }
    }
}
