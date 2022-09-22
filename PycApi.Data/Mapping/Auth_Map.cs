using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace PycApi
{
    public class AuthMap : ClassMapping<Auth>
    {
        public AuthMap()
        {

            Table("auth");


            Id(v => v.Id, i =>
            {
                i.Column("id");
                i.Type(NHibernateUtil.Int64);
                i.UnsavedValue(0);
            });


            Property(v => v.Mail, n =>
            {
                n.Column("mail");
                n.Type(NHibernateUtil.String);
                n.Length(50);
                n.NotNullable(true);
            });


     
        }
    }
}
