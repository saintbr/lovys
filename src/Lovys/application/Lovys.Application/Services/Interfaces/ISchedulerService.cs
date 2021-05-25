using Lovys.Domain.Models;
using Lovys.Domain.Models.Interfaces;
using Lovys.Domain.Web.Request;
using Lovys.Domain.Web.Response.Schedule;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lovys.Application.Services.Interfaces
{
    public interface ISchedulerService : IApplicationService<ISchedulerModel>
    {
        Task<bool> AddOrUpdateAvailability(AvailabilityRequest request, ISchedulerModel scheduler);

        Task<ScheduleResponseCollection> GetSchedulerAvailability(IEnumerable<ISchedulerModel> models1, IEnumerable<ISchedulerModel> models2);
    }
}