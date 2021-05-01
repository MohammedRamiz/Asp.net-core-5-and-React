using Core.Common;
using Infrastructure.Persistence;
using Infrastructure.Repository.IRepository;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AdminApplicationDbContext _db;
        private readonly AppSettings _appSettings;

        public UnitOfWork(AdminApplicationDbContext db, AppSettings appSettings, IConfiguration config)
        {
            _db = db;
            _appSettings = appSettings;
            Token = new TokenService(_appSettings);
            User = new UserRepository(_db, _appSettings);
        }

        public ITokenService Token { get; private set; }
        public IUserRepository User { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
