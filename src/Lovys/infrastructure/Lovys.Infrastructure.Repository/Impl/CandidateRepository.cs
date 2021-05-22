using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Infrastructure.Repository.Impl
{
    public class CandidateRepository : Repository<ICandidateModel>, ICandidateRepository
    {
        public override ICandidateModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public override ICandidateModel Get(Guid hash)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<ICandidateModel> Get()
        {
            throw new NotImplementedException();
        }
    }
}