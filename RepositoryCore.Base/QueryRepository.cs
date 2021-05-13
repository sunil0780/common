using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Product.RepositoryCore.Core;

namespace Product.RepositoryCore.Base
{
    public class QueryRepository<TKey, TEntity> : RepositoryBase, IQueryRepository<TKey, TEntity>
        where TEntity : class
    {
        public QueryRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<TEntity> Items
        {
            get
            {
                base.RefreshContext();
                return Context.Set<TEntity>().AsQueryable();
            }
        }

        public async Task<TEntity> ReadAsync(params object[] key)
        {
            return await Context.Set<TEntity>().FindAsync(key);
        }
    }
}
