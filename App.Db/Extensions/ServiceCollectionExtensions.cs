using App.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace App.Db.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddEntityFramework(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
