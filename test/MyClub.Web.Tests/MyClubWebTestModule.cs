using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyClub.EntityFrameworkCore;
using MyClub.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyClub.Web.Tests
{
    [DependsOn(
        typeof(MyClubWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyClubWebTestModule : AbpModule
    {
        public MyClubWebTestModule(MyClubEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyClubWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyClubWebMvcModule).Assembly);
        }
    }
}