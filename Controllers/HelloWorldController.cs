using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet(Name = "GetHelloWorld")]
    public String Get()
    {
        return "Hello World !";
    }
}