using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {
        Student GetStudent(int studentId);
        void CreateStudent(Student student);
        List<Student> GetStudentsIncludeAll();
        Student GetStudentInclude(int studentId);
    }
}
