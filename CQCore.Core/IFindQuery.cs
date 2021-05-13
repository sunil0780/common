namespace Product.CQCore.Core
{
    public interface IFindQuery<TKey, TEntity> : IQuery<TEntity>
    {
        TKey Id { get; set; }

        object[] Key { get; set; }
    }
}