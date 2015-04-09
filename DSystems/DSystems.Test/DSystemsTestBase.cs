using System;
using System.Data.Common;
using Abp.Collections;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using DSystems.EntityFramework;
using DSystems.Test.InitialData;

namespace DSystems.Test
{
    public abstract class DSystemsTestBase : Abp.TestBase.AbpIntegratedTestBase
    {
        protected DSystemsTestBase()
        {
            this.LocalIocManager.IocContainer.Register(
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
            base.AddModules(modules);
        }
    }
}
