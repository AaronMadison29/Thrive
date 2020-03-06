using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    class StudentClassGradesRepository : RepositoryBase<StudentClassGrade>, IStudentClassGrade
    {
        public StudentClassGradesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
