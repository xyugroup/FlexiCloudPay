using Abp.Authorization;
using FlexiCoudPay.Authorization.Roles;
using FlexiCoudPay.Authorization.Users;

namespace FlexiCoudPay.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
