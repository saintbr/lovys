using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Application.Services.Impl
{
    public class CandidateService : SchedulerService, ICandidateService
    {
        public CandidateService(ICandidateRepository repository) : base(repository)
        {
        }

        public override IEnumerable<ISchedulerModel> Get()
        {
            return base.Get();
        }

        public override ISchedulerModel Get(Guid hash)
        {
            return base.Get(hash);
        }

        public override ISchedulerModel Get(int id)
        {
            return base.Get(id);
        }
    }
}