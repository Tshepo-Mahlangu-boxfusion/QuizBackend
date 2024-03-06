using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace QuizT.Controllers
{
    public abstract class QuizTControllerBase: AbpController
    {
        protected QuizTControllerBase()
        {
            LocalizationSourceName = QuizTConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
