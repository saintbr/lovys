using System;

namespace Lovys.Domain.Web.Response.Schedule
{
    public class ScheduleInfo
    {
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public string Opportunity { get; set; }
        public string Interviewer { get; set; }
    }
}