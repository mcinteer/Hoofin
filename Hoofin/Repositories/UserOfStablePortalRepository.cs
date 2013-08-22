using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hoofin.Models.Database;
using MySql.Data.MySqlClient;

namespace Hoofin.Repositories
{
	public class UserOfStablePortalRepository:BaseRepository
	{
			/*  in inp_User_Email varchar(50),
				in inp_Passwrd varchar(20),
				in inp_Active_Ind tinyint(4),
				in inp_Force_PW_Change  tinyint(4)*/
		public static void CreateNewUserOfStablePortal(UserOfStablePortal user)
		{
			OpenConnection();
			MySqlCommand command = new MySqlCommand("", Connection);
			command.CommandType = System.Data.CommandType.StoredProcedure;

			command.Parameters.Add(new MySqlParameter("inp_User_Email", user.UserName));
			command.Parameters.Add(new MySqlParameter("inp_Passwrd", user.Password));
			command.Parameters.Add(new MySqlParameter("inp_Active_Ind", user.Active));
			command.Parameters.Add(new MySqlParameter("inp_Force_PW_Change", user.ForcePWChange));

			CloseConnection();
			
		}
	}
}