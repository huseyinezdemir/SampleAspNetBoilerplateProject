using System.Reflection;
using Abp.Modules;
using DSystems.Service;
using DSystems.Service.Contract;
using DSystems.EntityFramework;

namespace DSystems.Test
{
    [DependsOn(typeof(DSystemsCoreModule), typeof(DSystemsDataModule), typeof(DSystemServiceContractModule), typeof(DSystemServiceModule))]
    public class SimpleTaskSystemApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
