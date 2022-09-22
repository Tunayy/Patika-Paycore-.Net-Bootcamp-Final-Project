using PycApi.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace PycApi.Dto
{
    public class AccountDto
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }


        [Display(Name = "Last Activity")]
        public DateTime LastActivity { get; set; }



    }
}
