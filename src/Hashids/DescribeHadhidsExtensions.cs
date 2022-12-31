/*
 * DessribeHadhidsExtensions.cs
 *
 *   Created: 2022-12-20-01:11:23
 *   Modified: 2022-12-20-01:11:23
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.AspNetCore.Builder;
using JustinWritesCode.AspNetCore.Hashids;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection;

public static class DescribeHashidsExtensions
{
    public static WebApplicationBuilder DescribeHashids(this WebApplicationBuilder builder, params Assembly[]? assemblies)
    {
        builder.Services.ConfigureSwaggerGen(options =>
            options.OperationFilter<HashidsOperationFilter>());
        // assemblies ??= AppDomain.CurrentDomain.GetAssemblies();
        // builder.Services.DescribeHashidsFromAssemblies(assemblies);
        return builder;
    }
}
