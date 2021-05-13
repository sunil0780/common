using Product.CQ.Core;
using Product.Repository.Core;
using System;
using System.Threading.Tasks;

namespace Product.CQ.Base
{
    public class FindQuery<TKey, TEntity> : IFindQuery<TKey, TEntity>
    {
        public TKey Id { get; set; }

        public IQueryRepository<TKey, TEntity> Repository { get; set; }

        public TEntity Execute()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> ExecuteAsync()
        {
            return await Repository.ReadAsync(Id);
        }
    }
}