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
using Microsoft.Extensions.Logging;
using static Microsoft.Extensions.Logging.LogLevel;

internal static partial class LoggerExtensions
{
    [LoggerMessage(0, Debug, "Begin authentication for request {TraceIdentifier} {Path} {Method}")]
    public static partial void BeginAuthentication(this ILogger logger, string traceIdentifier, string path, string method);
    [LoggerMessage(0, Debug, "Authenticating user {Username}")]
    public static partial void AuthenticatingUser(this ILogger logger, string Username);
    [LoggerMessage(0, Debug, "User {Username} authenticated successfully (claims: {claimCount}")]
    public static partial void UserAuthenticated(this ILogger logger, string Username, int claimCount);
    [LoggerMessage(0, Debug, "User {Username} failed to authenticate")]
    public static partial void UserAuthenticationFailed(this ILogger logger, string Username);
    [LoggerMessage(0, Debug, "User {Username} failed to authenticate: {Reason}")]
    public static partial void UserAuthenticationFailed(this ILogger logger, string Username, string Reason);
    [LoggerMessage(0, Debug, "{TraceIdentifier} presented an invalid or missing auth header.")]
    public static partial void InvalidAuthHeader(this ILogger logger, string TraceIdentifier);
}
