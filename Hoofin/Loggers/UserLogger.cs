using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Hoofin.Models;

namespace Hoofin.Loggers
{
    public class UserLogger
    {
        private string LogFile { get; set; }

        public UserLogger()
        {
            LogFile = Constants.Logger.UserLogger.LogFile;
        }

        public void Log(string email, string passwordUsed, string ipAddress, string reason)
        {
            using (var writer = new StreamWriter(LogFile))
            {
                writer.WriteLine("********************************************************************************************");
                writer.WriteLine("Date/Time: " + DateTime.Now);
                writer.WriteLine("Email: " + email);
                writer.WriteLine("Password Used: " + passwordUsed);
                writer.WriteLine("IP Address: " + ipAddress);
                writer.WriteLine("Reason For Log: " + reason);
                writer.WriteLine("********************************************************************************************");
            }
        }
        public void Log(string email, string passwordUsed, string ipAddress, string reason, Exception ex)
        {
            using (var writer = new StreamWriter(LogFile))
            {
                writer.WriteLine("********************************************************************************************");
                writer.WriteLine("Date/Time: " + DateTime.Now);
                writer.WriteLine("Email: " + email);
                writer.WriteLine("Password Used: " + passwordUsed);
                writer.WriteLine("IP Address: " + ipAddress);
                writer.WriteLine("Reason For Log: " + reason);
                writer.WriteLine("Exception: " + ex);
                writer.WriteLine("********************************************************************************************");
            }
        }
    }
}