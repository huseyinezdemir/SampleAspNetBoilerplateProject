using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using DSystems.EntityFramework;

namespace DSystems
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(DSystemsCoreModule))]
    public class DSystemsDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DSystemsDbContext>());
        }
    }
}
