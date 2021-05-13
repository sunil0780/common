using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Repository.Core
{
    public interface IDeletable<TKey, TEntity>
    {
        Task DeleteAsync(params object[] id);

        Task BatchDeleteAsync(IEnumerable<TEntity> entities);
    }
}