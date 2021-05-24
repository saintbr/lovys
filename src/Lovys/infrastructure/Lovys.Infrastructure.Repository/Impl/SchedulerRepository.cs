using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Infrastructure.Repository.Impl
{
    public class SchedulerRepository : Repository<ISchedulerModel>, ISchedulerRepository
    {
        public override void Create(ISchedulerModel model)
        {
            throw new NotImplementedException();
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

        public override void Update(ISchedulerModel model)
        {
            throw new NotImplementedException();
        }
    }
}