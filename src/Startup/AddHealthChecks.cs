/*
 * AddHealthChecks.cs
 *
 *   Created: 2023-01-03-07:17:59
 *   Modified: 2023-01-03-07:17:59
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;

public static class JustinWritesCodeHealthChecksExtensions
{
    public static IHealthChecksBuilder AddJustinWritesCodeHealthChecks(this IHealthChecksBuilder builder)
    {
        builder.Services
                .AddHealthChecks();
        return builder;
    }
}
