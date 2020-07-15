using Abp.Authorization;
using MyClub.Authorization.Roles;
using MyClub.Authorization.Users;

namespace MyClub.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
