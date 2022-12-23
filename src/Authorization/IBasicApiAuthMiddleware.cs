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
using JustinWritesCode.Identity;
using Microsoft.AspNetCore.Http;

public interface IBasicApiAuthMiddleware : IMiddleware
{
    UserManager UserManager { get; }
}
