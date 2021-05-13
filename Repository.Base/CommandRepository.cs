using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

using Product.Repository.Core;

namespace Product.Repository.Base
{
    public class CommandRepository<TKey, TEntity> : RepositoryBase, ICommandRepository<TKey, TEntity>
        where TEntity : class
    {
        public CommandRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task CreateAsync(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);

            await Context.SaveChangesAsync();
        }

        public async Task BatchCreateAsync(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);

            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(params object[] id)
        {
            var dbSet = Context.Set<TEntity>();

            var entity = await dbSet.FindAsync(id);

            dbSet.Remove(entity);

            await Context.SaveChangesAsync();
        }

        public async Task BatchDeleteAsync(IEnumerable<TEntity> entities)
        {
            var dbSet = Context.Set<TEntity>();

            dbSet.RemoveRange(entities);

            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            Context.Entry<TEntity>(entity).State = EntityState.Modified;

            await Context.SaveChangesAsync();
        }

        public async Task BatchUpdateAsync(IEnumerable<TEntity> entities)
        {
            foreach (var e in entities)
            {
                Context.Entry<TEntity>(e).State = EntityState.Modified;
            }

            await Context.SaveChangesAsync();
        }
    }
}