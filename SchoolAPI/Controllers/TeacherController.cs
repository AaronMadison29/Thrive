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
    public class TeacherController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public TeacherController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        // GET: api/Teacher/
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _repo.Teachers.GetAllTeachersIncludeAll();
        }
        [HttpGet("{stringId}")]
        public Teacher Get(string stringId)
        {
            return _repo.Teachers.GetTeacherByUserIdInclude(stringId);
        }
        // GET: api/Teacher/5
        [HttpGet("{id:int}")]
        public Teacher Get(int id)
        {
            return _repo.Teachers.GetTeacher(id);
        }

        // POST: api/School
        [HttpPost]
        public void Post([FromBody] Teacher value)
        {
            var newTeacher = new Teacher
            {
                Class = value.Class,
                Email = value.Email,
                Name = value.Name,
                PhoneNumber = value.PhoneNumber,
                Subject = value.Subject,
                UserId = value.UserId
            };
            _repo.Teachers.Create(newTeacher);
            _repo.Save();

        }

        // PUT: api/School/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Teacher value)
        {
            var teacher = _repo.Teachers.GetTeacher(id);
            teacher.Class = value.Class;
            teacher.Email = value.Email;
            teacher.Name = value.Name;
            teacher.PhoneNumber = value.PhoneNumber;
            teacher.Subject = value.Subject;
            teacher.UserId = value.UserId;
            _repo.Teachers.Update(teacher);
            _repo.Save();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var teacher = _repo.Teachers.GetTeacher(id);
            _repo.Teachers.Delete(teacher);
            _repo.Save();
        }
    }
}
