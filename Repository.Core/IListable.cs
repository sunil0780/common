using System.Linq;

namespace Product.Repository.Core
{
    public interface IListable<TEntity>
    {
        IQueryable<TEntity> Items { get; }
    }
}