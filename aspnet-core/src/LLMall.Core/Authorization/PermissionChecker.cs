using Abp.Authorization;
using LLMall.Authorization.Roles;
using LLMall.Authorization.Users;

namespace LLMall.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
