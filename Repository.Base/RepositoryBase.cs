using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Product.Repository.Base
{
    public class RepositoryBase
    {
        protected DbContext Context { get; set; }

        public RepositoryBase(DbContext dbContext)
        {
            Context = dbContext;
        }

        public void RefreshContext()
        {
            var objContext = ((IObjectContextAdapter)Context).ObjectContext;
            var refreshableObjects = Context.ChangeTracker.Entries().Select(c => c.Entity).ToList();
            objContext.Refresh(RefreshMode.StoreWins, refreshableObjects);
        }
    }
}