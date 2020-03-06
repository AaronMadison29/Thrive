using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    class ClassRepository : RepositoryBase<Class>, IClassRepository
    {
        public ClassRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Class GetClass(int classId) => FindByCondition(c => c.ClassId == classId).SingleOrDefault();
        public void CreateClass(Class newClass) => Create(newClass);
        public Class GetClassIncludeAll(int classId) => FindByCondition(c => c.ClassId == classId).Include(c => c.ClassTeacher).SingleOrDefault();
        public List<Class> GetClassesIncludeAll() => FindAll().Include(c => c.ClassTeacher).ToList();
    }
}
