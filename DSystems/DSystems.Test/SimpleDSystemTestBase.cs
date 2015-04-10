using System;
using System.Data.Common;
using Abp.Collections;
using Abp.Modules;
using Abp.TestBase;
using Castle.MicroKernel.Registration;
using DSystems.EntityFramework;

namespace DSystems.Test
{
    public abstract class SimpleDSystemTestBase : AbpIntegratedTestBase
    {
        protected SimpleDSystemTestBase()
        {
            LocalIocManager.IocContainer.Register(
                Component.For<DbConnection>()
                    .UsingFactoryMethod(Effort.DbConnectionFactory.CreateTransient)
                    .LifestyleSingleton()
                );


        }

        protected override void AddModules(ITypeList<AbpModule> modules)
        {
            base.AddModules(modules);

            modules.Add<SimpleTaskSystemApplicationModule>();
            modules.Add<DSystems.DSystemsCoreModule>();
            modules.Add<DSystems.DSystemsDataModule>();
            modules.Add<DSystems.Service.Contract.DSystemServiceContractModule>();
            modules.Add<DSystems.Service.DSystemServiceModule>();


        }

        public void UsingDbContext(Action<DSystemsDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<DSystemsDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        public T UsingDbContext<T>(Func<DSystemsDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<DSystemsDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }
            return result;
        }
    }
}
