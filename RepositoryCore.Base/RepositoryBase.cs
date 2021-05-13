using System.Linq;

using Microsoft.EntityFrameworkCore;

namespace Product.RepositoryCore.Base
{
    public class RepositoryBase
    {
        protected DbContext Context { get; set; }

        public RepositoryBase(DbContext dbContext)
        {
            Context = dbContext;
        }

        // Changed based on this https://github.com/aspnet/EntityFrameworkCore/issues/11706
        public void RefreshContext()
        {
            var refreshableObjects = Context.ChangeTracker.Entries().Select(c => c.Entity).ToList();

            foreach (var refreshableObject in refreshableObjects)
            {
                Context.Entry(refreshableObject).Reload();
            }
        }
    }
}
