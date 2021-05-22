using Lovys.Domain.Core.Models;
using System;

namespace Lovys.Domain.Models.Interfaces
{
    public interface IAvailableSlotModel : IBaseModel
    {
        DayOfWeek DayOfWeek { get; set; }
        DateTime Begin { get; set; }
        DateTime End { get; set; }
        TimeSpan Range { get; set; }
    }
}