using System.Collections.Generic;

namespace Lovys.Domain.Web.Response.Schedule
{
    public class ScheduleResponseCollection : List<ScheduleResponse>
    {
        public ScheduleResponseCollection(List<ScheduleResponse> data)
        {
            AddRange(data);
        }
    }
}