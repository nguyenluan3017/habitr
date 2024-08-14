using Microsoft.AspNetCore.Mvc;

namespace Habitr.Controllers
{
    [ApiController]
    [Route("/home")]
    public class HomeController : ControllerBase
    {        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from MyController");
        }
    }
}