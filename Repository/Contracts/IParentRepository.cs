using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IParentRepository : IRepositoryBase<Parent>
    {
        Class GetClass(int classId);
        void CreateClass(Class newClass);
        Class GetClassIncludeAll(int classId);
        List<Class> GetClassesIncludeAll();
    }
}
