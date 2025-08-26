using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ProtectedController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProtectedData()
    {
        return Ok("This is protected data.");
    }
}
