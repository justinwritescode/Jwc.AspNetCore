/*
 * OpenApiAnyOfAttribute.cs
 *
 *   Created: 2022-12-21-08:46:55
 *   Modified: 2022-12-21-08:46:57
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

namespace JustinWritesCode.Swagger.Annotations;

public class OpenApiAnyOfAttribute : OpenApiSchemaAttribute
{
    public OpenApiAnyOfAttribute(params object[] anyOf) : this(anyOf as IEnumerable<object>) { }

    public OpenApiAnyOfAttribute(IEnumerable<object> anyOf)
    {
        Enum = anyOf
            .Select(anyOfItem => new OpenApiString(anyOfItem?.ToString()))
            .OfType<IOpenApiAny>()
            .ToList();
    }
}
