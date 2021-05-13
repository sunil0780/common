namespace Product.RepositoryCore.Core
{
    public interface ICommandRepository<TKey, TEntity> : ICreatable<TEntity>, IUpdatable<TEntity>, IDeletable<TKey, TEntity>
    {
    }
}