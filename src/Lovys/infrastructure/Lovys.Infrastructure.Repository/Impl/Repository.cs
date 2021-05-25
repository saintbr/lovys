using Lovys.Domain.Core.Models;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lovys.Infrastructure.Repository.Impl
{
    public abstract class Repository<T> : IRepository<T> where T : IBaseModel
    {
        public abstract void Create(T model);
        public abstract T Get(int id);
        public abstract T Get(Guid hash);
        public abstract IEnumerable<T> Get();
        public abstract IEnumerable<T> Get(Expression<Func<T, bool>> filter);
        public abstract void Update(T model);
    }
}