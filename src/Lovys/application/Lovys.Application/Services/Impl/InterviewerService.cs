using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Application.Services.Impl
{
    public class InterviewerService : ApplicationService<IInterviewerModel>, IInterviewerService
    {
        public InterviewerService(IInterviewerRepository repository) : base(repository)
        {
        }

        public override IInterviewerModel Get(int id)
        {
            return Repository.Get(id);
        }

        public override IInterviewerModel Get(Guid hash)
        {
            return Repository.Get(hash);
        }

        public override IEnumerable<IInterviewerModel> Get()
        {
            return Repository.Get();
        }
    }
}