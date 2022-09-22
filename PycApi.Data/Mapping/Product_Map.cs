using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace PycApi
{
    public class ProductMap : ClassMapping<Product>
    {
        public ProductMap()
        {

            Table("product");


            Id(c => c.Id, i =>
            {
                i.Column("id");
                i.Type(NHibernateUtil.Int64);
                i.UnsavedValue(0);
                i.Generator(Generators.Increment);
            });


            Property(c => c.ProductName, c =>
            {
                c.Column("productname");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(true);
            });


            Property(c => c.Explanation, c =>
            {
                c.Column("explanation");
                c.Type(NHibernateUtil.String);
                c.Length(500);
                c.NotNullable(true);
            });

            Property(c => c.Color, c =>
            {
                c.Column("color");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(true);
            });


            Property(c => c.Brand, c =>
            {
                c.Column("brand");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(true);
            });

            Property(c => c.IsSold, c =>
            {
                c.Column("issold");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(true);
            });

            Property(c => c.IsOfferable, c =>
            {
                c.Column("isofferable");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(true);
            });

            Property(c => c.Price, i =>
            {
                i.Column("price");
                i.Type(NHibernateUtil.Int64);
                i.NotNullable(true);
            });
            Property(c => c.Offer, i =>
            {
                i.Column("offers");
                i.Type(NHibernateUtil.Int64);
                i.NotNullable(true);
            });

            Property(c => c.ProductOwner, c =>
            {
                c.Column("productowner");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(true);
            });

            Property(c => c.OfferOwner, c =>
            {
                c.Column("offerowner");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(true);
            });

            Property(c => c.OfferStatus, c =>
            {
                c.Column("offerstatus");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(true);
            });


            Property(c => c.CategoryId, c =>
            {
                c.Column("categoryid");
                c.Type(NHibernateUtil.Int64);
                c.NotNullable(true);
            });
        }
    }
}
