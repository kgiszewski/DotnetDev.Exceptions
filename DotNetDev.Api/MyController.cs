using Microsoft.AspNetCore.Mvc;

namespace DotNetDev.Api;

[ApiController]
[Route("dnd")]
public class MyController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public ActionResult DoSomething()
    {
        return Ok();
    }
}