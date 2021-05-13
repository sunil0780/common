using System;
using System.Threading.Tasks;

using Product.CQCore.Core;
using Product.RepositoryCore.Core;

namespace Product.CQCore.Base
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
