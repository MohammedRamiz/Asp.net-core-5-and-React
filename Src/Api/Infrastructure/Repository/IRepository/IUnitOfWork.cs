namespace Infrastructure.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ITokenService Token { get; }
        IUserRepository User { get; }
    }
}
