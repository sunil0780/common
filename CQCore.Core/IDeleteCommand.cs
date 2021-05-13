using System;

namespace Product.CQCore.Core
{
    public interface IDeleteCommand<TKey> : ICommand
    {
        [Obsolete("Use 'Key' instead")]
        TKey Id { get; set; }

        object[] Key { get; set; }
    }
}