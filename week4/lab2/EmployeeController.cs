using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiLab2.Controllers 
{
    [ApiController]
    [Route("Emp")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Surendar", "Sanz", "Santhosh" };
        }
    }
}
