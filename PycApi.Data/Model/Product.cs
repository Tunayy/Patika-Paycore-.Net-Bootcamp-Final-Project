namespace PycApi
{
    public class Product
    {


        public virtual long Id { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string Explanation { get; set; }
        public virtual string Color { get; set; }
        public virtual string Brand { get; set; }
        public virtual string IsSold { get; set; }
        public virtual string IsOfferable { get; set; }
        public virtual long Price { get; set; }
        public virtual long Offer { get; set; }
        public virtual string ProductOwner { get; set; }
        public virtual string OfferOwner { get; set; }
        public virtual string OfferStatus { get; set; }
        public virtual long CategoryId { get; set; }



    }
      
}
