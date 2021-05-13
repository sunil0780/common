namespace Product.CQ.Core
{
    public interface IFindQuery<TKey, TEntity> : IQuery<TEntity>
    {
        TKey Id { get; set; }
    }
}