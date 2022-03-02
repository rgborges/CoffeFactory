using coffee.factory.httpserver.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coffee.factory.httpserver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PriceController : ControllerBase
    {
        private readonly ILogger<PriceController> _logger;

        public PriceController(ILogger<PriceController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetPrice")]
        public IActionResult Get()
        {
            return Ok("Hello WOrld");
        }


    }
}
