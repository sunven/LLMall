using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LLMall.Authorization;

namespace LLMall
{
    [DependsOn(
        typeof(LLMallCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LLMallApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LLMallAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LLMallApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
