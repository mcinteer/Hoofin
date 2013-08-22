using Hoofin.Models;

namespace Hoofin.Repositories
{
    public interface IUserRepository
    {
        void CreateNewUser(RegisterModel model);
    }
}