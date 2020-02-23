using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TGWorkshopCase.Context;
using TGWorkshopCase.Entities.Base;

namespace TGWorkshop.Services.Base
{
    public class BaseService<T> : IBaseService<T> where T : BaseModel
    {

        private TGWorkshopContext _context;
        public BaseService(TGWorkshopContext context)
        {
            this._context = context;
        }
        public bool Active(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> GetByDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRange(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
