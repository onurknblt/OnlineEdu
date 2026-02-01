using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.WebUI.DTOs.AboutDTOs
{
    public class CreateAboutDto
    {

        [Required(ErrorMessage = "Açıklama gereklidir")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Resim URL 1 gereklidir")]
        public string ImageUrl1 { get; set; }

        [Required(ErrorMessage = "Resim URL 2 gereklidir")]
        public string ImageUrl2 { get; set; }

        public string Item1 { get; set; }

        public string Item2 { get; set; }

        public string Item3 { get; set; }

        public string Item4 { get; set; }
    }
}
