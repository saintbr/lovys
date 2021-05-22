using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Core.Models;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Application.Services.Impl
{
    public abstract class ApplicationService<T> : IApplicationService<T> where T : IBaseModel
    {
        public IRepository<T> Repository { get; set; }

        public ApplicationService(IRepository<T> repository)
        {
            Repository = repository;
        }

        public abstract T Get(int id);
        public abstract T Get(Guid hash);
        public abstract IEnumerable<T> Get();
    }
}