using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FlexiCoudPay.Controllers
{
    public abstract class FlexiCoudPayControllerBase: AbpController
    {
        protected FlexiCoudPayControllerBase()
        {
            LocalizationSourceName = FlexiCoudPayConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
