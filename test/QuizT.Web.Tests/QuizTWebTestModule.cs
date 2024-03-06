using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using QuizT.EntityFrameworkCore;
using QuizT.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace QuizT.Web.Tests
{
    [DependsOn(
        typeof(QuizTWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class QuizTWebTestModule : AbpModule
    {
        public QuizTWebTestModule(QuizTEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuizTWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(QuizTWebMvcModule).Assembly);
        }
    }
}