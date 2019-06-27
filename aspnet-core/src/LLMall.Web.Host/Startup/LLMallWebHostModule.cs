using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LLMall.Configuration;

namespace LLMall.Web.Host.Startup
{
    [DependsOn(
       typeof(LLMallWebCoreModule))]
    public class LLMallWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LLMallWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LLMallWebHostModule).GetAssembly());
        }
    }
}
