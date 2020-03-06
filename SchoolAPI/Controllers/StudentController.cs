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
        public IEnumerable<Student> Get()
        {
            return _repo.Students.FindAll().ToList();
        }

        // GET: api/Teacher/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return _repo.Students.FindByCondition(a => a.StudentId == id).FirstOrDefault();
        }

        // POST: api/School
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            var newStudent = new Student
            {
                Classes = value.Classes,
                Email = value.Email,
                Name = value.Name,
                ParentId = value.ParentId,
                ProfileId = value.ProfileId,
                UserId = value.UserId
        };
            newStudent.Parent = _repo.Parents.FindByCondition(a => a.ParentId == newStudent.ParentId).FirstOrDefault();
            newStudent.Profile = _repo.Profiles.FindByCondition(a => a.ProfileId == newStudent.ProfileId).FirstOrDefault();
            _repo.Students.Create(newStudent);
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