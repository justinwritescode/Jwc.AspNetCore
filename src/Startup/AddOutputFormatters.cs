/*
 * StartupExtensions.cs
 *
 *   Created: 2022-12-10-04:48:32
 *   Modified: 2022-12-10-04:48:32
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;
using JustinWritesCode.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;

public static class StartupExtensions
{
    public static WebApplicationBuilder AddOutputFormatters(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers(options =>
        {
            options.OutputFormatters.Insert(0, new JustinWritesCode.Payloads.Formatters.PlainTextPayloadFormatter());
            // options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            options.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
            options.OutputFormatters.Add(new JustinWritesCode.AspNetCore.Formatters.PlainTextProblemDetailsOutputFormatter());
            options.OutputFormatters.Add(new JustinWritesCode.AspNetCore.Formatters.PlainTextOutputFormatter());

            options.RespectBrowserAcceptHeader = true;
            options.ReturnHttpNotAcceptable = true;
        });
        builder.AddPayloadFormatters();
        return builder;
    }

    // public static WebApplicationBuilder AddApiAuthentication(this WebApplicationBuilder builder, Action<ApiKeyAuthenticationOptions> configureOptions)
    // {
    //     builder.Services.AddAuthentication(ApiKeyAuthenticationOptions.AuthenticationSchemeName)
    //         .AddScheme<ApiKeyAuthenticationOptions, ApiKeyAuthenticationHandler>(ApiKeyAuthenticationOptions.AuthenticationSchemeName, configureOptions);
    //     builder.Services.AddAuthorization(options =>
    //     {
    //         options.AddPolicy("Admin", policy => policy.RequireRole("admin"));
    //         options.AddPolicy("User", policy => policy.RequireRole("user"));
    //     });
    //     return builder;
    // }
}
