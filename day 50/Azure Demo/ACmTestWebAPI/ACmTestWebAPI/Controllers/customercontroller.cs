using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ACmTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customercontroller : ControllerBase
    {
        // GET: api/<customercontroller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ram", "rahul" };
        }

        // GET api/<customercontroller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<customercontroller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<customercontroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<customercontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
