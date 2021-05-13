namespace Product.CQ.Core
{
    public interface ISaveCommand<TEntity> : ICommand
        where TEntity : class
    {
        TEntity Entity
        {
            get; set;
        }
    }
}