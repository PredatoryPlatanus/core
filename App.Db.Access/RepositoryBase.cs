using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using App.Db.Contracts;
using App.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Db.Access
{
    public abstract class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected readonly AppContext context;
        protected readonly DbSet<T> dbSet;
        public RepositoryBase(AppContext context)
        {
            this.context = context;
            this.dbSet = context.CreateDbSet<T>();
        }

        public IQueryable<T> Get()
        {
            return dbSet;
        }

        public void Dispose()
        {
            context?.SaveChanges();
            context?.Dispose();
        }
    }
}
