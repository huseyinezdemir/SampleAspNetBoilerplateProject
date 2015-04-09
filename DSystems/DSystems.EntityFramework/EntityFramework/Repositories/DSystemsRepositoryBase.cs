using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace DSystems.EntityFramework.Repositories
{
    public abstract class DSystemsRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DSystemsDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DSystemsRepositoryBase(IDbContextProvider<DSystemsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DSystemsRepositoryBase<TEntity> : DSystemsRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DSystemsRepositoryBase(IDbContextProvider<DSystemsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
