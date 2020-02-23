using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TGWorkshopCase.Entities.Base;

namespace TGWorkshop.Services.Base
{
    public interface IBaseService<T> where T : BaseModel
    {
        bool Add(T item);
        bool Update(T item);
        T GetById(Guid id);
        bool Remove(T item);
        bool RemoveRange(Expression<Func<T, bool>> exp);
        List<T> GetAll();
        List<T> GetByDefault(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        bool Active(Guid id);
        int Save();
    }
}
