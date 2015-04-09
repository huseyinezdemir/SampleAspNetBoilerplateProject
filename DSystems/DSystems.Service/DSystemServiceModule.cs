using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Abp.Modules;
using DSystems.Service.Contract;

namespace DSystems.Service
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(DSystemServiceContractModule))]
    public class DSystemServiceModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            base.Initialize();
        }
    }
}
