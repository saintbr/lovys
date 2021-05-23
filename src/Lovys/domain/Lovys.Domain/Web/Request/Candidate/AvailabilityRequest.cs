using System;

namespace Lovys.Domain.Web.Request.Candidate
{
    public class AvailabilityRequest
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}