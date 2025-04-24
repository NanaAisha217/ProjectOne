using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectOneDemoPipeline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Hello, baby! Deployment works!";
    }
}
