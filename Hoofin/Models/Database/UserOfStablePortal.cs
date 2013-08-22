using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Hoofin.Models.Database
{
    public class UserOfStablePortal
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public int Active { get; set; }

        public int ForcePWChange { get; set; }
    }
}