using Lovys.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lovys.Infrastructure.Repository.Interfaces
{
    public interface IRepository<T> where T : IBaseModel
    {
        T Get(int id);
        T Get(Guid hash);
        IEnumerable<T> Get();
        void Create(T model);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter);
        void Update(T model);
    }
}