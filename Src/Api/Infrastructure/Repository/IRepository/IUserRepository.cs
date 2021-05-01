using Core.Entities;

namespace Infrastructure.Repository.IRepository
{
    public interface IUserRepository
    {
        User Authenticate(string email, string password);
    }
}
