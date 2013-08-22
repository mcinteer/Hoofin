using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hoofin.Models;
using Hoofin.Models.Database;
using Hoofin.Repositories;

namespace Hoofin.Services
{
    public static class StableUserService
    {

        public static void CreateNewStableUser(StableUser stableUser)
        {
            StableUserRepository.Add(stableUser);
        }
    }

    public interface IStableUserService
    {
        void CreateNewStableUser(RegisterModel model);
    }
}