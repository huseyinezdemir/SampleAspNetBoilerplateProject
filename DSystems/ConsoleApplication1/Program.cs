using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Dependency;
using Abp.Modules;
using DSystems;
using DSystems.Service;
using DSystems.Service.Contract;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bootstrapper = new AbpBootstrapper())
            {
                bootstrapper.Initialize();

                var test = IocManager.Instance.Resolve<IUserService>();
                test.GetAllUsers();

            }
        }
    }
    [DependsOn(typeof(DSystemsCoreModule), typeof(DSystemsDataModule), typeof(DSystemServiceContractModule), typeof(DSystemServiceModule))]
    public class MyConsoleAppModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
