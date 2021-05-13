using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.RepositoryCore.Core
{
    public interface IDeletable<TKey, TEntity>
    {
        Task DeleteAsync(params object[] key);
        Task BatchDeleteAsync(IEnumerable<TEntity> entities);
    }
}