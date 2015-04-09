using System.Reflection;
using Abp.Modules;

namespace DSystems
{
    public class DSystemsCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
