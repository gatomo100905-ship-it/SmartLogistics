using Microsoft.AspNetCore.Authorization;

namespace SmartLogistics.Infrastructure.Auth.Policy
{
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(string permission) : base(policy: $"Permission:{permission}")
        {
        }
    }
}
