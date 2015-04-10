using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.Modules;
using DSystems.Service;
using DSystems.Service.Contract;

namespace DSystems.Test
{
    [DependsOn(typeof(DSystemServiceContractModule), typeof(DSystemServiceModule), typeof(DSystemsDataModule))]
    public class DSystemTestModule : AbpModule
    {
        public override void Initialize()
        {
            
            
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            base.Initialize();
        }
    }
}
