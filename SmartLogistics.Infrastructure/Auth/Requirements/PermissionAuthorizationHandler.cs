using Microsoft.AspNetCore.Authorization;
using SmartLogistics.Infrastructure.Auth.Requirements;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLogistics.Infrastructure.Auth.Requirements
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            // 1. Role-Based Check: Super Admin bypasses all checks
            if (context.User.IsInRole("Super Admin"))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            // 2. Claim-Based Check: Check custom claim type "Permission"
            var permissions = context.User.FindAll(c => c.Type == "Permission").Select(c => c.Value);

            if (permissions.Contains(requirement.Permission))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
