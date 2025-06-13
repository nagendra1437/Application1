using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        // GET: api/sample
        [HttpGet]
        public IActionResult Get()
        {
            var samples = new[] { "Sample 1", "Sample 2", "Sample 3" };
            return Ok(samples);
        }

        // GET: api/sample/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sample = $"Sample {id}";
            return Ok(sample);
        }

        // POST: api/sample
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            // Normally, you would save the value to a database
            return CreatedAtAction(nameof(Get), new { id = 1 }, value);
        }

        // PUT: api/sample/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            // Normally, you would update the value in a database
            return NoContent();
        }

        // DELETE: api/sample/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Normally, you would delete the value from a database
            return NoContent();
        }
    }
}