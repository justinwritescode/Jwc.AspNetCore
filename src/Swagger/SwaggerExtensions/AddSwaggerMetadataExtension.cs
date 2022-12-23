/*
 * AddSwaggerGenExtension.cs
 *
 *   Created: 2022-12-05-07:35:08
 *   Modified: 2022-12-05-07:35:08
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;
using JustinWritesCode.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using SendPulse.Data.ValueObjects;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Swagger;
using static System.String;
using static ThisAssembly.Project;

public static partial class AddSwaggerMetadataExtension
{
    public static WebApplicationBuilder AddSwaggerGen(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options => options.CustomSchemaIds(type => type.ToString()));
        return builder;
    }

    public static WebApplicationBuilder AddSwaggerMetadata(
        this WebApplicationBuilder builder,
        Type tThisAssemblyProject,
        string version = "v1",
        OpenApiInfo? openApiInfo = default)
    {
        openApiInfo ??= DefaultOpenApiInfo(tThisAssemblyProject);
        openApiInfo.Version ??= version;
        if(!openApiInfo.Version.StartsWith("v"))
            openApiInfo.Version = "v" + openApiInfo.Version;

        builder.Services.ConfigureSwaggerGen(c =>
        {
            c.CustomSchemaIds(type => type.ToString());
            c.SchemaFilter<EnusAsStringsSchemaFilter>();
            c.DocumentFilter<PathLowercaseDocumentFilter>();
            c.SwaggerDoc("v1", openApiInfo);
        });

        return builder;
    }

    public static WebApplicationBuilder AddApiKeyToSwaggerSecurity(this WebApplicationBuilder builder)
    {
        builder.Services.ConfigureSwaggerGen(c =>
        {
            c.OperationFilter<AuthorizationHeaderParameterOperationFilter>();
            c.AddSecurityDefinition(
                "Api-Key",
                new OpenApiSecurityScheme
                    {
                        Description = "API Key Authorization", // Description of the API key
                        Name = "Api-Key", //
                        In = ParameterLocation.Header, // Where the API key is located
                        Type = SecuritySchemeType.ApiKey, // Type of the API key
                        Scheme = "Api-Key" //
                    });
        });
        return builder;
    }
    public static WebApplicationBuilder DescribeBasicApiAuthentication(this WebApplicationBuilder builder)
    {
        builder.Services.ConfigureSwaggerGen(c =>
        {
             c.AddSecurityDefinition(
                  "Basic",
                  new OpenApiSecurityScheme
                       {
                            Description = "Basic", // Description of the API key
                            Name = "Authorization", //
                            In = ParameterLocation.Header, // Where the API key is located
                            Type = SecuritySchemeType.Http, // Type of the API key
                            Scheme = "Basic" //
                       });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                        new OpenApiSecurityScheme
                                {
                                    Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Basic" }
                                },
                                new List<string>()
                        },
                    });
        });
        return builder;
    }

    public static WebApplicationBuilder AddSwaggerHeaderOperationFilter(this WebApplicationBuilder builder)
    {
        // builder.Services.ConfigureSwaggerGen(c => c.OperationFilter<AddHeaderOperationFilter>("Range", "Requested range of values to return", false));
        return builder;
    }

    public static WebApplicationBuilder DescribeDataTypesToSwagger(this WebApplicationBuilder builder)
    {
        builder.Services.DescribeSendPulseId();
        builder.Services.DescribeBotApiToken();
        // builder.DescribeBotApiToken();
        // builder.DescribeSendPulseId();
        // builder.Services.ConfigureSwaggerGen(c =>
        // {
        //     c.MapType<SendPulseId>(
        //         () => new OpenApiSchema { Type = "string", Pattern = SendPulse.Data.ValueObjects.SendPulseId.RegexString  });
        //     c.MapType<BotApiToken>(
        //         () => new OpenApiSchema { Type = "string", Pattern = SendPulse.Data.ValueObjects.BotApiToken.RegexString  });
        // });
        return builder;
    }

    public static OpenApiInfo DefaultOpenApiInfo(Type tThisAssemblyProject)
    {
        var versionString =
        IsNullOrEmpty(new ThisAssemblyProject(tThisAssemblyProject).PackageVersion) ?
            IsNullOrEmpty(new ThisAssemblyProject(tThisAssemblyProject).FileVersion) ?
                IsNullOrEmpty(new ThisAssemblyProject(tThisAssemblyProject).Version) ?
                    IsNullOrEmpty(new ThisAssemblyProject(tThisAssemblyProject).AssemblyVersion) ?
                        "v0.0.1-Preview" :
                        new ThisAssemblyProject(tThisAssemblyProject).AssemblyVersion :
                    new ThisAssemblyProject(tThisAssemblyProject).Version :
                new ThisAssemblyProject(tThisAssemblyProject).FileVersion :
            new ThisAssemblyProject(tThisAssemblyProject).PackageVersion;

        var packageTags = new OpenApiArray();
        packageTags.AddRange(new ThisAssemblyProject(tThisAssemblyProject).PackageTags.Split(" ").Select(tag => new OpenApiString(tag)));

        return new()
        {
            Title = new ThisAssemblyProject(tThisAssemblyProject).Title,
            Version = versionString,
            Description = new ThisAssemblyProject(tThisAssemblyProject).Description,
            TermsOfService = !string.IsNullOrEmpty(new ThisAssemblyProject(tThisAssemblyProject).TermsOfServiceUrl)
                ? new Uri(new ThisAssemblyProject(tThisAssemblyProject).TermsOfServiceUrl)
                : null,
            Extensions =
            {
                [nameof(ThisAssemblyProject.PackageProjectUrl)]
                    = new OpenApiString(new ThisAssemblyProject(tThisAssemblyProject).PackageProjectUrl),
                [nameof(ThisAssemblyProject.RepositoryUrl)]
                    = new OpenApiString(new ThisAssemblyProject(tThisAssemblyProject).RepositoryUrl),
                ["Tags"] = packageTags
            },
            Contact = new()
            {
                Name = new ThisAssemblyProject(tThisAssemblyProject).Company,
                Email = new ThisAssemblyProject(tThisAssemblyProject).ContactEmail,
                Url = new(new ThisAssemblyProject(tThisAssemblyProject).PackageProjectUrl),
                Extensions =
                {
                    [nameof(ThisAssemblyProject.Authors)] = new OpenApiString(new ThisAssemblyProject(tThisAssemblyProject).Authors),
                    [nameof(ThisAssemblyProject.Owners)] = new OpenApiString(new ThisAssemblyProject(tThisAssemblyProject).Owners)
                }
            },
            License = new()
            {
                Name =new ThisAssemblyProject(tThisAssemblyProject).LicenseExpression,
                Url = new($"https://opensource.org/licenses/{new ThisAssemblyProject(tThisAssemblyProject).LicenseExpression}")
            }
        };
    }

//     public static WebApplicationBuilder DescribeAnyOfTypes(this WebApplicationBuilder builder)
//     {
//         builder.Services.ConfigureSwaggerGen(options =>
//             options.MapType(typeof(AnyOfTypes.AnyOf<>), > new OpenApiSchema
//             {
//                 Type = "object",
//                 Schema
//                 Description = "A SendPulseId is a 24-character hexadecimal string that uniquely identifies a SendPulse entity."
//             })
//         });
//     }
}
