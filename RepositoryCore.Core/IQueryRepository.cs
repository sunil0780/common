namespace Product.RepositoryCore.Core
{
    public interface IQueryRepository<TKey, TEntity> : IListable<TEntity>, IReadable<TKey, TEntity>
    {
    }
}