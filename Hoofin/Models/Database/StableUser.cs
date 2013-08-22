using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Hoofin.Models.Database
{
    public class StableUser
    {
        public int UserName { get; set; }

        public int StableID { get; set; }

        public DateTime InviteExpires { get; set; }

        public int Active { get; set; }
    }
}