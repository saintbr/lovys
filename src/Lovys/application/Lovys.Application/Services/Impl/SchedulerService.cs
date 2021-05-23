using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Application.Services.Impl
{
    public class SchedulerService : ApplicationService<ISchedulerModel>, ISchedulerService
    {
        public SchedulerService(ISchedulerRepository repository) : base(repository)
        {
        }

        public override ISchedulerModel Get(int id)
        {
            throw new NotImplementedException();
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