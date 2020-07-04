using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            var sample = new { ID = 1, Name = "EgK" };
            return Ok(sample);
        }

    }
}
