namespace Microsoft.Extensions.DependencyInjection;

using System.Net.Http.Headers;
using System.Net.Mime.MediaTypes;
using AutoMapper;
using JustinWritesCode.AspNetCore.Authentication;
using JustinWritesCode.AspNetCore.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Rewrite;
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
        _ = builder.Logging
            .AddConfiguration(builder.Configuration.GetSection("Logging"))
            .AddConsole()
            .AddDebug();

        _ = builder.AddIdentity();

        typesToUseForAutoMapperAndMediatR = (
            typesToUseForAutoMapperAndMediatR ??= Empty<type>()
        ).Concat(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()));

        _ = builder.Services.AddAutoMapper(typesToUseForAutoMapperAndMediatR.ToArray());

        tThisAssemblyProject ??= typeof(ThisAssembly.Project);
        _ = builder
            .AddSwaggerGen()
            .AddSwaggerMetadata(tThisAssemblyProject)
            .DescribeDataTypesToSwagger()
            .DescribeBasicApiAuthentication()
            .AddXmlCommentsToSwagger()
            .DescribeCrudController()
            .AddSwaggerExamples()
            .AddSwaggerHeaderOperationFilter()
            .DescribeFileUploads()
            .AddDescribeTypesForAllOutputFormatters();

        _ = builder.Services.AddControllers().AddXmlSerializerFormatters();

        _ = builder.Services.AddRazorPages();

        _ = builder.AddJsonPatch();

        _ = builder.Configuration.AddUserSecrets(tThisAssemblyProject.Assembly);
        _ = builder.AddAzureAppConfig();

        _ = builder.AddHttpLogging();

        _ = builder.AddApiAuthentication();

        // builder.AddApiAuthentication(_ => { });

        _ = builder.AddFormatters();

        _ = builder.Services.AddHealthChecks();

        _ = builder.AddPayloadServices();

        // builder.DescribeIdentityDataTypes();

        _ = builder.DescribeSchemasViaAttributes();

        _ = builder.AddHashids();

        _ = builder.Services.AddMediatR(typesToUseForAutoMapperAndMediatR.ToArray());

        _ = builder.AddJsonSerializer();

        // builder.();

        // builder.AddProblemDetailsHandler();

        configure?.Invoke(builder);
        return builder;
    }

    public static WebApplication UseTheWorks(this WebApplication app, Type tThisAssemblyProject)
    {
        _ = app.Use(
            (context, next) =>
            {
                context.Response.Headers.AcceptRanges = "items";
                context.Response.Headers[HttpResponseHeaderNames.AcceptPatch] =
                    ApplicationMediaTypeNames.JsonPatch;
                return next();
            }
        );

        _ = app.UseHttpLogging();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment() || app.Environment.IsLocal())
        {
            _ = app.UseDeveloperExceptionPage();
        }
        else
        {
            _ = app.UseStatusCodePages();
        }

        _ = app.UseHttpsRedirection();

        _ = app.UseStaticFiles();

        _ = app.UseSwagger();
        // app.UseSwaggerUI();
        _ = app.UseCustomizedSwaggerUI(tThisAssemblyProject);

        _ = app.UseApiBasicAuthentication();

        _ = app.UseWelcomePage(new WelcomePageOptions { Path = "/welcome" });

        _ = app.MapPing();

        _ = app.MapRazorPages();

        _ = app.MapControllers();


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
