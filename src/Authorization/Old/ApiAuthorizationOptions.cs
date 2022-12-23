/*
 * ApiAuthorizationServerProvider.cs
 *
 *   Created: 2022-12-10-07:18:59
 *   Modified: 2022-12-10-07:18:59
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace JustinWritesCode.AspNetCore.Authorization;

using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;

[DebuggerDisplay($"Scheme: {{{nameof(AuthenticationSchemeName)}}}")]
public class ApiBasicAuthenticationOptions : AuthenticationSchemeOptions
{

    public ApiBasicAuthenticationOptions()
    {
        this.ClaimsIssuer = Identity.ClaimTypes.BaseUri;
        this.ForwardAuthenticate = AuthenticationSchemeName;
        this.ForwardChallenge = AuthenticationSchemeName;
        this.ForwardForbid = AuthenticationSchemeName;
        this.ForwardSignIn = AuthenticationSchemeName;
        this.ForwardSignOut = AuthenticationSchemeName;
        this.ForwardDefault = AuthenticationSchemeName;
    }

    // public override string ClaimsIssuer => JustinWritesCode.Security.Claims.

    public const string AuthenticationSchemeName = "Basic";
    public const string UserHeaderName = "X-User-Key";
    public const string AdminHeaderName = "X-Admin-Key";

    // public string? UserApiKey { get; set; }
    // public string? AdminApiKey { get; set; }
}
