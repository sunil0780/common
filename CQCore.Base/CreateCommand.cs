using System;
using System.Threading.Tasks;

using Product.CQCore.Core;
using Product.RepositoryCore.Core;

namespace Product.CQCore.Base
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
