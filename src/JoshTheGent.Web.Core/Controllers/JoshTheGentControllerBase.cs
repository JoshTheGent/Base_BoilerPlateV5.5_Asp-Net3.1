using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace JoshTheGent.Controllers
{
    public abstract class JoshTheGentControllerBase: AbpController
    {
        protected JoshTheGentControllerBase()
        {
            LocalizationSourceName = JoshTheGentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
