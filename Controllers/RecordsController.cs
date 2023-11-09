using Microsoft.AspNetCore.Mvc;
using UserStorieProject_School_prog.Repo;
using UserStorieProject_School_prog.Records;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserStorieProject_School_prog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private Records_repo _repo;
        // GET: api/<RecordsController>
        [HttpGet]
        public List<Record_class> Get()
        {
            return _repo.Get();
        }

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return null;
        }

        // POST api/<RecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
