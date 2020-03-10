using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IParentRepository : IRepositoryBase<Parent>
    {
        Parent GetParent(int parentId);
        Parent GetStudentsParent(int studentId);
        void CreateParent(Parent parent);
        Parent GetParentIncludeAll(int classId);
        List<Parent> GetParentsIncludeAll();
        public Parent GetParentByUserIdInclude(string userId);
    }
}
