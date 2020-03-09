using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Models;

namespace ThriveAPP.Contracts
{
    public interface ISchoolServices
    {
        Task AddTeacherAsync(Teacher teacher);
        Task AddStudentAsync(Student student);
        Task AddParentAsync(Parent parent);

    }
}
