namespace Microsoft.Extensions.DependencyInjection;

using System.Net.Http.Headers;
using System.Net.Mime.MediaTypes;
using JustinWritesCode.AspNetCore.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public interface IStartupParameters
{
    type? ThisAssemblyProject { get; set; }
    IEnumerable<type>? TypesForAutoMapperAndMediatR { get; set; }
    bool AddIdentity { get; set; }
    bool AddSwagger { get; set; }
    IEnumerable<string> AuthenticationSchemes { get; set; }
    bool AddXmlSerialization { get; set; }
    bool SearchEntireAppDomainForAutoMapperAndMediatRTypes { get; set; }
    bool AddRazorPages { get; set; }
    bool AddJsonPatch { get; set; }
    bool AddApiAuthentication { get; set; }
    bool AddAzureAppConfig { get; set; }
    bool AddHashids { get; set; }
    bool AddMediatR { get; set; }
    bool AddAutoMapper { get; set; }
    bool AddLogging { get; set; }
    bool AddHttpLogging { get; set; }
    bool AddConsoleLogger { get; set; }
    bool AddDebugLogger { get; set; }
    bool AddHealthChecks { get; set; }

    bool Equals(object obj);
    bool Equals(StartupParameters other);
    int GetHashCode();
    string ToString();
}

public record struct StartupParameters : IStartupParameters
{
    public StartupParameters() { }

    public type? ThisAssemblyProject { get; set; } = null;
    public IEnumerable<type>? TypesForAutoMapperAndMediatR { get; set; } = Array.Empty<type>();
    public bool AddIdentity { get; set; } = true;
    public bool AddSwagger { get; set; } = true;
    public IEnumerable<string> AuthenticationSchemes { get; set; } = new[] { JustinWritesCode.AspNetCore.Authentication.ApiBasicAuthenticationOptions.AuthenticationSchemeName };
    public bool AddXmlSerialization { get; set; } = true;
    public bool SearchEntireAppDomainForAutoMapperAndMediatRTypes { get; set; } = true;
    public bool AddRazorPages { get; set; } = true;
    public bool AddJsonPatch { get; set; } = true;
    public bool AddApiAuthentication { get; set; } = true;
    public bool AddAzureAppConfig { get; set; } = true;
    public bool AddHashids { get; set; } = true;
    public bool AddMediatR { get; set; } = true;
    public bool AddAutoMapper { get; set; } = true;
    public bool AddLogging { get; set; } = true;
    public bool AddHttpLogging { get; set; } = true;
    public bool AddConsoleLogger { get; set; } = true;
    public bool AddDebugLogger { get; set; } = true;
    public bool AddHealthChecks { get; set; } = true;
}

public static class AddTheWorksExtensions
{
    public static WebApplicationBuilder AddTheWorks(
        this WebApplicationBuilder builder,
        IStartupParameters @params = default,
        Action<WebApplicationBuilder>? configure = default
    )
    {
        if (@params.AddLogging)
            _ = builder.Logging
                .AddConfiguration(builder.Configuration.GetSection("Logging"));

        if (@params.AddConsoleLogger)
            builder.Logging.AddConsole();

        if (@params.AddDebugLogger)
            builder.Logging.AddDebug();

        if (@params.AddIdentity)
            _ = builder.AddIdentity();

        @params.TypesForAutoMapperAndMediatR ??= Empty<type>();

        if (@params.SearchEntireAppDomainForAutoMapperAndMediatRTypes)
            @params.TypesForAutoMapperAndMediatR = @params.TypesForAutoMapperAndMediatR.Concat(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()));

        if (@params.AddAutoMapper)
            _ = builder.Services.AddAutoMapper(@params.TypesForAutoMapperAndMediatR.ToArray());

        if (@params.AddSwagger)
            _ = builder.AddSwaggerGen()
                .AddSwaggerMetadata(@params.ThisAssemblyProject ?? typeof(ThisAssembly.Project))
                .DescribeDataTypesToSwagger()
                .DescribeBasicApiAuthentication()
                .AddXmlCommentsToSwagger()
                .DescribeCrudController()
                .AddSwaggerExamples()
                .AddSwaggerHeaderOperationFilter()
                .DescribeFileUploads()
                .AddDescribeTypesForAllOutputFormatters();

        if (@params.AddXmlSerialization)
            _ = builder.Services.AddControllers().AddXmlSerializerFormatters();

        if (@params.AddRazorPages)
            _ = builder.Services.AddRazorPages();

        if (@params.AddJsonPatch)
            _ = builder.AddJsonPatch();


        _ = builder.Configuration.AddUserSecrets(@params.ThisAssemblyProject.Assembly);

        if (@params.AddAzureAppConfig)
            _ = builder.AddAzureAppConfig();

        if (@params.AddApiAuthentication)
            _ = builder.AddApiAuthentication();

        if (@params.AddHttpLogging)
            _ = builder.AddHttpLogging();

        // builder.AddApiAuthentication(_ => { });

        _ = builder.AddFormatters();

        if (@params.AddHealthChecks)
            _ = builder.Services.AddHealthChecks();

        _ = builder.AddPayloadServices();

        // builder.DescribeIdentityDataTypes();

        _ = builder.DescribeSchemasViaAttributes();

        if (@params.AddHashids)
            _ = builder.AddHashids();

        if (@params.AddMediatR)
            _ = builder.Services.AddMediatR(@params.TypesForAutoMapperAndMediatR.ToArray());

        _ = builder.AddJsonSerializer();

        // builder.();

        // builder.AddProblemDetailsHandler();

        builder.Services.AddSingleton<IStartupParameters>(@params);

        configure?.Invoke(builder);
        return builder;
    }

    public static WebApplication UseTheWorks(this WebApplication app, type tThisAssemblyProject)
    {
        var @params = app.Services.GetRequiredService<IStartupParameters>();

        if (@params.AddJsonPatch)
            _ = app.Use(
                (context, next) =>
                {
                    context.Response.Headers.AcceptRanges = "items";
                    context.Response.Headers[HttpResponseHeaderNames.AcceptPatch] =
                        ApplicationMediaTypeNames.JsonPatch;
                    return next();
                }
            );

        if (@params.AddHttpLogging)
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

        if (@params.AddSwagger)
        {
            _ = app.UseSwagger();
            // app.UseSwaggerUI();
            _ = app.UseCustomizedSwaggerUI(@params.ThisAssemblyProject ?? typeof(ThisAssembly.Project));
        }

        _ = app.UseRequestDecompression()
            .UseResponseCompression()
            .UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

        if (@params.AddApiAuthentication)
            _ = app.UseApiBasicAuthentication();

        _ = app.UseWelcomePage(new WelcomePageOptions { Path = null });

        _ = app.MapPing();

        _ = app.MapRazorPages();

        _ = app.MapControllers();

        return app;
    }

    public static WebApplication UseTheWorks(
        this WebApplication app,
        type tThisAssemblyProject,
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
