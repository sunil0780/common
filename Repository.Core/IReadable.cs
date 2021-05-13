using System.Threading.Tasks;

namespace Product.Repository.Core
{
    public interface IReadable<TKey, TEntity>
    {
        Task<TEntity> ReadAsync(TKey Id);
    }
}