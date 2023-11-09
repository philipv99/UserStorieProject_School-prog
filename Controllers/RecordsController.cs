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
        Records_repo _Repo;
        public RecordsController(Records_repo records_repo)
        {
            _Repo = records_repo;
        }
        

        // GET: api/<RecordsController>
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<List<Record_class>> Get()
        {
            return Ok(_Repo.Get());
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
