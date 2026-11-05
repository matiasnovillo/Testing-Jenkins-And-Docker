using Microsoft.AspNetCore.Mvc;

namespace JenkinsBlazor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EndPointValuesController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return Content("Hola mundo, desde Jenkins", "text/plain; charset=utf-8");
    }

    [HttpGet("/health")]
    public IActionResult Health()
    {
        return Ok(new { status = "ok" });
    }

    [HttpGet("/suma/{a:int}/{b:int}")]
    public ActionResult<long> Suma(int a, int b)
    {
        return Ok((long)a + b);
    }
}
