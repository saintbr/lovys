using Lovys.Domain.Models;
using Lovys.Domain.Models.Interfaces;
using Lovys.Infrastructure.Common.IO;
using Lovys.Infrastructure.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Lovys.Infrastructure.Repository.Impl
{
    public class CandidateRepository : SchedulerRepository, ICandidateRepository
    {
        public override IEnumerable<ISchedulerModel> Get()
        {
            return JsonFileHelper.GetFile<CandidateModel>();
        }

        public override ISchedulerModel Get(int id)
        {
            return JsonFileHelper.GetFile<CandidateModel>().FirstOrDefault(c => c.ID.Equals(id));
        }

        public override ISchedulerModel Get(Guid hash)
        {
            return JsonFileHelper.GetFile<CandidateModel>().FirstOrDefault(c => c.Hash.Equals(hash));
        }

        public override IEnumerable<ISchedulerModel> Get(Expression<Func<ISchedulerModel, bool>> filter)
        {
            return Get().AsQueryable().Where(filter);            
        }

        public override void Create(ISchedulerModel model)
        {
            var candidates = JsonFileHelper.GetFile<CandidateModel>();
            candidates.Add((CandidateModel)model);
            var json = JsonConvert.SerializeObject(candidates, Formatting.Indented);
            JsonFileHelper.SaveJsonFile<CandidateModel>(json);
        }

        public override void Update(ISchedulerModel model)
        {
            var candidates = Get();
            foreach (var candidate in candidates)
            {
                if (candidate.ID.Equals(model.ID)) 
                {
                    candidate.AvailableSlots = model.AvailableSlots;
                    break;
                }
            }
            var json = JsonConvert.SerializeObject(candidates, Formatting.Indented);
            JsonFileHelper.SaveJsonFile<CandidateModel>(json);
        }
    }
}