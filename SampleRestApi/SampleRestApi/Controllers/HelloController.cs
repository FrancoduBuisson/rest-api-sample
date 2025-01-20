using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleRestApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HelloController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok(new { message = "Hello World!" });
    }
  }
}
