using App.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //NOTE: Used for migrations
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.ConnectionString);
            }    
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public DbSet<TEntity> CreateDbSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }
    }
}
