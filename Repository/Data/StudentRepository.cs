using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
