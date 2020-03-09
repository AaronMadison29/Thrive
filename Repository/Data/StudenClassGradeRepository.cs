using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    class StudentClassGradesRepository : RepositoryBase<StudentClassGrade>, IStudentClassGradeRepository
    {
        public StudentClassGradesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateStudentClassGrade(StudentClassGrade scg)
        {
            Create(scg);
        }

        public StudentClassGrade GetStudentClassGrade(int id)
        {
            return FindByCondition(a => a.StudentClassGradeId == id).SingleOrDefault();
        }
        public StudentClassGrade GetStudentClassGradeIncludeAll(int id)
        {
            return FindByCondition(a => a.StudentClassGradeId == id).Include(b => b.Class).Include(c => c.Student).FirstOrDefault();
        }
        public List<StudentClassGrade> GetAllStudentClassGradesIncludeAll()
        {
            return FindAll().Include(a => a.Class).Include(b => b.Student).ToList();
        }
    }
}
