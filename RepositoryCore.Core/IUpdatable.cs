using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.RepositoryCore.Core
{
    public interface IUpdatable<TEntity>
    {
        Task UpdateAsync(TEntity entity);

        Task BatchUpdateAsync(IEnumerable<TEntity> entities);
    }
}