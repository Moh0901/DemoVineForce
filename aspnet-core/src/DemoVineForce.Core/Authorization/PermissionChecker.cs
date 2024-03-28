using Abp.Authorization;
using DemoVineForce.Authorization.Roles;
using DemoVineForce.Authorization.Users;

namespace DemoVineForce.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
