using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace PycApi
{
    public class CategoryMap : ClassMapping<Category>
    {
        public CategoryMap()
        {

            Table("category");


            Id(v => v.Id, i =>
            {
                i.Column("id");
                i.Type(NHibernateUtil.Int64);
                i.UnsavedValue(0);
            });


            Property(v => v.CategoryName, n =>
            {
                n.Column("categoryname");
                n.Type(NHibernateUtil.String);
                n.Length(50);
                n.NotNullable(true);
            });


    
        }
    }
}
