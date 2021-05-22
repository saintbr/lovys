using System;

namespace Lovys.Domain.Core.Models
{
    public abstract class BaseModel : IBaseModel
    {
        public int ID { get; set; }
        public Guid Hash { get; set; }
    }
}