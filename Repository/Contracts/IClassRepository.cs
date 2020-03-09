using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IClassRepository : IRepositoryBase<Class>
    {
        Class GetClass(int classId);
        void CreateClass(Class newClass);
        Class GetClassIncludeAll(int classId);
        List<Class> GetClassesIncludeAll();
    }
}
