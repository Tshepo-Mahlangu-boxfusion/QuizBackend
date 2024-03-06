using Abp.Authorization;
using QuizT.Authorization.Roles;
using QuizT.Authorization.Users;

namespace QuizT.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
