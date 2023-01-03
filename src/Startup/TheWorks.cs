namespace Microsoft.Extensions.DependencyInjection;

using System.Net.Http.Headers;
using System.Net.Mime.MediaTypes;
using AutoMapper;
using JustinWritesCode.AspNetCore.Authentication;
using JustinWritesCode.AspNetCore.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public static class AddTheWorksExtensions
{
    public static WebApplicationBuilder AddTheWorks(
        this WebApplicationBuilder builder,
        type? tThisAssemblyProject = null,
        IEnumerable<type>? typesToUseForAutoMapperAndMediatR = default,
        Action<WebApplicationBuilder>? configure = default
    )
    {
        builder.Logging
            .AddConfiguration(builder.Configuration.GetSection("Logging"))
            .AddConsole()
            .AddDebug();

        builder.AddIdentity();

        typesToUseForAutoMapperAndMediatR = (
            typesToUseForAutoMapperAndMediatR ??= Empty<type>()
        ).Concat(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()));

        builder.Services.AddAutoMapper(typesToUseForAutoMapperAndMediatR.ToArray());

        tThisAssemblyProject ??= typeof(ThisAssembly.Project);
        builder
            .AddSwaggerGen()
            .AddSwaggerMetadata(tThisAssemblyProject)
            .DescribeDataTypesToSwagger()
            .DescribeBasicApiAuthentication()
            .AddXmlCommentsToSwagger()
            .DescribeCrudController()
            .AddSwaggerExamples()
            .AddSwaggerHeaderOperationFilter()
            .DescribeFileUploads();

        builder.Services.AddControllers().AddXmlSerializerFormatters();

        builder.Services.AddRazorPages();

        builder.AddJsonPatch();

        builder.Configuration.AddUserSecrets(tThisAssemblyProject.Assembly);
        builder.AddAzureAppConfig();

        builder.AddHttpLogging();

        builder.AddApiAuthentication();

        // builder.AddApiAuthentication(_ => { });

        builder.AddFormatters();

        builder.Services.AddHealthChecks();

        builder.AddPayloadServices();

        // builder.DescribeIdentityDataTypes();

        builder.DescribeSchemasViaAttributes();

        builder.AddHashids();

        builder.Services.AddMediatR(typesToUseForAutoMapperAndMediatR.ToArray());

        // builder.();

        // builder.AddProblemDetailsHandler();

        configure?.Invoke(builder);
        return builder;
    }

    public static WebApplication UseTheWorks(this WebApplication app, Type tThisAssemblyProject)
    {
        app.Use(
            (context, next) =>
            {
                context.Response.Headers.AcceptRanges = "items";
                context.Response.Headers[HttpResponseHeaderNames.AcceptPatch] =
                    ApplicationMediaTypeNames.JsonPatch;
                return next();
            }
        );

        app.UseHttpLogging();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment() || app.Environment.IsLocal())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseStatusCodePages();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseSwagger();
        // app.UseSwaggerUI();
        app.UseCustomizedSwaggerUI(tThisAssemblyProject);

        app.UseApiBasicAuthentication();

        app.UseWelcomePage(new WelcomePageOptions { Path = "/welcome" });

        app.MapPing();

        app.MapRazorPages();

        app.MapControllers();

        return app;
    }

    public static WebApplication UseTheWorks(
        this WebApplication app,
        Type tThisAssemblyProject,
        Action<WebApplication>? configure
    )
    {
        app.UseTheWorks(tThisAssemblyProject);
        configure?.Invoke(app);
        return app;
    }

    internal static bool IsLocal(this IHostEnvironment env) => env.IsEnvironment("Local");

    internal static bool IsDevelopment(this IHostEnvironment env) =>
        env.IsEnvironment("Development");
}
