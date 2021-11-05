using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace Test
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~Modelshibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var contactConfigFile = HttpContext.Current.Server.MapPath(@"~ModelsContact.hbm.xml");
            configuration.AddFile(contactConfigFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}