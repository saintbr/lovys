using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models.Interfaces;
using Lovys.Domain.Web.Request;
using Lovys.Infrastructure.Repository.Interfaces;
using System.Threading.Tasks;

namespace Lovys.Application.Services.Impl
{
    public abstract class SchedulerService : ApplicationService<ISchedulerModel>, ISchedulerService
    {
        public SchedulerService(ISchedulerRepository repository) : base(repository)
        {
        }

        public abstract Task<bool> AddOrUpdateAvailability(AvailabilityRequest request, ISchedulerModel scheduler);
    }
}