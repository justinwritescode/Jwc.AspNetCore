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
            c.SwaggerDoc(openApiInfo.Version, openApiInfo);
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
        builder.Services.Describe<uri>();
        builder.Services.Describe<ObjectId>();
        builder.Services.Describe<System.Domain.PhoneNumber>();
        builder.Services.Describe<System.Net.Mail.EmailAddress>();
        builder.Services.DescribeBotApiToken();
        return builder;
    }

    public static OpenApiInfo DefaultOpenApiInfo(Type tThisAssemblyProject)
    {
        var thisAssemblyProject = new ThisAssemblyProject(tThisAssemblyProject);
        var versionString = thisAssemblyProject.ApiVersion;

        var packageTags = new OpenApiArray();
        packageTags.AddRange(thisAssemblyProject.PackageTags.Split(" ").Select(tag => new OpenApiString(tag)));

        return new()
        {
            Title = thisAssemblyProject.Title,
            Version = versionString,
            Description = thisAssemblyProject.Description,
            TermsOfService = thisAssemblyProject.TermsOfServiceUrl,
            Extensions =
            {
                [nameof(ThisAssemblyProject.PackageProjectUrl)]
                    = new OpenApiString(thisAssemblyProject.PackageProjectUrl),
                [nameof(ThisAssemblyProject.RepositoryUrl)]
                    = new OpenApiString(thisAssemblyProject.RepositoryUrl),
                ["Tags"] = packageTags
            },
            Contact = new()
            {
                Name = thisAssemblyProject.Company,
                Email = new ThisAssemblyProject(tThisAssemblyProject).ContactEmail,
                Url = thisAssemblyProject.PackageProjectUrl,
                Extensions =
                {
                    [nameof(ThisAssemblyProject.Authors)] = new OpenApiString(thisAssemblyProject.Authors),
                    [nameof(ThisAssemblyProject.Owners)] = new OpenApiString(thisAssemblyProject.Owners)
                }
            },
            License = new()
            {
                Name = thisAssemblyProject.LicenseExpression,
                Url = thisAssemblyProject.LicenseUrl
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
//                 Description = "A ObjectId is a 24-character hexadecimal string that uniquely identifies a SendPulse entity."
//             })
//         });
//     }
}
