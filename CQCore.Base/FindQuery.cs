using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Product.CQCore.Core;
using Product.RepositoryCore.Core;

namespace Product.CQCore.Base
{
    public class FindQuery<TKey, TEntity> : IFindQuery<TKey, TEntity>
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


        public IQueryRepository<TKey, TEntity> Repository { get; set; }

        public TEntity Execute()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> ExecuteAsync()
        {
            return await Repository.ReadAsync(Key);
        }
    }
}
