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
    public class StudentController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public StudentController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        // GET: api/Teacher/
        [HttpGet]
        public IEnumerable<Student> GetTeachers()
        {
            return _repo.Students.FindAll().ToList();
        }

        // GET: api/Teacher/5
        [HttpGet("{id}", Name = "Get")]
        public Student GetTeacher(int id)
        {
            return _repo.Students.FindByCondition(a => a.StudentId == id).FirstOrDefault();
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