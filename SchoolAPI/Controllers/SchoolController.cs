using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public SchoolController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        // GET: api/School
        [HttpGet]
        [Route("api/")]
        public IEnumerable<string> GetTeachers()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/School/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/School
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/School/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
