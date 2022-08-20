using Microsoft.AspNetCore.Mvc;

namespace DotNetDev.Api;

[ApiController]
[Route("dnd")]
public class MyController : ControllerBase
{
    private readonly IMyService _myService;

    public MyController(IMyService myService)
    {
        _myService = myService;
    }
    
    [HttpGet]
    [Route("verbose")]
    public ActionResult DoSomething(string input)
    {
        var result = _myService.DoSomething(input);

        if(result != 0)
        {
            return Ok(result);
        }
        else
        {
            return BadRequest();
        }
    }
    
    [HttpGet]
    [Route("exception")]
    public ActionResult DoSomethingElse(string input)
    {
        var result = _myService.DoSomethingElse(input);

        return Ok(result);
    }
}