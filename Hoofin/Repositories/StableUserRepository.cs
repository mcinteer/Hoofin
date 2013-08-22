using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hoofin.Models.Database;
using MySql.Data.MySqlClient;

namespace Hoofin.Repositories
{
    public class StableUserRepository :BaseRepository
    {
        static public void CreateNewStableUser(StableUser stableUser)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("", Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("inp_User_ID", stableUser.UserName));
                command.Parameters.Add(new MySqlParameter("inp_Stable_ID", stableUser.StableID));
                command.Parameters.Add(new MySqlParameter("Invite_Expires", stableUser.InviteExpires));
                command.Parameters.Add(new MySqlParameter("Activate_Ind", stableUser.Active));

                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("failed to save " + stableUser.UserName + " to the database\n" + ex);
            }

        }
    }
}