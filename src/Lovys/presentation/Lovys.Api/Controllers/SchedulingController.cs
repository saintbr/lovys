using Lovys.Api.Core.Controllers;
using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Web.Common;
using Lovys.Domain.Web.Request.Schedule;
using Lovys.Domain.Web.Response.Schedule;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lovys.Api.Controllers
{
    [Route("api/scheduling")]
    public class SchedulingController : BaseController
    {
        public IInterviewerService InterviewerService { get; set; }
        public ICandidateService CandidateService { get; set; }

        public SchedulingController(ILogger<SchedulingController> logger, ICandidateService candidateService, IInterviewerService interviewerService) : base(logger)
        {
            CandidateService = candidateService;
            InterviewerService = interviewerService;
        }

        [HttpPost("availability")]
        public async Task<ScheduleResponseCollection> CheckAvailability([FromBody] ScheduleRequest request) 
        {
            try
            {
                var candidates = CandidateService.Get(c => c.Name.Equals(request.Candidate));
                var interviewers = InterviewerService.Get(i => request.Interviewer.Contains(i.Name));
                return await Task.FromResult(await CandidateService.GetSchedulerAvailability(candidates, interviewers));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}