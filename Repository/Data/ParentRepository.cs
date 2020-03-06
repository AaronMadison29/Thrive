using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    class ParentRepository : RepositoryBase<Parent>, IParentRepository
    {
        public ParentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
