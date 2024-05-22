using Microsoft.AspNetCore.Mvc;

namespace MyApiApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Service is running");
        }
    }
}
