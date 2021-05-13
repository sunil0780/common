namespace Product.CQ.Core
{
    public interface IDeleteCommand<TKey> : ICommand
    {
        TKey Id { get; set; }

        object[] Key { get; set; }

    }
}