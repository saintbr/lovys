using Lovys.Domain.Core.Models;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Infrastructure.Repository.Impl
{
    public abstract class Repository<T> : IRepository<T> where T : IBaseModel
    {
        public abstract T Get(int id);
        public abstract T Get(Guid hash);
        public abstract IEnumerable<T> Get();
    }
}