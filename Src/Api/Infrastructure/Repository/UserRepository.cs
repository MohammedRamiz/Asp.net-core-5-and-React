using Core.Common;
using Core.Entities;
using Infrastructure.Persistence;
using Infrastructure.Repository.IRepository;
using System;
using System.Linq;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AdminApplicationDbContext _db;
        private readonly AppSettings _appSettings;

        public UserRepository(AdminApplicationDbContext db, AppSettings appSettings)
        {
            _db = db;
            _appSettings = appSettings;
        }

        public User Authenticate(string email, string password)
        {
            try
            {
                User user = _db.Users.SingleOrDefault(x => x.Email == email && x.Password == password);

                if (user == null)
                {
                    return null;
                }

                return user;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return null;
        }
    }
}
