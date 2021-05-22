using Lovys.Application.Services.Interfaces;
using Lovys.Domain.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lovys.Api.Core.Controllers
{
    [ApiController]
    public class BaseController<T> : ControllerBase where T : IBaseModel 
    {
        public IApplicationService<T> Service { get; set; }

        public BaseController(IApplicationService<T> service)
        {
            Service = service;
        }
    }
}