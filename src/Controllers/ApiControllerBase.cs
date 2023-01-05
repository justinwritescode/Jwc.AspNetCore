/*
 * ApiControllerBase.cs
 *
 *   Created: 2022-12-10-05:39:52
 *   Modified: 2022-12-10-05:39:52
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Controllers;

using System.Net.Mime.MediaTypes;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.Extensions.Logging;

using JustinWritesCode.Abstractions;
using JustinWritesCode.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Produces400Error, Produces401Error, Produces403Error, Produces404Error, Produces500Error]
public abstract class ApiControllerBase : ControllerBase, ILog
{
    public ILogger Logger { get; }

    public ApiControllerBase(ILogger logger) => Logger = logger;
}

public abstract class ApiControllerBase<TDbContext> : ApiControllerBase, IHaveADbContext<TDbContext>
    where TDbContext : IDbContext, IDbContext<TDbContext>
{
    IDbContext IHaveADbContext.Db => Db;
    public TDbContext Db { get; }

    public ApiControllerBase(TDbContext dbContext, ILogger logger) : base(logger) => Db = dbContext;
}
