using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class AdminApplicationDbContext : DbContext
    {
        public AdminApplicationDbContext(DbContextOptions<AdminApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
