using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IBLL
{
    public partial interface IBaseService<T> where T :class ,new()
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda);
    }
}
