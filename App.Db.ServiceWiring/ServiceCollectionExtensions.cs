using App.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace App.Db.ServiceWiring
{
    public static class ServiceCollectionExtensions
    {
        //NOTE: avoid setting db context on services
        public static void AddEntityFramework(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
