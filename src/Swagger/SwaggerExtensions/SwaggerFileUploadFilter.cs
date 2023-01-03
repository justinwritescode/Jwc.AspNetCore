﻿/*
 * SwaggerFileUploadFilter.cs
 *
 *   Created: 2022-12-31-01:09:15
 *   Modified: 2022-12-31-01:09:15
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Net.Mime.MediaTypes;
using JustinWritesCode.AspNetCore.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace JustinWritesCode.AspNetCore.Swagger
{
    public class SwaggerFileOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var fileUploadMime = MultipartMediaTypeNames.FormData;
            if (
                operation.RequestBody == null
                || !operation.RequestBody.Content.Any(
                    x => x.Key.Equals(fileUploadMime, StringComparison.InvariantCultureIgnoreCase)
                )
            )
                return;

            var fileParams = context.MethodInfo
                .GetParameters()
                .Where(p => p.ParameterType == typeof(IFormFile));
            operation.RequestBody.Content[fileUploadMime].Schema.Properties =
                fileParams.ToDictionary(
                    k => k.Name,
                    v => new OpenApiSchema() { Type = "string", Format = "binary" }
                );
        }
    }
}

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SwaggerFileUploadFilter
    {
        public static WebApplicationBuilder DescribeFileUploads(this WebApplicationBuilder builder)
        {
            builder.Services.ConfigureSwaggerGen(
                options => options.OperationFilter<SwaggerFileOperationFilter>()
            );
            return builder;
        }
    }
}