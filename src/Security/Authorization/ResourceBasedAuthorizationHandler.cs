namespace JustinWritesCode.AspNetCore.Authentication;

using JustinWritesCode.EntityFrameworkCore.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore.Abstractions;


public abstract class ResourceBasedAuthorizationHandler<TDbContext, TModel, TId>
    : AuthorizationHandler<OperationAuthorizationRequirement>
    where TDbContext : IDbContext<TDbContext>
    where TModel : class, IIdentifiable<TId>
    where TId : struct, IComparable, IEquatable<TId>
{
    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        OperationAuthorizationRequirement requirement
    )
    {
        if (context.User.Identity is not null && context.User.Identity.IsAuthenticated)
        {
            var resource = context.Resource as IAuthorizableEntity;
            if (resource is not null)
            {
                if (context.User.IsInRole(JwcR.Administrator))
                {
                    context.Succeed(requirement);
                }
                else if (resource.CanDo(context.User, requirement.Name))
                {
                    context.Succeed(requirement);
                }
                else
                {
                    context.Fail();
                }
            }
        }

        return Task.CompletedTask;
    }
}
