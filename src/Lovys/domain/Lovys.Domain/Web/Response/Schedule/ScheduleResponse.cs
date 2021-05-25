using System;

namespace Lovys.Domain.Web.Response.Schedule
{
    public class ScheduleResponse
    {
        public string Candidate { get; set; }
        public string Interviewer { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}