/*
 * DescribeHashidsExtensions_netstandard.cs
 *
 *   Created: 2023-01-05-06:20:53
 *   Modified: 2023-01-05-06:21:06
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Reflection;
using JustinWritesCode.AspNetCore.Hashids;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class DescribeHashidsExtensions
{
    public static IServiceCollection DescribeHashids(
        this IServiceCollection services,
        params Assembly[]? assemblies
    )
    {
        services.ConfigureSwaggerGen(
            options => options.OperationFilter<HashidsOperationFilter>()
        );
        // assemblies ??= AppDomain.CurrentDomain.GetAssemblies();
        // builder.Services.DescribeHashidsFromAssemblies(assemblies);
        return services;
    }
}
