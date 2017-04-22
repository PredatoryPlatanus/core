using System.Linq;

namespace App.Db.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> Get();
    }
}
