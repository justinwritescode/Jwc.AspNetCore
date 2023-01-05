/*
 * AuthorizationAttributes.cs
 *
 *   Created: 2023-01-05-07:23:12
 *   Modified: 2023-01-05-07:23:12
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Authorization;

using Microsoft.AspNetCore.Authorization;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class AdminAttribute : AuthorizeAttribute
{
    public AdminAttribute() : base()
    {
        this.Roles = JwcR.Admin;
    }
}

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class AuthenticatedUserAttribute : AuthorizeAttribute
{
    public AuthenticatedUserAttribute() : base()
    {
        this.Roles = JwcR.User;
    }
}
