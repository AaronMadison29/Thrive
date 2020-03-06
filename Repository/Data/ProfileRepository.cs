using Repository.Contracts;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    class ProfileRepository : RepositoryBase<Profile>, IProfileRepository
    {
        public ProfileRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
