namespace Product.CQCore.Core
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