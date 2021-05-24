using Lovys.Domain.Core.Models;
using Lovys.Domain.Web.Common;
using System;

namespace Lovys.Domain.Models.Interfaces
{
    public interface IAvailableSlotModel : IBaseModel
    {
        DayOfWeek DayOfWeek { get; set; }
        TimeInterval Begin { get; set; }
        TimeInterval End { get; set; }
    }
}