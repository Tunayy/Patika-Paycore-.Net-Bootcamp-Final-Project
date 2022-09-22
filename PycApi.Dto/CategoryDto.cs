using PycApi.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace PycApi.Dto
{
    public class CategoryDto
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string CategoryName { get; set; }

     



    }
}
