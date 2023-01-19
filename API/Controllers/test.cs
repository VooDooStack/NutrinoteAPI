using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TestController : BaseApiController
    {
        [HttpGet]
        public Task<ActionResult> Get()
        {
            return Task.FromResult<ActionResult>(Ok("Hello World"));
        }
    }
}