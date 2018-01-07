using NHibernate;
using System.Collections.Generic;

namespace WEB.DAL.Repositorios
{
    public class BaseRepositorio<T> where T : class
    {
        protected ISession _session { get { return NHSessionManager.GetSession(); } }

        public void Save(T objeto)
        {
            ITransaction transacao = _session.BeginTransaction();

            try
            {
                _session.SaveOrUpdate(objeto);
                transacao.Commit();
            }
            catch
            {
                transacao.Rollback();
                throw;
            }
        }

        public void Delete(T objeto)
        {
            ITransaction transacao = _session.BeginTransaction();

            try
            {
                _session.Delete(objeto);
                transacao.Commit();
            }
            catch
            {
                transacao.Rollback();
                throw;
            }
        }

        public T GetById(int id)
        {
            ITransaction transacao = _session.BeginTransaction();
            T objeto = null;

            try
            {
                objeto = _session.Load<T>(id);
                transacao.Commit();
            }
            catch
            {
                transacao.Rollback();
                throw;
            }

            return objeto;
        }

        public IList<T> GetAll()
        {
            ITransaction transacao = _session.BeginTransaction();
            IList<T> listaObjetos = null;

            try
            {
                listaObjetos = _session.CreateCriteria<T>()
                    .List<T>();
                transacao.Commit();
            }
            catch
            {
                transacao.Rollback();
                throw;
            }

            return listaObjetos;
        }
    }
}