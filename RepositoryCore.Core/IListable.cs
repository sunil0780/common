using System.Linq;

namespace Product.RepositoryCore.Core
{
    public interface IListable<TEntity>
    {
        IQueryable<TEntity> Items { get; }
    }
}