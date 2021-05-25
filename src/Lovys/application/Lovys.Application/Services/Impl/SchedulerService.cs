using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models.Interfaces;
using Lovys.Domain.Web.Common;
using Lovys.Domain.Web.Request;
using Lovys.Domain.Web.Response.Schedule;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lovys.Application.Services.Impl
{
    public abstract class SchedulerService : ApplicationService<ISchedulerModel>, ISchedulerService
    {
        public SchedulerService(ISchedulerRepository repository) : base(repository)
        {
        }

        public abstract Task<bool> AddOrUpdateAvailability(AvailabilityRequest request, ISchedulerModel scheduler);

        public async Task<ScheduleResponseCollection> GetSchedulerAvailability(IEnumerable<ISchedulerModel> candidates, IEnumerable<ISchedulerModel> interviewers)
        {
            var ctr = ExtractTimeRanges(candidates).ToList();
            var itr = ExtractTimeRanges(interviewers).ToList();

            var computed = from c in ctr
                        join i in itr
                             on c.Item2 equals i.Item2
                        where c.Item3.Equals(i.Item3)
                        where c.Item4.Equals(i.Item4)
                        select new ScheduleResponse
                        {
                            Candidate = candidates.FirstOrDefault(cdt => cdt.ID.Equals(c.Item1)).Name,
                            Interviewer = interviewers.FirstOrDefault(itv => itv.ID.Equals(i.Item1)).Name,
                            DayOfWeek = c.Item2,
                            Begin = c.Item3,
                            End = c.Item4
                        };

            return await Task.FromResult(new ScheduleResponseCollection(computed.ToList()));
        }

        private IEnumerable<Tuple<int, DayOfWeek, DateTime, DateTime>> ExtractTimeRanges(IEnumerable<ISchedulerModel> schedulerModels)
        {
            foreach (var schedulerModel in schedulerModels)
            {
                foreach (var availableSlot in schedulerModel.AvailableSlots)
                {
                    var end = DateTime.Parse(availableSlot.End.ToString().Replace("T", ""));
                    var begin = DateTime.Parse(availableSlot.Begin.ToString().Replace("T", ""));
                    var diff = end.Subtract(begin);
                    for (int i = 0; i < diff.Hours; i++)
                    {
                        yield return new Tuple<int, DayOfWeek, DateTime, DateTime>(schedulerModel.ID, availableSlot.DayOfWeek, begin, begin.AddHours(1));
                        begin = begin.AddHours(1);
                    }
                }
            }
        }
    }
}