/*
 * AddExamplesExtension.cs
 *
 *   Created: 2022-12-19-05:33:50
 *   Modified: 2022-12-19-05:33:50
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Swashbuckle.AspNetCore.Filters;

namespace Microsoft.Extensions.DependencyInjection;

public static class AddExamplesExtension
{
    public static WebApplicationBuilder AddSwaggerExamples(
        this WebApplicationBuilder builder,
        params Assembly[]? assemblies
    )
    {
        assemblies ??= AppDomain.CurrentDomain.GetAssemblies();
        builder.Services.AddSwaggerExamplesFromAssemblies(assemblies);
        return builder;
    }
}
