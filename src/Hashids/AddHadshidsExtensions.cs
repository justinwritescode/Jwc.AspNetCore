/*
 * AddHadshids.cs
 *
 *   Created: 2022-12-20-01:16:56
 *   Modified: 2022-12-20-01:16:56
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;
using global::AspNetCore.Hashids;
using global::AspNetCore.Hashids.Options;
using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Builder;

public static class AddHashidsExtensions
{
    const string HashidsOptionsConfigKey = nameof(HashidsOptions);

    public static WebApplicationBuilder AddHashids(this WebApplicationBuilder builder)
    {
        _ = builder.Services.AddHashids(
            options => builder.Configuration.GetSection(nameof(HashidsOptions)).Bind(options)
        );

        return builder;
    }
}
