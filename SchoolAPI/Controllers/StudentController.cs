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
            var student = _repo.Students.GetStudentByUserIdInclude(stringId);
            if(student != null)
            {
                student.Parent = _repo.Parents.GetStudentsParent(student.StudentId);
            }
            return student;
        }

        // GET: api/Teacher/5
        [HttpGet("{id:int}")]
        public Student Get(int id)
        {
            var student = _repo.Students.GetStudentInclude(id);
            student.Classes = _repo.StudentClassGrades.GetStudentClasses(id);
            return student;
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
                UserId = value.UserId
            };
            _repo.Profiles.CreateProfile(newStudent.Profile);
            _repo.Students.CreateStudent(newStudent);
            _repo.Save();
        }

        // PUT: api/School/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] Profile value)
        {
            var profile = _repo.Profiles.GetProfile(id);
            profile.FavoriteSubject = value.FavoriteSubject;
            profile.LearningStyle = value.LearningStyle;
            profile.Notes = value.Notes;
            _repo.Profiles.Update(profile);
            _repo.Save();
        }

        [HttpPut("{link}/{id:int}")]
        public void Put(int id, [FromBody] Student student)
        {
            var user = _repo.Students.GetStudent(student.StudentId);
            user.UserId = student.UserId;
            user.Email = student.Email;
            _repo.Students.Update(user);
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