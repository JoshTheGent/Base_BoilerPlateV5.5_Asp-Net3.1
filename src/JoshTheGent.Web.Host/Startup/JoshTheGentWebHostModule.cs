using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JoshTheGent.Configuration;

namespace JoshTheGent.Web.Host.Startup
{
    [DependsOn(
       typeof(JoshTheGentWebCoreModule))]
    public class JoshTheGentWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JoshTheGentWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JoshTheGentWebHostModule).GetAssembly());
        }
    }
}
