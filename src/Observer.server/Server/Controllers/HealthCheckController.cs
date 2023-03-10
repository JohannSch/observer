using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class HealthCheckController : ControllerBase
{
    [HttpGet("ping")]
    public string Ping([FromQuery] string message = "pong") => message;

    [HttpGet("isAlive")]
    public bool IsAlive() => true;
}
