using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DemoVineForce.Controllers
{
    public abstract class DemoVineForceControllerBase: AbpController
    {
        protected DemoVineForceControllerBase()
        {
            LocalizationSourceName = DemoVineForceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
