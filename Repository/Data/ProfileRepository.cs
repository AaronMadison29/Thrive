using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    class ProfileRepository : RepositoryBase<Profile>, IProfileRepository
    {
        public ProfileRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Profile GetProfile(int profileId) => FindByCondition(p => p.ProfileId == profileId).SingleOrDefault();
        public void CreateProfile(Profile profile) => Create(profile);
    }
}
