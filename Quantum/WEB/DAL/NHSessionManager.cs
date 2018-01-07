using NHibernate;
using NHibernate.Context;

namespace WEB.DAL
{
    public class NHSessionManager
    {

        public static ISession GetSession()
        {
            try
            {
                if (!WebSessionContext.HasBind(NHSessionFactoryManager.GetSessionFactory()))
                {
                    WebSessionContext.Bind(NHSessionFactoryManager.GetSessionFactory().OpenSession());
                }
            }
            catch { }
            return NHSessionFactoryManager.GetSessionFactory().GetCurrentSession();
        }

        public static void CloseSession()
        {
            if (WebSessionContext.HasBind(NHSessionFactoryManager.GetSessionFactory()))
            {
                NHSessionFactoryManager.GetSessionFactory().GetCurrentSession().Close();
                WebSessionContext.Unbind(NHSessionFactoryManager.GetSessionFactory());
            }
        }
    }
}