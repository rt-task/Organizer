using Microsoft.AspNetCore.Mvc;
using Shared.Helpers;

namespace Notes.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class HealthCheckController : ControllerBase
{
    private readonly ILogger<HealthCheckController> _logger;

    public HealthCheckController(ILogger<HealthCheckController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult HealthCheck()
    {
        try
        {
            return Ok();
        }
        catch(Exception ex)
        {
            _logger.StandardLog(LogLevel.Critical, ex);
            throw;
        }
    }

}