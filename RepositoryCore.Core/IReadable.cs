using System.Threading.Tasks;

namespace Product.RepositoryCore.Core
{
    public interface IReadable<TKey, TEntity>
    {
        Task<TEntity> ReadAsync(params object[] key);
    }
}