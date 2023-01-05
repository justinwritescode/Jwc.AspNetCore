/*
 * UseSwaggerUI.cs
 *
 *   Created: 2022-12-14-04:11:17
 *   Modified: 2022-12-14-04:11:17
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Net.Mime.MediaTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class UseSwaggerUIExtensions
{
    private static readonly Assembly _assembly = typeof(UseSwaggerUIExtensions).Assembly;

    private static string CustomCss(string resourceName) =>
        new StreamReader(_assembly.GetManifestResourceStream(resourceName)).ReadToEnd();

    const string ExampleCss = """"
    @charset "UTF-8";
    .swagger-ui html {
    box-sizing: border-box
    }

    .swagger-ui *, .swagger-ui :after, .swagger-ui :before {
    box-sizing: inherit
    }

    .swagger-ui body {
    margin: 0;
    background: #fafafa
    }

    .swagger-ui .wrapper {
    width: 100%;
    max-width: 1460px;
    margin: 0 auto;
    padding: 0 20px
    }

    .swagger-ui .opblock-tag-section {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column
    }

    etc. etc. etc...
    """";

    static readonly OpenApiString _exampleCssOpenApiString = new(ExampleCss);

    public static WebApplication UseCustomizedSwaggerUI<TAssemblyResource>(
        this WebApplication app,
        type tThisAssemblyProject,
        string? indexDocumentAssemblyResourceName = "SwaggerUI.index.html",
        string? swaggerTheme = null
    )
    {
        var thisAssemblyProject = new ThisAssemblyProject(tThisAssemblyProject);
        _ = app.UseSwagger(options =>
        {
            options.RouteTemplate = "/swagger/{documentName}/swagger.json";
        });
        _ = app.UseSwaggerUI(options =>
        {
            options.RoutePrefix = string.Empty;
            options.DefaultModelExpandDepth(0);
            options.DefaultModelRendering(ModelRendering.Model);
            options.DocExpansion(DocExpansion.None);
            options.DisplayOperationId();
            options.DisplayRequestDuration();
            options.EnableDeepLinking();
            options.EnableFilter();
            options.EnableTryItOutByDefault();
            options.EnablePersistAuthorization();
            options.ShowExtensions();
            options.ShowCommonExtensions();
            options.EnableValidator();
            options.SupportedSubmitMethods(
                SubmitMethod.Get,
                SubmitMethod.Post,
                SubmitMethod.Put,
                SubmitMethod.Delete,
                SubmitMethod.Patch,
                SubmitMethod.Head,
                SubmitMethod.Options,
                SubmitMethod.Trace
            );
            options.InjectStylesheet("/swagger-ui/SwaggerUI.custom.css");
            try
            {
                options.IndexStream = () =>
                    typeof(TAssemblyResource).Assembly.GetManifestResourceStream(
                        indexDocumentAssemblyResourceName
                    );
            }
            catch
            {
                app.Logger.CannotLoadIndexDocument(indexDocumentAssemblyResourceName);
            }

            options.SwaggerEndpoint(
                $"/swagger/{thisAssemblyProject.ApiVersion}/swagger.json",
                $"{thisAssemblyProject.Title} v{thisAssemblyProject.Version}"
            );
        });

        _ = app.MapGet("swagger-ui.css", () =>
            """/* Begin Swagger UI Base CSS */""" +
            CustomCss("swagger-ui.css") +
            """/* End Swagger UI Base CSS */""" +
            """/* Begin Swagger UI Custom CSS */""" +
            CustomCss("SwaggerUI.swagger-ui.css") +
            """/* End Swagger UI Custom CSS */"""
            )
            .WithOpenApi(op =>
            {
                op.Responses["200"] = new OpenApiResponse
                {
                    Description = "Swagger UI CSS",
                    Content =
                    {
                        [TextMediaTypeNames.Css] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema
                            {
                                Type = TextMediaTypeNames.Css,
                                Description = "swagger ui css"
                            },
                            Example = _exampleCssOpenApiString
                        }
                    }
                };
                return op;
            })
            .Produces<string>(Status200OK, System.Net.Mime.MediaTypes.TextMediaTypeNames.Css);

        _ = app.MapGet(
                "/swagger-ui/SwaggerUI.custom.css",
                () =>
                    CustomCss(
                        swaggerTheme ?? new ThisAssemblyProject(tThisAssemblyProject).SwaggerTheme
                    )
            )
            .WithOpenApi(op =>
            {
                op.Responses["200"] = new OpenApiResponse
                {
                    Description = "Custom CSS",
                    Content =
                    {
                        [TextMediaTypeNames.Css] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema
                            {
                                Type = TextMediaTypeNames.Css,
                                Description = "custom css"
                            },
                            Example = _exampleCssOpenApiString
                        }
                    }
                };
                return op;
            })
            .Produces<string>(Status200OK, System.Net.Mime.MediaTypes.TextMediaTypeNames.Css);

        foreach (var cssFile in _assembly.GetManifestResourceNames().Where(x => x.EndsWith(".css")))
        {
            _ = app.MapGet($"/swagger-ui/{cssFile}", () => CustomCss(cssFile))
                .WithOpenApi(op =>
                {
                    op.Responses["200"] = new OpenApiResponse
                    {
                        Description = "Custom CSS - " + cssFile,
                        Content =
                        {
                            [TextMediaTypeNames.Css] = new OpenApiMediaType
                            {
                                Schema = new OpenApiSchema
                                {
                                    Type = TextMediaTypeNames.Css,
                                    Description = "custom css"
                                },
                                Example = _exampleCssOpenApiString
                            }
                        }
                    };
                    return op;
                })
                .Produces<string>(Status200OK, System.Net.Mime.MediaTypes.TextMediaTypeNames.Css);
        }

        _ = app.MapGet(
            $"/swagger/{thisAssemblyProject.Version}/swagger.json",
            ctx =>
            {
                ctx.Response.Redirect($"/swagger/v1/swagger.json");
                return Task.CompletedTask;
            }
        );
        // app.Services.GetRequiredService<ISwaggerProvider>().GetSwagger(thisAssemblyProject.Version, null, null)

        _ = app.UseReDoc(opts =>
        {
            opts.HeadContent +=
                "<script type=\"application/javascript\" src=\"https://cdn.jsdelivr.net/npm/redoc-try-it-out/dist/try-it-out.min.js\"></script>";
            opts.HeadContent +=
                @"<script>
    var redoc_container = document.createElement(""div"");
    document.body.appendChild(redoc_container);
    RedocTryItOut.init(
        ""/swagger/v1/swagger.json"",
        { title: ""Pet Store"" },
        redoc_container
    );
</script>";
        });

        return app;
    }

    [LoggerMessage(
        EventId = 0,
        Level = LogLevel.Warning,
        Message = "Cannot load index document from assembly resource '{indexDocumentAssemblyResourceName}'."
    )]
    internal static partial void CannotLoadIndexDocument(
        this ILogger logger,
        string indexDocumentAssemblyResourceName
    );

    public static WebApplication UseCustomizedSwaggerUI(
        this WebApplication app,
        Type tThisAssemblyProject,
        string indexDocumentAssemblyResourceName = "SwaggerUI.index.html",
        string? swaggerTheme = null
    ) =>
        app.UseCustomizedSwaggerUI<Foo>(
            tThisAssemblyProject,
            indexDocumentAssemblyResourceName,
            swaggerTheme
        );

    internal sealed class Foo { }
}
