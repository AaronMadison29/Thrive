using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    class ParentRepository : RepositoryBase<Parent>, IParentRepository
    {
        public ParentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }


        public Parent GetParent(int parentId) => FindByCondition(c => c.ParentId == parentId).SingleOrDefault();
        public void CreateParent(Parent parent) => Create(parent);
        public Parent GetParentIncludeAll(int parentId) => FindByCondition(c => c.ParentId == parentId).Include(c => c.Children).SingleOrDefault();
        public List<Parent> GetCustomersIncludeAll() => FindAll().Include(c => c.Children).ToList();
    }
}
