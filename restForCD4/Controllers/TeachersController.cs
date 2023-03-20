using Microsoft.AspNetCore.Mvc;
using restForCD4.Models;
using restForCD4.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace restForCD4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly TeachersRepository repo = new TeachersRepository();

        // GET: api/<TeachersController>
        [HttpGet()]
        public IEnumerable<Teacher> Get()
        {
            return repo.GetAll();
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TeachersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TeachersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
