using System;
using App.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Db
{
    public class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AppDb;Trusted_Connection=True;");
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
