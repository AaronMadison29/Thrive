using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateTeacher(Teacher teacher)
        {
            Create(teacher);
        }

        public Teacher GetTeacher(int teacherId)
        {
            return FindByCondition(a => a.TeacherId == teacherId).FirstOrDefault();
        }

        public Teacher GetTeacherIncludeAll(int teacherId)
        {
            return FindByCondition(a => a.TeacherId.Equals(teacherId)).Include(b => b.Classes).SingleOrDefault();
        }
    }
}