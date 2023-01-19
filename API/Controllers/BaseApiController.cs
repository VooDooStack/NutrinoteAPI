using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BaseApiController
    {
        // [APIController]
        // [Route("api/[controller]")]
        // public class BaseApiController : ControllerBase
        // {
        //     private IMediator _mediator;

        //     protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService(typeof(IMediator)) as IMediator;
        // }
    }
}