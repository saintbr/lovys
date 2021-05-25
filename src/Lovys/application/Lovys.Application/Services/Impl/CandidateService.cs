using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models;
using Lovys.Domain.Models.Interfaces;
using Lovys.Domain.Web.Request;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Lovys.Application.Services.Impl
{
    public class CandidateService : SchedulerService, ICandidateService
    {
        public CandidateService(ICandidateRepository repository) : base(repository)
        {
        }

        public override async Task<bool> AddOrUpdateAvailability(AvailabilityRequest request, ISchedulerModel scheduler)
        {
            var candidate = Repository.Get(scheduler.ID);
            if (Equals(candidate, null))
            {
                Repository.Create(new CandidateModel
                {
                    ID = scheduler.ID,
                    Hash = Guid.NewGuid(),
                    Name = scheduler.Name,
                    AvailableSlots = new List<AvailableSlotModel>
                    {
                        new AvailableSlotModel
                        {
                            DayOfWeek = request.DayOfWeek,
                            Begin = request.TimeBegin,
                            End = request.TimeEnd
                        }
                    }
                });
            }
            else 
            {
                var slot = candidate.AvailableSlots.FirstOrDefault(a => a.DayOfWeek.Equals(request.DayOfWeek));
                if (Equals(slot, null))
                {
                    candidate.AvailableSlots.Add(new AvailableSlotModel { DayOfWeek = request.DayOfWeek, Begin = request.TimeBegin, End = request.TimeEnd, Hash = Guid.NewGuid(), ID = int.MinValue });
                }
                else 
                {
                    foreach (var slotModel in candidate.AvailableSlots)
                    {
                        if (slotModel.DayOfWeek.Equals(request.DayOfWeek)) 
                        {
                            slotModel.Begin = request.TimeBegin;
                            slotModel.End = request.TimeEnd;
                            break;
                        }
                    }
                }
                Repository.Update(candidate);
            }
            return await Task.FromResult(true);
        }

        public override IEnumerable<ISchedulerModel> Get(Expression<Func<ISchedulerModel, bool>> filter)
        {
            return Repository.Get(filter);
        }

        public override ISchedulerModel Get(int id)
        {
            return Repository.Get(id);
        }

        public override ISchedulerModel Get(Guid hash)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<ISchedulerModel> Get()
        {
            throw new NotImplementedException();
        }
    }
}