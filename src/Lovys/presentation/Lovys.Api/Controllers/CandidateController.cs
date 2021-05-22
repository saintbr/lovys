using Lovys.Api.Core.Controllers;
using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lovys.Api.Controllers
{
    [Route("api/v1/schedule/candidate")]
    public class CandidateController : BaseController<ICandidateModel>
    {
        public CandidateController(ICandidateService service) : base(service)
        {
        }
    }
}