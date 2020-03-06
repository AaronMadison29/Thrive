using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IProfileRepository : IRepositoryBase<Profile>
    {
        Profile GetProfile(int profileId);
        void CreateProfile(Profile profile);
    }
}
