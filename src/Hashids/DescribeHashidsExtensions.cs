/*
 * DessribeHadhidsExtensions.cs
 *
 *   Created: 2022-12-20-01:11:23
 *   Modified: 2022-12-20-01:11:23
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Reflection;
using JustinWritesCode.AspNetCore.Hashids;
using Microsoft.AspNetCore.Builder;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class DescribeHashidsExtensions
{
    public static WebApplicationBuilder DescribeHashids(
        this WebApplicationBuilder builder,
        params Assembly[]? assemblies
    )
    {
        builder.Services.DescribeHashids();
        return builder;
    }
}
