using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JoshTheGent.EntityFrameworkCore;
using JoshTheGent.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace JoshTheGent.Web.Tests
{
    [DependsOn(
        typeof(JoshTheGentWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class JoshTheGentWebTestModule : AbpModule
    {
        public JoshTheGentWebTestModule(JoshTheGentEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JoshTheGentWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(JoshTheGentWebMvcModule).Assembly);
        }
    }
}