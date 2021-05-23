using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Infrastructure.Repository.Impl
{
    public class CandidateRepository : SchedulerRepository, ICandidateRepository
    {
        public override IEnumerable<ISchedulerModel> Get()
        {
            return base.Get();
        }

        public override ISchedulerModel Get(int id)
        {
            return base.Get(id);
        }

        public override ISchedulerModel Get(Guid hash)
        {
            return base.Get(hash);
        }
    }
}