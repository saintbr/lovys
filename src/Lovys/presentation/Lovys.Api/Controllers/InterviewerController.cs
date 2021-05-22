using Lovys.Api.Core.Controllers;
using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models.Interfaces;
using Lovys.Domain.Web.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lovys.Api.Controllers
{
    [Route("api/v1/schedule/interviewer")]
    public class InterviewerController : BaseController<IInterviewerModel>
    {
        public InterviewerController(IInterviewerService service) : base(service)
        {
        }

        [HttpGet("{id}")]
        public async Task<IInterviewerModel> GetById(int id) => await Task.FromResult(Service.Get(id));

        [HttpGet("{hash}")]
        public async Task<IInterviewerModel> GetByHash(Guid hash) => await Task.FromResult(Service.Get(hash));

        [HttpGet()]
        public async Task<IEnumerable<IInterviewerModel>> GetAll() => await Task.FromResult(Service.Get());

        [HttpGet("availability")]
        public async Task<AvailabilityResponse> GetSchedule() => await Task.FromResult(new AvailabilityResponse
        {
            Interviewer = "Maria",
            AvailabilityIntervals = new AvailabilityInterval[]
            {
                new AvailabilityInterval
                {
                    DayOfWeek = DayOfWeek.Sunday,
                    Begin = DateTime.Parse("9:00 AM"),
                    End = DateTime.Parse("16:00 PM"),
                    Range = DateTime.Parse("16:00 PM").Subtract(DateTime.Parse("9:00 AM")).ToString()
                },
            }
        });
    }
}