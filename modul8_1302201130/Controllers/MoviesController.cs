using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302201130.Controlloers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
