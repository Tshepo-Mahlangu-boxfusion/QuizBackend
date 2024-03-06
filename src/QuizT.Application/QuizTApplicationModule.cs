using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuizT.Authorization;

namespace QuizT
{
    [DependsOn(
        typeof(QuizTCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QuizTApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QuizTAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QuizTApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
