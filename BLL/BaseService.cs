using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using IDAL;

namespace BLL
{
    public abstract partial class BaseService<T> where T : class, new()
    {
        public BaseService()
        {
            SetDal();
        }

        public IBaseDAL<T> Dal { get; set; }

        public abstract void SetDal();

        public void Add(T t)
        {
            Dal.Add(t);
        }

        public void Update(T t)
        {
            Dal.Update(t);
        }

        public void Delete(T t)
        {
            Dal.Delete(t);
        }

        public IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda)
        {
            return Dal.GetModels(whereLambda);
        }
    }
}
