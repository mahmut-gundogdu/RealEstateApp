using Abp.Authorization;
using RealEstateApp.Authorization.Roles;
using RealEstateApp.Authorization.Users;

namespace RealEstateApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
