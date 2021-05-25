using Lovys.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lovys.Application.Services.Interfaces
{
    public interface IApplicationService<T> where T : IBaseModel
    {
        T Get(int id);
        T Get(Guid hash);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> filter);
    }
}