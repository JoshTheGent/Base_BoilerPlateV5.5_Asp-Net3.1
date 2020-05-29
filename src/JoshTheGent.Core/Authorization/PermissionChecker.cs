using Abp.Authorization;
using JoshTheGent.Authorization.Roles;
using JoshTheGent.Authorization.Users;

namespace JoshTheGent.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
