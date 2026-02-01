using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.WebUI.DTOs.ContactDTOs
{
    public class CreateContactDto
    {
        [Required(ErrorMessage = "Harita URL gereklidir")]
        [StringLength(500, ErrorMessage = "Harita URL en fazla 500 karakter olabilir")]
        public string MapUrl { get; set; }

        [Required(ErrorMessage = "Adres gereklidir")]
        [StringLength(500, ErrorMessage = "Adres en fazla 500 karakter olabilir")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Telefon gereklidir")]
        [StringLength(20, ErrorMessage = "Telefon en fazla 20 karakter olabilir")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email gereklidir")]
        [StringLength(100, ErrorMessage = "Email en fazla 100 karakter olabilir")]
        public string Email { get; set; }
    }
}
