using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IStudentClassGradeRepository : IRepositoryBase<StudentClassGrade>
    {
        public void CreateStudentClassGrade(StudentClassGrade scg);
        public StudentClassGrade GetStudentClassGrade(int id);
        public StudentClassGrade GetStudentClassGradeIncludeAll(int id);
        public List<StudentClassGrade> GetAllStudentClassGradesIncludeAll();
    }
}
