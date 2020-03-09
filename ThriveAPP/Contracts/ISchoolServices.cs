using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Models;

namespace ThriveAPP.Contracts
{
    public interface ISchoolServices
    {
        Task AddTeacherAsync(Teacher teacher);
        Task AddStudentAsync(Student student);
        Task AddParentAsync(Parent parent);
        Task<Teacher> GetTeacher(int id);
        Task<Teacher> GetTeacher(string userId);
        Task<Parent> GetParent(int id);
        Task<Parent> GetParent(string userId);
        Task<Student> GetStudent(string userId);
        Task<Student> GetStudent(int id);
        Task EditStudentProfile(int id, Profile profile);
    }
}
