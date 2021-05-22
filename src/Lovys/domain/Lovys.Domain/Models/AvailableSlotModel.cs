using Lovys.Domain.Core.Models;
using Lovys.Domain.Models.Interfaces;
using System;

namespace Lovys.Domain.Models
{
    public partial class AvailableSlotModel : BaseModel, IAvailableSlotModel
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public TimeSpan Range { get; set; }
    }
}