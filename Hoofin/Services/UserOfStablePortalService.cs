using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hoofin.Models.Database;
using Hoofin.Repositories;

namespace Hoofin.Services
{
    public class UserOfStablePortalService
    {
        public static void CreateUser(UserOfStablePortal user)
        {
            UserOfStablePortalRepository.CreateNewUserOfStablePortal(user);
        }
    }
}