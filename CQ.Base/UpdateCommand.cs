using Product.CQ.Core;
using Product.Repository.Core;
using System;
using System.Threading.Tasks;

namespace Product.CQ.Base
{
    public class UpdateCommand<TKey, TEntity> : ISaveCommand<TEntity>
        where TEntity : class
    {
        public TEntity Entity
        {
            get; set;
        }

        public ICommandRepository<TKey, TEntity> Repository { get; set; }

        public async Task ExecuteAsync()
        {
            await Repository.UpdateAsync(Entity);
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}