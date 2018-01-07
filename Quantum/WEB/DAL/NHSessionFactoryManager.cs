using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace WEB.DAL
{
    public class NHSessionFactoryManager
    {
        public static ISessionFactory _sessionFactory = null;
        private static object CreateLock = new object();

        public static ISessionFactory GetSessionFactory()
        {
            lock (CreateLock)
            {
                if (_sessionFactory == null)
                {
                    FluentConfiguration config = BuildConfiguration();
                    _sessionFactory = config.BuildSessionFactory();
                }
            }

            return _sessionFactory;
        }

        private static FluentConfiguration BuildConfiguration()
        {
            FluentConfiguration config = Fluently.Configure()
                .Database(
                    SQLiteConfiguration.Standard
                    .ConnectionString(
                        c => c.FromConnectionStringWithKey("ConQuantum")
                    )
                )
                .CurrentSessionContext<WebSessionContext>()
                .Mappings(x => x.FluentMappings.AddFromAssembly
                    (Assembly.Load("WEB")));

            config.ExposeConfiguration(
                c => new SchemaUpdate(c).Execute(true, true))
                .BuildConfiguration();

            return config;
        }
    }
}