using System.Data.Entity;
using Abp.EntityFramework;
using DSystems.Domain;

namespace DSystems.EntityFramework
{
    public class DSystemsDbContext : AbpDbContext
    {
        public virtual IDbSet<DSystems.Domain.User> Users { get; set; }



        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DSystemsDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in DSystemsDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of DSystemsDbContext since ABP automatically handles it.
         */
        public DSystemsDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

    }
}
