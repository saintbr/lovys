using Lovys.Api.Core.Controllers;
using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models;
using Lovys.Domain.Web.Request;
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
        public async Task<IActionResult> PostAsync([FromBody] AvailabilityRequest request)
        {
            try
            {
                if (await Service.AddOrUpdateAvailability(request, new CandidateModel { ID = 1, Hash = Guid.NewGuid(), Name = "Joao" }))
                    return await Task.FromResult(new OkObjectResult(request));

                return await Task.FromResult(new BadRequestResult());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return await Task.FromResult(new StatusCodeResult(500));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync() 
        {
            try
            {
                return await Task.FromResult(new OkObjectResult(Service.Get(1)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return await Task.FromResult(new StatusCodeResult(500));
            }
        }
    }
}