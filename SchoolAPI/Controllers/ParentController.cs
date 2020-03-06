using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public ParentController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        // GET: api/Teacher/
        [HttpGet]
        public IEnumerable<Parent> Get()
        {
            return _repo.Parents.FindAll().ToList();
        }

        // GET: api/Teacher/5
        [HttpGet("{id}")]
        public Parent Get(int id)
        {
            return _repo.Parents.FindByCondition(a => a.ParentId == id).FirstOrDefault();
        }

        // POST: api/School
        [HttpPost]
        public void Post([FromBody] Parent value)
        {
            var newParent = new Parent
            {
                Name = value.Name,
                Email = value.Email,
                Children = value.Children,
                UserId = value.UserId
            };
            _repo.Parents.Create(newParent);
            _repo.Save();
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
