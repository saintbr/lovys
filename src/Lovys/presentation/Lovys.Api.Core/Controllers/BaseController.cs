using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lovys.Api.Core.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        public ILogger<BaseController> _logger { get; set; }

        public BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }
    }
}