using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.DTO.DTOs.AboutDTOs
{
    public class CreateAboutDto
    {

        [Required(ErrorMessage = "Açıklama gereklidir")]
        [StringLength(1000, ErrorMessage = "Açıklama en fazla 1000 karakter olabilir")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Resim URL 1 gereklidir")]
        [StringLength(500, ErrorMessage = "Resim URL 1 en fazla 500 karakter olabilir")]
        public string ImageUrl1 { get; set; }

        [Required(ErrorMessage = "Resim URL 2 gereklidir")]
        [StringLength(500, ErrorMessage = "Resim URL 2 en fazla 500 karakter olabilir")]
        public string ImageUrl2 { get; set; }

        [StringLength(200, ErrorMessage = "Madde 1 en fazla 200 karakter olabilir")]
        public string Item1 { get; set; }

        [StringLength(200, ErrorMessage = "Madde 2 en fazla 200 karakter olabilir")]
        public string Item2 { get; set; }

        [StringLength(200, ErrorMessage = "Madde 3 en fazla 200 karakter olabilir")]
        public string Item3 { get; set; }

        [StringLength(200, ErrorMessage = "Madde 4 en fazla 200 karakter olabilir")]
        public string Item4 { get; set; }
    }
}
