using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.DTO.DTOs.SubscriberDTOs
{
    public class UpdateSubscriberDto
    {
        public int SubscriberId { get; set; }
        [Required(ErrorMessage = "Email gereklidir")]
        [StringLength(100, ErrorMessage = "Email en fazla 100 karakter olabilir")]
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
