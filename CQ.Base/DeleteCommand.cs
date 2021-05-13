using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Product.CQ.Core;
using Product.Repository.Core;

namespace Product.CQ.Base
{
    public class DeleteCommand<TKey, TEntity> : IDeleteCommand<TKey>
    {
        private readonly TKey _id;

        [Obsolete("Use 'Key' instead")]
        public TKey Id
        {
            get
            {
                return _id;
            }
            set
            {
                var keyList = new List<object> { value as object };
                Key = keyList.ToArray();
            }
        }

        public object[] Key
        {
            get; set;
        }


        public ICommandRepository<TKey, TEntity> Repository { get; set; }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public async Task ExecuteAsync()
        {
            await Repository.DeleteAsync(Key);
        }
    }
}