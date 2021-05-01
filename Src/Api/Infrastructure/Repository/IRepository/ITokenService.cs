using Core.Entities;

namespace Infrastructure.Repository.IRepository
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
