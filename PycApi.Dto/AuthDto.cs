using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PycApi.Dto
{
    public class AuthDto
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Mail { get; set; }
    }
}
