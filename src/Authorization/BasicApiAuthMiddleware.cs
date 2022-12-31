/*
 * BasicApiAuthMiddleware.cs
 *
 *   Created: 2022-12-14-05:48:24
 *   Modified: 2022-12-14-05:48:25
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Authorization;

using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using static System.Text.TextEncodingExtensions;
using JustinWritesCode.Abstractions;
using JustinWritesCode.AspNetCore.Authorization;
using JustinWritesCode.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using static System.Net.HttpStatusCode;

public class BasicApiAuthMiddleware : IBasicApiAuthMiddleware, ILog
{
    public  UserManager UserManager { get; }

    public ILogger Logger { get; init; }

    public BasicApiAuthMiddleware(UserManager userManager, ILogger<BasicApiAuthMiddleware> logger)
    {
        UserManager = userManager;
        Logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        Logger.BeginAuthentication(context.TraceIdentifier, context.Request.Path, context.Request.Method);
        try
        {
            var authHeader = AuthenticationHeaderValue.Parse(context.Request.Headers["Authorization"]);
            var credentialBytes = FromBase64String(authHeader.Parameter);
            var credentials = GetUTF8String(credentialBytes).Split(':', 2);
            var authUsername = credentials[0];
            var authPassword = credentials[1];
            Logger.AuthenticatingUser(authUsername);

            // authenticate credentials with user service and attach user to http context
            var user = await UserManager.FindByNameAsync(authUsername);
            if (user is not null && await UserManager.CheckPasswordAsync(user, authPassword))
            {
                var identity = new ClaimsIdentity(ApiBasicAuthenticationOptions.AuthenticationSchemeName);
                var userClaims = await UserManager.GetClaimsAsync(user);
                identity.AddClaims(userClaims);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, ApiBasicAuthenticationOptions.AuthenticationSchemeName);
                context.User = principal;
                Logger.UserAuthenticated(authUsername, userClaims.Count);
            }
            else
            {
                Logger.UserAuthenticationFailed(authUsername);
                // context.Response.Headers["WWW-Authenticate"] = "Basic";
                // context.Response.StatusCode = (int)Unauthorized;
            }
        }
        catch
        {
            Logger.InvalidAuthHeader(context.TraceIdentifier);
            // context.Response.Headers["WWW-Authenticate"] = "Basic";
            // context.Response.StatusCode = (int)Unauthorized;

        }

        await next(context);
    }

    public virtual Task HandleChallengeAsync(HttpContext context)
    {
        context.Response.StatusCode = 401;
        context.Response.Headers["WWW-Authenticate"] = "Basic";
        return Task.CompletedTask;
    }
}
