using Microsoft.AspNetCore.Mvc;

namespace Simulate504.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WheatherForecastController : ControllerBase
    {
        private readonly ILogger<WheatherForecastController> _logger;
        public WheatherForecastController(ILogger<WheatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost("simulate-504")]
        public async Task<IActionResult> Simulate504Post()
        {
            int delaySeconds = 720;
            _logger.LogInformation($"Simulating a long request for {delaySeconds} seconds...");

            await Task.Delay(TimeSpan.FromSeconds(delaySeconds));

            return Ok("This should not been seen if 504 occurs.");
        }

    }
}