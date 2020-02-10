using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Transaction;
using GatoApi.Config;

namespace GatoApi.Daos
{
    /* fuente: https://federicoluciano.wordpress.com/2013/08/23/generic-dao-with-nhibernate-and-c-generics/ */
    
    public class GenericDao<T>
    {
        private ISession session = Util.CreateSessionFactory().OpenSession();

        public T GetById(int i)
        {
            try
            {
                return session.Load<T>(i);
            }
            catch
            {
                throw;
            }

        }

        public IList<T> GetAll()
        {
            {
                try
                {
                    return session.CreateCriteria(typeof(T)).List<T>();
                }
                catch
                {
                    throw;
                }
            }
        }

        public T Persist(T t)
        {
            using (ITransaction tr = session.BeginTransaction())
            {
                try
                {
                    session.Save(t);
                    tr.Commit();
                    return t;
                }
                catch
                {
                    tr.Rollback();
                    throw;
                }
            }

        }

        public void Delete(T t)
        {
            using (ITransaction tr = session.BeginTransaction())
            {
                try
                {
                    session.Delete(t);
                    tr.Commit();
                }
                catch
                {
                    tr.Rollback();
                    throw;
                }
            }

        }

        public T Update(T t)
        {
            using (ITransaction tr = session.BeginTransaction())
                try
                {
                    session.Update(t);
                    tr.Commit();
                    return t;
                }
                catch
                {
                    throw;
                }
        }
    }
}
