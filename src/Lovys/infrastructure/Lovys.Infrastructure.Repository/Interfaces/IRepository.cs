using Lovys.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Lovys.Infrastructure.Repository.Interfaces
{
    public interface IRepository<T> where T : IBaseModel
    {
        T Get(int id);
        T Get(Guid hash);
        IEnumerable<T> Get();
        void Create(T model);
        void Update(T model);
    }
}