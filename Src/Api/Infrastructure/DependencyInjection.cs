using Infrastructure.Identity;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Infrastructure.Repository.IRepository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<AdminApplicationDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(AdminApplicationDbContext).Assembly.FullName)));


            services.AddDefaultIdentity<ApplicationUser>()
                .AddEntityFrameworkStores<AdminApplicationDbContext>();


            services.AddAuthentication()
                .AddIdentityServerJwt();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
