using System;

namespace Lovys.Domain.Core.Models
{
    public interface IBaseModel
    {
        int ID { get; set; }
        Guid Hash { get; set; }
    }
}