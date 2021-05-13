using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Repository.Core
{
    public interface ICreatable<TEntity>
    {
        Task CreateAsync(TEntity entity);

        Task BatchCreateAsync(IEnumerable<TEntity> entities);
    }
}