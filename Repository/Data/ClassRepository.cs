using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    class ClassRepository : RepositoryBase<Class>, IClassRepository
    {
        public ClassRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
