using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IRepositoryWrapper
    {
        IClassRepository Classes { get; }
        ITeacherRepository Teachers { get; }
        IStudentRepository Students { get; }
        IParentRepository Parents { get; }
        IProfileRepository Profiles { get; }
        void Save();
    }
}
