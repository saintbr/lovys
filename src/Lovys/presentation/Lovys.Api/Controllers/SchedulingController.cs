using Lovys.Api.Core.Controllers;
using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Web.Request.Schedule;
using Lovys.Domain.Web.Response.Schedule;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
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
                return await Task.FromResult(new ScheduleResponseCollection { new ScheduleResponse {  Schedules = new ScheduleInfo { } } });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}