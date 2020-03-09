using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Models;

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
            return _repo.Students.GetStudentsIncludeAll();
        }

        [HttpGet("{stringId}")]
        public Student Get(string stringId)
        {
            return _repo.Students.GetStudentByUserIdInclude(stringId);
        }

        // GET: api/Teacher/5
        [HttpGet("{id:int}")]
        public Student Get(int id)
        {
            return _repo.Students.GetStudentInclude(id);
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
                UserId = value.UserId,
                ParentId = value.ParentId
            };
            _repo.Profiles.CreateProfile(newStudent.Profile);
            _repo.Students.CreateStudent(newStudent);
            _repo.Save();
        }

        // PUT: api/School/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            var student = _repo.Students.GetStudent(id);
            student.Name = value.Name;
            student.Classes = value.Classes;
            student.Email = value.Email;
            student.ParentId = value.ParentId;
            student.ProfileId = value.ProfileId;
            student.UserId = value.UserId;
            _repo.Save();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _repo.Students.GetStudent(id);
            _repo.Students.Delete(student);
            _repo.Save();
        }
    }
}