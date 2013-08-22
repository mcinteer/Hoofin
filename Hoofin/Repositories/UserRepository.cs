using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Hoofin.Models;
using MySql.Data.MySqlClient;

namespace Hoofin.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MySqlConnection _connection;
        private string _server;
        private string _database;
        private string _userName;
        private string _password;

        public UserRepository()
        {
            _server = "localhost";
            _database = "establedb";
            _userName = "root";
            _password = "Rooster12";
            string connectionString = "SERVER=" + _server + ";" + "DATABASE=" +
            _database + ";" + "UID=" + _userName + ";" + "PASSWORD=" + _password + ";";

            _connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
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
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void CreateNewUser(RegisterModel model)
        {
            var query = "INSERT INTO tbl_user_of_stable_portal  VALUES ('123910','" + model.UserName + "', '" + model.Password + "', 1, 1)";
            try
            {
                OpenConnection();
                var command = new MySqlCommand();
                command.CommandText = query;
                command.Connection = _connection;

                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("failed to save " + model.UserName + " to the database\n" + ex);
            }

        }

    }
}