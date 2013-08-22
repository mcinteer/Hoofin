using Hoofin.Models;

namespace Hoofin.Services.Interfaces
{
    public interface IUserService
    {
        void CreateNewUser(RegisterModel model);
    }
}