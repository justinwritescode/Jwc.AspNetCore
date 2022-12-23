/*
 * PingController.cs
 *
 *   Created: 2022-12-06-10:35:09
 *   Modified: 2022-12-06-10:35:09
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Controllers;

using System.Net.Mime.MediaTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public static class PingExtensions
{
    /// <symmary>Adds a simple health check to the app</symmary>
    public static WebApplication MapPing(this WebApplication app)
    {
        app.MapGet("/ping", () => "pong")
           .Produces<string>(contentType: TextMediaType.Plain.DisplayName)
           .AllowAnonymous()
           .WithDisplayName("Ping")
           .WithName("Ping")
           .WithTags("Diagnostics")
           .WithOpenApi();

        app.MapHealthChecks(
            "/health-check",
            new (){
                AllowCachingResponses = false,
                ResponseWriter = async (ctx, rpt) => await ctx.Response.WriteAsJsonAsync(rpt),
                Predicate = _ => true })
            .AllowAnonymous();

        return app;
    }
}
