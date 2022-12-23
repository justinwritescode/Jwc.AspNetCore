/*
 * UseSwaggerUI.cs
 *
 *   Created: 2022-12-14-04:11:17
 *   Modified: 2022-12-14-04:11:17
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Microsoft.Extensions.DependencyInjection;

public static partial class UseSwaggerUIExtensions
{
    private static readonly Assembly _assembly = typeof(UseSwaggerUIExtensions).Assembly;
    private static string CustomCss(string resourceName) => new StreamReader(_assembly.GetManifestResourceStream(resourceName)).ReadToEnd();

    public static WebApplication UseCustomizedSwaggerUI<TAssemblyResource>(this WebApplication app, Type tThisAssemblyProject, string? indexDocumentAssemblyResourceName = null, string? swaggerTheme = null)
    {
        var thisAssemblyProject = new ThisAssemblyProject(tThisAssemblyProject);
        app.UseSwagger(options =>
        {
            options.RouteTemplate = "/swagger/{documentName}/swagger.json";
        });
        _ = app.UseSwaggerUI(options =>
        {
            options.RoutePrefix = string.Empty;
            options.DefaultModelExpandDepth(0);
            options.DefaultModelRendering(ModelRendering.Model);
            options.DocExpansion(DocExpansion.List);
            options.DisplayOperationId();
            options.DisplayRequestDuration();
            options.EnableDeepLinking();
            options.EnableFilter();
            options.EnableTryItOutByDefault();
            options.EnablePersistAuthorization();
            options.ShowExtensions();
            options.ShowCommonExtensions();
            options.EnableValidator();
            options.SupportedSubmitMethods(SubmitMethod.Get, SubmitMethod.Post, SubmitMethod.Put, SubmitMethod.Delete, SubmitMethod.Patch, SubmitMethod.Head, SubmitMethod.Options, SubmitMethod.Trace);
            options.InjectStylesheet("/swagger-ui/custom.css");
            try { options.IndexStream = () => typeof(TAssemblyResource).Assembly.GetManifestResourceStream(indexDocumentAssemblyResourceName); }
            catch { app.Logger.CannotLoadIndexDocument(indexDocumentAssemblyResourceName); }

            options.SwaggerEndpoint(
                $"/swagger/v1/swagger.json",
                $"{thisAssemblyProject.Title} v{thisAssemblyProject.Version}");
        });

        app.MapGet("/swagger-ui/SwaggerUI.custom.css", () => CustomCss(swaggerTheme ?? new ThisAssemblyProject(tThisAssemblyProject).SwaggerTheme));
        app.MapGet($"/swagger/{thisAssemblyProject.Version}/swagger.json", ctx => { ctx.Response.Redirect($"/swagger/v1/swagger.json"); return Task.CompletedTask; });
            // app.Services.GetRequiredService<ISwaggerProvider>().GetSwagger(thisAssemblyProject.Version, null, null)

        app.UseReDoc(opts =>
        {
            opts.HeadContent += "<script type=\"application/javascript\" src=\"https://cdn.jsdelivr.net/npm/redoc-try-it-out/dist/try-it-out.min.js\"></script>";
            opts.HeadContent += @"<script>
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

    [LoggerMessage(EventId = 0, Level = LogLevel.Warning, Message = "Cannot load index document from assembly resource '{indexDocumentAssemblyResourceName}'.")]
    internal static partial void CannotLoadIndexDocument(this ILogger logger, string indexDocumentAssemblyResourceName);

    public static WebApplication UseCustomizedSwaggerUI(this WebApplication app, Type tThisAssemblyProject, string indexDocumentAssemblyResourceName = "SwaggerUI.index.html", string? swaggerTheme = null)
        => app.UseCustomizedSwaggerUI<Foo>(tThisAssemblyProject, indexDocumentAssemblyResourceName, swaggerTheme);

    internal class Foo { }
}
