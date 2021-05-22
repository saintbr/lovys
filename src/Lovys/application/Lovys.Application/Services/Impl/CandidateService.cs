using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Lovys.Application.Services.Impl
{
    public class CandidateService : ApplicationService<ICandidateModel>, ICandidateService
    {
        public CandidateService(ICandidateRepository repository) : base(repository)
        {
        }

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