using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Hoofin.Repositories
{
    public class BaseRepository
    {
        protected static MySqlConnection Connection { get; set; }
        protected string Server { get; set; }
        protected string Database;
        protected string UserName;
        protected string Password;

        public BaseRepository()
        {
            Connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["EStable"].ConnectionString);
        }

        protected static bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                #region exception_handling
                
                //When handling errors, you can customize the application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
                #endregion
            }
        }

        //Close connection
        protected static bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}