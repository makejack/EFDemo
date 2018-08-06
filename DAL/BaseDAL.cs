using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq.Expressions;

namespace DAL
{
    public class BaseDAL<T> where T : class, new()
    {
        private DbContext m_dbContext = DBContextFactory.Create();

        public void Add(T t)
        {
            m_dbContext.Set<T>().Add(t);

            SaveChanges();
        }

        public void Update(T t)
        {
            m_dbContext.Set<T>().AddOrUpdate<T>(t);

            SaveChanges();
        }

        public void Delete(T t)
        {
            m_dbContext.Set<T>().Remove(t);

            SaveChanges();

        }

        public IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda)
        {
            return m_dbContext.Set<T>().Where(whereLambda);
        }

        public bool SaveChanges()
        {
            return m_dbContext.SaveChanges() > 0;
        }
    }
}
