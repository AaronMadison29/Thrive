using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface ITeacherRepository : IRepositoryBase<Teacher>
    {
        public void CreateTeacher(Teacher teacher);
        public Teacher GetTeacher(int teacherId);
        public Teacher GetTeacherIncludeAll(int teacherId);
        public List<Teacher> GetAllTeachersIncludeAll();
    }
}
