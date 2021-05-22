using Lovys.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Lovys.Application.Services.Interfaces
{
    public interface IApplicationService<T> where T : IBaseModel
    {
        T Get(int id);
        T Get(Guid hash);
        IEnumerable<T> Get();
    }
}