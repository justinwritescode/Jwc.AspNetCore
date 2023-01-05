using System.Collections.Immutable;
/*
 * SwaggerConflictingActionsResolver.cs
 *
 *   Created: 2022-12-16-07:09:19
 *   Modified: 2022-12-16-07:09:20
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.AspNetCore.Builder;

namespace Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.SwaggerGen;

public static class SwaggerConflictingActionsResolver
{
    public static WebApplicationBuilder AddSwaggerConflictingActionsResolver(
        this WebApplicationBuilder builder
    )
    {
        builder.Services.ConfigureSwaggerGen(options =>
        {
            options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
        });
        return builder;
    }
}
