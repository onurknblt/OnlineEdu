using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.WebUI.DTOs.BlogCategoryDTOs
{
    public class CreateBlogCategoryDto
    {
        [Required(ErrorMessage = "Kategori adı gereklidir")]
        [StringLength(50, ErrorMessage = "Kategori adı en fazla 50 karakter olabilir")]
        public string Name { get; set; }
    }
}
