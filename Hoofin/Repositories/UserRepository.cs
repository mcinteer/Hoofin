using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Hoofin.Models;
using MySql.Data.MySqlClient;

namespace Hoofin.Repositories
{
    public class UserRepository : BaseRepository
    {

        public UserRepository() : base()
        {
        }

        public void CreateNewUser(/*UserModel model*/)
        {
            /*try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("", model);
                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("failed to save " + model.UserName + " to the database\n" + ex);
            }*/

        }

    }
}