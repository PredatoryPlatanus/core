using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace App.Db
{
    public class AppContextFactory : IDbContextFactory<AppContext>
    {
        public AppContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<AppContext>();
            builder.UseSqlServer(Config.ConnectionString);
            return new AppContext(builder.Options);
        }
    }
}
