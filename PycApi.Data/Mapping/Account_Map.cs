using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace PycApi
{
    public class AcoountMap : ClassMapping<Account>
    {
        public AcoountMap()
        {

            Table("account");


            Id(v => v.Id, i =>
            {
                i.Column("id");
                i.Type(NHibernateUtil.Int64);
                i.UnsavedValue(0);
            });


            Property(v => v.Email, n =>
            {
                n.Column("email");
                n.Type(NHibernateUtil.String);
                n.Length(50);
                n.NotNullable(true);
            });


            Property(v => v.Password, n =>
            {
                n.Column("password");
                n.Type(NHibernateUtil.String);
                n.Length(50);
                n.NotNullable(true);
            });

            Property(b => b.Role, x =>
            {
                x.Column("role");
                x.Length(50);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

            Property(b => b.LastActivity, x =>
            {
                x.Column("lastactivity");
                x.Type(NHibernateUtil.DateTime);
                x.NotNullable(true);
            });

        }
    }
}
