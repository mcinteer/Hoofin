using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoofin.Constants
{
    public class Validator
    {
        public class UserRegistrationValidator
        {
            public class ErrorMessages
            {
                public const string PasswordMismatch = "The password's you entered do not match.";
                public const string InvalidEmail = "The email you entered is in an invalid format.";
            }

            public class Regex
            {
                public const string Email = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                  + "@"
                                  + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            }
            public class ErrorCodes
            {
                public const string PasswordMismatch = @"ERR\PWMISSMATCH";
                public const string InvalidEmail = @"ERR\INVALIDEMAIL";
            }
        }
    }
}