using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace App.Db
{
    public class AppContextFactory : IDbContextFactory<AppDbContext>
    {
        public AppDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer(Config.ConnectionString);
            return new AppDbContext(builder.Options);
        }
    }
}
