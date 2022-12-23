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
using JustinWritesCode.Abstractions;
using JustinWritesCode.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ClaimTypes = JustinWritesCode.Identity.ClaimTypes;

public class BasicApiAuthHandler : AuthenticationHandler<ApiBasicAuthenticationOptions>, IHttpContextAccessor, ILog
{
    public ILogger Logger { get; init; }
    private readonly UserManager _userManager;
    private readonly ApiBasicAuthenticationOptions _options;
    public HttpContext? HttpContext { get; set; } = default!;

    public BasicApiAuthHandler(IOptionsMonitor<ApiBasicAuthenticationOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, UserManager userManager) : base(options, logger, encoder, clock)
    {
        _userManager = userManager;
        _options = options.CurrentValue;
        Logger = logger.CreateLogger<BasicApiAuthHandler>();
    }
    public IBasicApiAuthMiddleware Middleware { get; }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        var authHeader = AuthenticationHeaderValue.Parse(HttpContext.Request.Headers["Authorization"]);
        var credentialBytes = FromBase64String(authHeader.Parameter);
        var credentials = UTF8.GetString(credentialBytes).Split(':', 2);
        var authUsername = credentials[0];
        var authPassword = credentials[1];
        // authenticate credentials with user service and attach user to http context
        var user = await _userManager.FindByNameAsync(authUsername);
        if (user is not null && await _userManager.CheckPasswordAsync(user, authPassword))
        {
            var identity = new ClaimsIdentity(ApiBasicAuthenticationOptions.AuthenticationSchemeName);
            var userClaims = await _userManager.GetClaimsAsync(user);

            userClaims.Add(new(TelegramID.Username, user.TelegramUsername));
            userClaims.Add(new (TelegramID.UserId, user.Id.ToString()));
            if(!IsNullOrEmpty(user.Email))
            {
                userClaims.Add(new(ClaimTypes.Email, user.Email));
            }

            identity.AddClaims(userClaims);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, ApiBasicAuthenticationOptions.AuthenticationSchemeName);
            HttpContext.User = principal;
            Logger.UserAuthenticated(authUsername, userClaims.Count);
            // await context.SignInAsync(ApiKeyAuthenticationOptions.AuthenticationSchemeName, principal);
            // return AuthenticateResult.Success(ticket);
            return AuthenticateResult.Success(ticket);
        }
        else if (user is null)
        {
            Logger.UserAuthenticationFailed(authUsername);
            return AuthenticateResult.Fail("Invalid username or password.");
        }
        return AuthenticateResult.Fail("An unknown error occurred while authenticating the user.");
    }

    public async Task<IAuthenticationHandler?> GetHandlerAsync(HttpContext context, string authenticationScheme)
    {
        if (authenticationScheme == ApiBasicAuthenticationOptions.AuthenticationSchemeName)
        {
            await InitializeAsync(new AuthenticationScheme(authenticationScheme, authenticationScheme, GetType()), context);
            return this;
        }
        return null;
    }

    public Task InitializeAsync(AuthenticationScheme scheme, HttpContext context)
    {
        HttpContext = context;
        return Task.CompletedTask;
    }
    public Task<AuthenticateResult> AuthenticateAsync() => HandleAuthenticateAsync();
    public Task ChallengeAsync(AuthenticationProperties? properties)
    {
        HttpContext.Response.StatusCode = 401;
        HttpContext.Response.Headers["WWW-Authenticate"] = "Basic";
        return Task.CompletedTask;
    }
    public Task ForbidAsync(AuthenticationProperties? properties)
    {
        HttpContext.Response.StatusCode = 403;
        return Task.CompletedTask;
    }
}
