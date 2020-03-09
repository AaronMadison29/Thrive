using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
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
        public Parent GetParentIncludeAll(int parentId) => FindByCondition(c => c.ParentId == parentId).Include(c => c.Student).SingleOrDefault();
        public List<Parent> GetParentsIncludeAll() => FindAll().Include(c => c.Student).ToList();
        public Parent GetParentByUserIdInclude(string userId)
        {
            return FindByCondition(c => c.UserId == userId).Include(c => c.Student).SingleOrDefault();
        }
    }
}
