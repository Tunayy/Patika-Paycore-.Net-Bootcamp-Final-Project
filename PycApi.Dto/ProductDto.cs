using System.ComponentModel.DataAnnotations;

namespace PycApi.Dto
{
    public class ProductDto    
    {

        
        [Required]
        public long Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string ProductName { get; set; }

        [Required]
        public string Explanation { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string IsSold { get; set; }
        [Required]
        public string IsOfferable { get; set; }

        [Required]
        public long Price { get; set; }

        [Required]
        public long Offer { get; set; }

        [Required]
        public string ProductOwner { get; set; }

        [Required]
        public string OfferOwner { get; set; }

        [Required]
        public string OfferStatus { get; set; }

        [Required]
        public long CategoryId { get; set; }

    }
}
