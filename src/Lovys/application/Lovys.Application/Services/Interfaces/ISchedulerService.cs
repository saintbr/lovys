using Lovys.Domain.Models.Interfaces;
using Lovys.Domain.Web.Request;
using System.Threading.Tasks;

namespace Lovys.Application.Services.Interfaces
{
    public interface ISchedulerService : IApplicationService<ISchedulerModel>
    {
        Task<bool> AddOrUpdateAvailability(AvailabilityRequest request, ISchedulerModel scheduler);
    }
}