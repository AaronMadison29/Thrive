using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IProfileRepository : IRepositoryBase<Profile>
    {
        Parent GetParent(int parentId);
        void CreateParent(Parent parent);
        Parent GetParentIncludeAll(int parentId);
        List<Parent> GetParentsIncludeAll();
    }
}
