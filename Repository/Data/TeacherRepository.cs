using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
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

        public Teacher GetTeacherByClassId(int classId) => FindByCondition(t => t.ClassId == classId).Include(c => c.Class).FirstOrDefault();

        public Teacher GetTeacherIncludeAll(int teacherId)
        {
            return FindByCondition(a => a.TeacherId.Equals(teacherId)).Include(b => b.Class).SingleOrDefault();
        }
        public List<Teacher> GetAllTeachersIncludeAll()
        {
            return FindAll().Include(c => c.Class).ToList();
        }

        public Teacher GetTeacherByUserIdInclude(string userId)
        {
            return FindByCondition(a => a.UserId == userId).Include(x => x.Class).FirstOrDefault();
        }
    }
}