using System;
using System.Data.Common;
using Abp.Collections;
using Abp.Modules;
using Abp.TestBase;
using Castle.MicroKernel.Registration;
using DSystems.EntityFramework;
using DSystems.Test.InitialData;

namespace DSystems.Test
{
    public abstract class DSystemsTestBase : AbpIntegratedTestBase
    {
        protected DSystemsTestBase()
        {
            

            LocalIocManager.IocContainer.Register(
                Component.For<DbConnection>()
                    .UsingFactoryMethod(Effort.DbConnectionFactory.CreateTransient)
                    .LifestyleSingleton()
                );

            UsingDbContext(context => new SimpleDSystemInitialDataBuilder().Build(context));
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

        protected override void AddModules(ITypeList<AbpModule> modules)
        {
            modules.Add<DSystemTestModule>();
            base.AddModules(modules);
        }
    }
}
