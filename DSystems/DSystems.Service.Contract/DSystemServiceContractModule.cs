using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Abp.Modules;

namespace DSystems.Service.Contract
{
    [DependsOn(typeof(AbpEntityFrameworkModule))]
    public class DSystemServiceContractModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            base.Initialize();
        }
    }
}
