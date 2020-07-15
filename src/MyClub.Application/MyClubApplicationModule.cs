using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyClub.Authorization;

namespace MyClub
{
    [DependsOn(
        typeof(MyClubCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyClubApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyClubAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyClubApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
