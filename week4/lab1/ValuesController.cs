using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiLab1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new List<string> { "surendar", "sanz" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(values);
        }

        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return Ok("Value added");
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string newValue)
        {
            if (id >= 0 && id < values.Count)
            {
                values[id] = newValue;
                return Ok("Value updated");
            }
            return BadRequest("Invalid ID");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id >= 0 && id < values.Count)
            {
                values.RemoveAt(id);
                return Ok("Value deleted");
            }
            return BadRequest("Invalid ID");
        }
    }
}
