using Lovys.Api.Core.Controllers;
using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Web.Request.Candidate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Lovys.Api.Controllers
{
    [Route("api/candidate")]
    public class CandidateController : BaseController
    {
        public ICandidateService Service { get; set; }

        public CandidateController(ILogger<CandidateController> logger, ICandidateService service) : base(logger)
        {
            Service = service;
        }

        [HttpPost]
        public async Task Post([FromBody] AvailabilityRequest request)
        {
            try
            {
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}