using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LLMall.Controllers
{
    public abstract class LLMallControllerBase: AbpController
    {
        protected LLMallControllerBase()
        {
            LocalizationSourceName = LLMallConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
