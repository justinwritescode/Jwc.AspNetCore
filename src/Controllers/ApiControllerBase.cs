/*
 * ApiControllerBase.cs
 *
 *   Created: 2022-12-10-05:39:52
 *   Modified: 2022-12-10-05:39:52
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Controllers;

using System.Collections.Generic;
using System.Net.Mime.MediaTypes;
using JustinWritesCode.Abstractions;
using JustinWritesCode.AspNetCore.ProblemDetailsExamples;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using global::Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using static Microsoft.AspNetCore.Http.StatusCodes;

[ApiController]
[Route("api/[controller]")]
[Produces(ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, TextMediaTypeNames.Plain)]
[Consumes(ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, TextMediaTypeNames.Plain)]
[ProducesErrorResponseType(typeof(ProblemDetails))]
[ProducesResponseType(typeof(ValidationProblemDetails), Status400BadRequest, ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, TextMediaTypeNames.Plain)]
[ProducesResponseType(typeof(ProblemDetails), Status401Unauthorized, ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, TextMediaTypeNames.Plain)]
[ProducesResponseType(typeof(ProblemDetails), Status403Forbidden, ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, TextMediaTypeNames.Plain)]
[ProducesResponseType(typeof(ProblemDetails), Status404NotFound, ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, TextMediaTypeNames.Plain)]
[ProducesResponseType(typeof(ProblemDetails), Status500InternalServerError, ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, TextMediaTypeNames.Plain)]
[SwaggerResponse(Status400BadRequest, "Bad Request", typeof(ValidationProblemDetails))]
[SwaggerResponse(Status401Unauthorized, "Unauthorized", typeof(ProblemDetails))]
[SwaggerResponse(Status404NotFound, "Not Foundd", typeof(ProblemDetails))]
[SwaggerResponse(Status500InternalServerError, "Internal Server Error", typeof(ProblemDetails))]
[SwaggerResponseExample(Status400BadRequest, typeof(BadRequestProblemDetailsExample))]
[SwaggerResponseExample(Status401Unauthorized, typeof(UnauthorizedProblemDetailsExample))]
[SwaggerResponseExample(Status404NotFound, typeof(NotFoundProblemDetailsExample))]
[SwaggerResponseExample(Status500InternalServerError, typeof(InternalServerErrorProblemDetailsExample))]
// [Authorize]
public abstract class ApiControllerBase : ControllerBase, ILog
{
    public ILogger Logger { get; }
    public ApiControllerBase(ILogger logger)
    {
        Logger = logger;
    }
}

public abstract class ApiControllerBase<TDbContext> : ApiControllerBase, Microsoft.EntityFrameworkCore.Abstractions.IHaveADbContext<TDbContext>
    where TDbContext : DbContext, Microsoft.EntityFrameworkCore.Abstractions.IDbContext<TDbContext>
{
    DbContext Microsoft.EntityFrameworkCore.Abstractions.IHaveADbContext.Db => Db;
    public TDbContext Db { get; }
    public ApiControllerBase(TDbContext dbContext, ILogger logger) : base(logger)
    {
        Db = dbContext;
    }
}