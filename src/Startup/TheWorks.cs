namespace Microsoft.Extensions.DependencyInjection;

using System.Net.Http.Headers;

using System.Net.Mime.MediaTypes;
using JustinWritesCode.AspNetCore.Authorization;
using JustinWritesCode.AspNetCore.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SendPulse.Data.ValueObjects;
using AutoMapper;
public static class AddTheWorksExtensions
{
    public static WebApplicationBuilder AddTheWorks(this WebApplicationBuilder builder, type? tThisAssemblyProject = null, IEnumerable<type>? typesToUseForAutoMapper = default, Action<WebApplicationBuilder>? configure = default)
    {
        builder.Logging
               .AddConfiguration(builder.Configuration.GetSection("Logging"))
               .AddConsole()
               .AddDebug();

        builder.AddIdentity();

        typesToUseForAutoMapper ??= System.AppDomain.CurrentDomain.GetAssemblies()
                                                            .SelectMany(a => a.GetTypes());
        builder.Services.AddAutoMapper(typesToUseForAutoMapper.ToArray());

        tThisAssemblyProject ??= typeof(ThisAssembly.Project);
        builder.Services.AddSwaggerGen();
        builder.AddSwaggerMetadata(tThisAssemblyProject)
               .DescribeDataTypesToSwagger()
               .DescribeBasicApiAuthentication()
               .AddXmlCommentsToSwagger()
               .DescribeCrudController()
               .AddSwaggerExamples()
               .AddSwaggerHeaderOperationFilter();

        builder.Services
               .AddControllers()
               .AddXmlSerializerFormatters();

        builder.Services.AddRazorPages();

        builder.AddJsonPatch();

        builder.Configuration.AddUserSecrets(tThisAssemblyProject.Assembly);
        builder.AddAzureAppConfig();

        builder.AddHttpLogging();

        builder.AddApiAuthentication();

        builder.AddApiAuthentication(_ => { });

        builder.AddOutputFormatters();

        builder.Services.AddHealthChecks();

        builder.AddPayloadServices();

        builder.DescribeIdentityDataTypes();

        builder.DescribeSchemasViaAttributes();

        builder.AddHashids();

        // builder.();

        // builder.AddProblemDetailsHandler();

        configure?.Invoke(builder);
        return builder;
    }

    public static WebApplication UseTheWorks(this WebApplication app, Type tThisAssemblyProject)
    {
        app.Use((context, next) =>
        {
            context.Response.Headers.AcceptRanges = "items";
            context.Response.Headers[HttpResponseHeaderNames.AcceptPatch] = ApplicationMediaTypeNames.JsonPatch;
            return next();
        });

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

        app.UseWelcomePage(new WelcomePageOptions { Path = "/welcome" });

        app.MapPing();

        app.UseApiBasicAuthentication();

        app.MapControllers();

        app.MapRazorPages();

        return app;
    }

    public static WebApplication UseTheWorks(this WebApplication app, Type tThisAssemblyProject, Action<WebApplication>? configure)
    {
        app.UseTheWorks(tThisAssemblyProject);
        configure?.Invoke(app);
        return app;
    }

    internal static bool IsLocal(this IHostEnvironment env) => env.IsEnvironment("Local");
    internal static bool IsDevelopment(this IHostEnvironment env) => env.IsEnvironment("Development");
}
