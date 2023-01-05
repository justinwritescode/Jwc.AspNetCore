/*
 * AddAuthorizeSummary.cs
 *
 *   Created: 2022-12-17-09:21:05
 *   Modified: 2022-12-17-09:21:07
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Filters;

namespace Microsoft.Extensions.DependencyInjection;

public static class AddAuthorizeSummaryToSwagger
{
    public static void AddAuthorizeSummary(this SwaggerGenOptions options)
    {
        options.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
    }
}
