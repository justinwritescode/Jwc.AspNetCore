/*
 * AddSwaggerSchemasViaAttribute.cs
 *
 *   Created: 2022-12-21-08:01:55
 *   Modified: 2022-12-21-08:01:55
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using JustinWritesCode.Swagger.Annotations;
using Microsoft.AspNetCore.Builder;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Microsoft.Extensions.DependencyInjection;

public static class AddSwaggerSchemasViaAttributeExtension
{
    public static WebApplicationBuilder DescribeSchemasViaAttributes(this WebApplicationBuilder builder)
    {
        builder.Services.DescribeSchemasViaAttributes();
        return builder;
    }

    public static IServiceCollection DescribeSchemasViaAttributes(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SchemaFilter<DescribeSchemasViaAttributesFilter>();
        });
        return services;
    }

}
