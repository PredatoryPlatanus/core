using App.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Db
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.ConnectionString);
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public DbSet<TEntity> CreateDbSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }
    }
}
