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
    public class StudentClassGradesController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public StudentClassGradesController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IEnumerable<StudentClassGrade> Get()
        {
            return _repo.StudentClassGrades.FindAll().ToList();
        }
        [HttpGet("{id}", Name = "Get")]
        public StudentClassGrade Get(int id)
        {
            return _repo.StudentClassGrades.FindByCondition(a => a.StudentClassGradeId == id).FirstOrDefault();
        }
        // POST: api/School
        [HttpPost]
        public void Post([FromBody] StudentClassGrade value)
        {
            var newStudentClassGrade = new StudentClassGrade
            {
                StudentId = value.StudentId,
                ClassId = value.ClassId,
                Grade = value.Grade
            };
            newStudentClassGrade.Student = _repo.Students.FindByCondition(a => a.StudentId == newStudentClassGrade.StudentId).FirstOrDefault();
            newStudentClassGrade.Class = _repo.Classes.FindByCondition(a => a.ClassId == newStudentClassGrade.ClassId).FirstOrDefault();
            _repo.StudentClassGrades.Create(newStudentClassGrade);
            _repo.Save();
        }
        // PUT: api/School/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentClassGrade value)
        {
            var scg = _repo.StudentClassGrades.FindByCondition(a => a.StudentClassGradeId == id).FirstOrDefault();
            scg.Grade = value.Grade;
            _repo.Save();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var scg = _repo.StudentClassGrades.FindByCondition(a => a.StudentClassGradeId == id).FirstOrDefault();
            _repo.StudentClassGrades.Delete(scg);
            _repo.Save();
        }
    }
}