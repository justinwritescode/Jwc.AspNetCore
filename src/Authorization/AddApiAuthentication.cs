/*
 * AddApiAuthentication.cs
 *
 *   Created: 2022-12-10-08:00:57
 *   Modified: 2022-12-10-08:00:57
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
using JustinWritesCode.AspNetCore.Authorization;
using JustinWritesCode.Identity;
using JustinWritesCode.Identity.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IdentityDbContext = JustinWritesCode.Identity.IdentityDbContext;

namespace Microsoft.Extensions.DependencyInjection;

public static class AddApiAuthenticationExtensions
{
    /// <summary>Registers the API authentication middleware.</summary>
    public static WebApplicationBuilder AddApiAuthentication(this WebApplicationBuilder builder, Action<ApiBasicAuthenticationOptions> configureOptions = null)
    {
        builder.Services.AddScoped<IBasicApiAuthMiddleware, BasicApiAuthMiddleware>();
        return builder;
        // builder.Services
        //     .AddAuthentication()
        //     .AddScheme<ApiBasicAuthenticationOptions, BasicApiAuthHandler>(ApiBasicAuthenticationOptions.AuthenticationSchemeName, _ => { });
        // return builder;

        // builder.AddIdentity();
        // builder.Services.AddScoped<IBasicApiAuthMiddleware, BasicApiAuthMiddleware>();
        // return builder;
        // // builder.Services.AddAuthentication(options =>
        // // {
        // //     options.DefaultAuthenticateScheme = ApiKeyAuthenticationOptions.AuthenticationSchemeName;
        // //     options.DefaultChallengeScheme = ApiKeyAuthenticationOptions.AuthenticationSchemeName;
        // //     options.DefaultForbidScheme = ApiKeyAuthenticationOptions.AuthenticationSchemeName;
        // //     options.DefaultSignInScheme = ApiKeyAuthenticationOptions.AuthenticationSchemeName;
        // //     options.DefaultSignOutScheme = ApiKeyAuthenticationOptions.AuthenticationSchemeName;
        // //     options.DefaultScheme = ApiKeyAuthenticationOptions.AuthenticationSchemeName;
        // //     options.AddScheme(ApiKeyAuthenticationOptions.AuthenticationSchemeName, builder => builder.HandlerType = typeof(ApiKeyAuthenticationHandler));
        // // });

        // // builder.Services.AddAuthorization(options =>
        // // {
        // //     options.AddPolicy(ApiKeyAuthenticationOptions.AuthenticationSchemeName, policy =>
        // //     {
        // //         policy.AuthenticationSchemes.Add(ApiKeyAuthenticationOptions.AuthenticationSchemeName);
        // //         policy.RequireAuthenticatedUser();
        // //     });
        // // });
        // // builder.AddIdentity();
        // // return builder;
    }

    public static WebApplication UseApiBasicAuthentication(this WebApplication app)
    {
        // app.UseAuthentication();
        // return app;
        app.UseMiddleware<IBasicApiAuthMiddleware>();
        return app;
    }
}
