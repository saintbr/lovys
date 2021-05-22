using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Infrastructure.Repository.Impl
{
    public class InterviewerRepository : Repository<IInterviewerModel>, IInterviewerRepository
    {
        public override IInterviewerModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public override IInterviewerModel Get(Guid hash)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<IInterviewerModel> Get()
        {
            throw new NotImplementedException();
        }
    }
}