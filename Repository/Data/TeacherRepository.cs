using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
