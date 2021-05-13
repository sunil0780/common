using Product.Repository.Core;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Repository.Base
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

        public async Task<TEntity> ReadAsync(TKey Id)
        {
            return await Context.Set<TEntity>().FindAsync(Id);
        }
    }
}