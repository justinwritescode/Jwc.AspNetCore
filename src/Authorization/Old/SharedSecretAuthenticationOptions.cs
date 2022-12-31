/*
 * SharedSecretAuthenticationOptions.cs
 *
 *   Created: 2022-12-31-05:05:02
 *   Modified: 2022-12-31-05:05:21
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
public class SharedSecretAuthenticationOptions : AuthenticationSchemeOptions
{

    public SharedSecretAuthenticationOptions()
    {
        this.ClaimsIssuer = Identity.ClaimTypes.BaseUri;
        this.ForwardAuthenticate = AuthenticationSchemeName;
        this.ForwardChallenge = AuthenticationSchemeName;
        this.ForwardForbid = AuthenticationSchemeName;
        this.ForwardSignIn = AuthenticationSchemeName;
        this.ForwardSignOut = AuthenticationSchemeName;
        this.ForwardDefault = AuthenticationSchemeName;
    }

    public string Secret { get; set; }

    public const string AuthenticationSchemeName = "SharedSecret";
    public const string AuthenticationSchemeDisplayName = "Shared Secret";
    public const string AuthenticationSchemeDescription = "Insecure authentication with a common shared secret";
}
