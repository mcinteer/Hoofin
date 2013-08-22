using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Hoofin.Loggers;
using Hoofin.Models;
using Hoofin.Repositories;
using Hoofin.Services.Interfaces;

namespace Hoofin.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        private readonly UserLogger _logger;

        public UserService()
        {
            _userRepository = new UserRepository();
            _logger = new UserLogger();
        }

        public void CreateNewUser(RegisterModel model)
        {
            _userRepository.CreateNewUser();
        }
    }
}