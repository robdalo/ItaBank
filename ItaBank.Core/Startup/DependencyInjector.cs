using ItaBank.Core.DataAccess;
using ItaBank.Core.DataAccess.Repos;
using ItaBank.Core.DataAccess.Repos.Interfaces;
using ItaBank.Core.Services;
using ItaBank.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ItaBank.Core.Startup
{
    public class DependencyInjector
    {
        private readonly string _connectionString;

        public DependencyInjector(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Configure(IServiceCollection services)
        {
            services.AddDbContext<ItaBankContext>(o => o.UseSqlServer(_connectionString), ServiceLifetime.Singleton);
            services.AddSingleton<IAccountRepo, AccountRepo>();
            services.AddSingleton<IAccountService, AccountService>();
        }
    }
}
