using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JoshTheGent.Authorization;

namespace JoshTheGent
{
    [DependsOn(
        typeof(JoshTheGentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class JoshTheGentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<JoshTheGentAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(JoshTheGentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
