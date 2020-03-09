using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Student GetStudent(int studentId) => FindByCondition(s => s.StudentId == studentId).SingleOrDefault();
        public void CreateStudent(Student student) => Create(student);
        public List<Student> GetStudentsIncludeAll() => FindAll().Include(s => s.Parent).Include(s => s.Profile).ToList();
        public Student GetStudentInclude(int studentId)
        {
            return FindByCondition(a => a.StudentId == studentId).Include(a => a.Parent).Include(a => a.Profile).FirstOrDefault();
        }
    }
}
