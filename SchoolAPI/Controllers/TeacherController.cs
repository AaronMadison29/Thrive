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
            return _repo.Teachers.FindAll().ToList();
        }

        // GET: api/Teacher/5
        public Teacher Get(int id)
        {
            return _repo.Teachers.FindByCondition(a => a.TeacherId == id).FirstOrDefault();
        }

        // POST: api/School
        [HttpPost]
        public void Post([FromBody] Teacher value)
        {
            var newTeacher = new Teacher
            {
                Classes = value.Classes,
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
            var teacher = _repo.Teachers.FindByCondition(a => a.TeacherId == id).FirstOrDefault();
            teacher.Classes = value.Classes;
            teacher.Email = value.Email;
            teacher.Name = value.Name;
            teacher.PhoneNumber = value.PhoneNumber;
            teacher.Subject = value.Subject;
            teacher.UserId = value.UserId;
            _repo.Save();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var teacher = _repo.Teachers.FindByCondition(a => a.TeacherId == id).FirstOrDefault();
            _repo.Teachers.Delete(teacher);
            _repo.Save();
        }
    }
}
