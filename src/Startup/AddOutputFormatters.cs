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
using JustinWritesCode.AspNetCore.Formatters;
using MessagePack;
using MessagePack.AspNetCoreMvcFormatter;
using MessagePack.Resolvers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Formatters;

public static class StartupExtensions
{
    public static WebApplicationBuilder AddFormatters(this WebApplicationBuilder builder)
    {
        _ = builder.Services.AddControllers(options =>
        {
            options.RespectBrowserAcceptHeader = true;
            options.ReturnHttpNotAcceptable = true;

            options.OutputFormatters.Insert(0, new JustinWritesCode.Payloads.Formatters.PlainTextPayloadFormatter());
            options.InputFormatters.Add(new PlainTextInputFormatter());

            options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            options.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
            options.OutputFormatters.Add(new BsonMediaTypeFormatter());
            options.OutputFormatters.Add(new PlainTextProblemDetailsOutputFormatter());
            options.OutputFormatters.Add(new PlainTextOutputFormatter());

            options.OutputFormatters.Add(new MessagePackOutputFormatter(new MessagePackSerializerOptions(ContractlessStandardResolver.Instance)));
            options.InputFormatters.Add(new MessagePackInputFormatter(new MessagePackSerializerOptions(ContractlessStandardResolver.Instance)));

            options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            // options.InputFormatters.Add(new XmlSerializerInputFormatter());
        }).AddXmlSerializerFormatters();
        _ = builder.AddPayloadFormatters();
        _ = builder.AddInputFormatters();
        return builder;
    }

    public static WebApplicationBuilder AddInputFormatters(this WebApplicationBuilder builder)
    {
        _ = builder.Services.AddControllers(options =>
        {
        });
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
