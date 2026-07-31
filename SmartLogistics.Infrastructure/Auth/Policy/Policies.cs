using Microsoft.AspNetCore.Authorization;

namespace SmartLogistics.Infrastructure.Auth.Policy
{
    public static class Policies
    {
        public const string DispatcherOnlyWithActiveDriverClaim = "DispatcherOnlyWithActiveDriverClaim";
        public const string WarehouseStaffWithLocationAccess = "WarehouseStaffWithLocationAccess";

        public static void ConfigureCustomPolicies(AuthorizationOptions options)
        {
            // Claim-based + Role-based Policy integration
            options.AddPolicy(DispatcherOnlyWithActiveDriverClaim, policy =>
                policy.RequireRole("Dispatcher", "Super Admin")
                      .RequireClaim("ActiveDriverId")); // User must have assigned driver ID claim

            options.AddPolicy(WarehouseStaffWithLocationAccess, policy =>
                policy.RequireRole("Warehouse Staff", "Warehouse Manager", "Super Admin")
                      .RequireClaim("AssignedWarehouseId")); // User must belong to specific warehouse location
        }
    }
}
