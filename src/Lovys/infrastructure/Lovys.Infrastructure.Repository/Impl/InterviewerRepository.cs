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
    public class InterviewerRepository : SchedulerRepository, IInterviewerRepository
    {
        public override IEnumerable<ISchedulerModel> Get()
        {
            return JsonFileHelper.GetFile<InterviewerModel>();
        }

        public override ISchedulerModel Get(int id)
        {
            return JsonFileHelper.GetFile<InterviewerModel>().FirstOrDefault(c => c.ID.Equals(id));
        }

        public override ISchedulerModel Get(Guid hash)
        {
            return JsonFileHelper.GetFile<InterviewerModel>().FirstOrDefault(c => c.Hash.Equals(hash));
        }

        public override IEnumerable<ISchedulerModel> Get(Expression<Func<ISchedulerModel, bool>> filter)
        {
            return Get().AsQueryable().Where(filter);
        }

        public override void Create(ISchedulerModel model)
        {
            var interviewers = JsonFileHelper.GetFile<InterviewerModel>();
            interviewers.Add((InterviewerModel)model);
            var json = JsonConvert.SerializeObject(interviewers, Formatting.Indented);
            JsonFileHelper.SaveJsonFile<InterviewerModel>(json);
        }

        public override void Update(ISchedulerModel model)
        {
            var interviewers = Get();
            foreach (var interviewer in interviewers)
            {
                if (interviewer.ID.Equals(model.ID))
                {
                    interviewer.AvailableSlots = model.AvailableSlots;
                    break;
                }
            }
            var json = JsonConvert.SerializeObject(interviewers, Formatting.Indented);
            JsonFileHelper.SaveJsonFile<InterviewerModel>(json);
        }
    }
}