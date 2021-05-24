using Lovys.Domain.Web.Common;
using System;

namespace Lovys.Domain.Web.Request
{
    public class AvailabilityRequest
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeInterval TimeBegin { get; set; }
        public TimeInterval TimeEnd { get; set; }
    }
}