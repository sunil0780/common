using Product.CQ.Core;
using Product.Repository.Core;
using System;
using System.Threading.Tasks;

namespace Product.CQ.Base
{
    public class CreateCommand<TKey, TEntity> : ISaveCommand<TEntity>
        where TEntity : class
    {
        public TEntity Entity
        {
            get; set;
        }

        public ICommandRepository<TKey, TEntity> Repository { get; set; }

        public virtual async Task ExecuteAsync()
        {
            await Repository.CreateAsync(Entity);
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}