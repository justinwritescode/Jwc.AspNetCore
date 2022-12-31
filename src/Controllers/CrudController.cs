/*
 * CrudController.cs
 *
 *   Created: 2022-12-06-10:36:22
 *   Modified: 2022-12-06-10:36:22
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
using System.Net.Http.Headers;
using System.Net.Mime.MediaTypes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using global::MediatR;
using JustinWritesCode.Abstractions;
using JustinWritesCode.Payloads;
using JustinWritesCode.Payloads.Abstractions;
using JustinWritesCode.Payloads.ModelBinders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace JustinWritesCode.AspNetCore.Controllers;

[Authorize]
[ApiController]
public abstract class CrudController<TModel, TDbContext, TId> : CrudController<TModel, TModel, TModel, TModel, TDbContext, TId>
    where TModel : class, IIdentifiable<TId>
    where TDbContext : IDbContext, IDbContext<TDbContext>
    where TId : IComparable, IEquatable<TId>
{
    public CrudController(TDbContext dbContext, ILogger logger, IMapper mapper, IMediator mediator) : base(dbContext, logger, mapper, mediator)
    {
    }
}

[Authorize]
[ApiController]
public abstract class CrudController<TModel, TDto, TDbContext, TId> : CrudController<TModel, TDto, TDto, TDto, TDbContext, TId>
    where TModel : class, IIdentifiable<TId>
    where TDbContext : IDbContext, IDbContext<TDbContext>
    where TId : IComparable, IEquatable<TId>
    where TDto : class
{
    public CrudController(TDbContext dbContext, ILogger logger, IMapper mapper, IMediator mediator) : base(dbContext, logger, mapper, mediator)
    {
    }
}
[Authorize]
[ApiController]
public abstract class CrudController<TModel, TInsertDto, TDto, TDbContext, TId> : CrudController<TModel, TInsertDto, TDto, TDto, TDbContext, TId>
    where TModel : class, IIdentifiable<TId>
    where TDbContext : IDbContext, IDbContext<TDbContext>
    where TId : IComparable, IEquatable<TId>
    where TDto : class
{
    public CrudController(TDbContext dbContext, ILogger logger, IMapper mapper, IMediator mediator) : base(dbContext, logger, mapper, mediator)
    {
    }
}

[Authorize]
[ApiController]
public abstract class CrudController<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId> : ApiControllerBase<TDbContext>, ILog, IHaveADbContext<TDbContext>
    where TModel : class, IIdentifiable<TId>
    where TDbContext : IDbContext, IDbContext<TDbContext>
    where TId : IComparable, IEquatable<TId>
    where TUpdateDto : class
{
    public const string DefaultItemSeparator = "\r\n";

    protected IMapper Mapper { get; }
    protected IMediator Mediator { get; }

    public CrudController(TDbContext dbContext, ILogger logger, IMapper mapper, IMediator mediator) : base(dbContext, logger)
    {
        Mapper = mapper;
        Mediator = mediator;
    }

    /// <summary>Retrieves a list of items.</summary>
    /// <returns>A list of items.</returns>
    /// <response code="200">Returns the complete list of items.</response>
    /// <response code="206">Returns a partial list of items.</response>
    /// <response code="401">If the user is not authorized.</response>
    /// <response code="403">If the user is not allowed to access the resource.</response>
    /// <response code="404">If the resource is not found.</response>
    /// <response code="500">If an unexpected error occurs.</response>
    /// <response code="503">If the service is unavailable.</response>
    /// <response code="504">If the service times out.</response>
    /// <param name="page" default="1">The page number to return</param>
    /// <param name="pageSize" default="MaxInt">The size of the page to return</param>
    /// <param name="itemSeparator" example="', '">The string to place in between items when rendering the payload as a plain text value</param>
    /// <param name="orderBy" default="'Id'">The name of the property to use to sort the returned items</param>
    /// <param name="sortDirection" example="'ascending' / 'descending'">Whether to sort the items in ascending or descending order</param>
    [HttpHead]
    [SwaggerResponseHeader(Status206PartialContent, HttpResponseHeaderNames.ContentRange, "content-range", "The range of item indices returned by the API", "content-range")]
    // [ProducesResponseType(typeof(Pager<>), (int)Status206PartialContent)]
    // [ProducesResponseType(typeof(SingleItemPager<>), (int)Status206PartialContent)]
    // [ProducesResponseType(typeof(Pager), (int)Status206PartialContent)]
    // [ProducesResponseType(typeof(SingleItemPager), (int)Status206PartialContent)]
    [SwaggerOperation(Summary = "See if there are any items to retrieve without actually retrieving them", Description = "See if there are any items to retrieve without actually retrieving them", Tags = new[] { "Get All", "Head" })]
    public virtual async Task<Pager<TViewDto>> GetAllHead([RangeRequest] Payloads.Range range, [FromQuery] string itemSeparator = DefaultItemSeparator, [FromQuery] string? orderBy = null, [FromQuery] ListSortDirection sortDirection = ListSortDirection.Ascending)
    {
        var response = await GetAll(range, itemSeparator, orderBy, sortDirection);
        return response is not null && response.Count > 0 ? new Pager<TViewDto>(System.Array.CreateInstance(typeof(TViewDto), response.Count).OfType<TViewDto>().ToArray(), range.PageNumber, range.PageSize, response.TotalRecords) : Pager<TViewDto>.NotFound();
    }

    /// <summary>Retrieves a list of items.</summary>
    /// <returns>A list of items.</returns>
    /// <response code="200">Returns the complete list of items.</response>
    /// <response code="206">Returns a partial list of items.</response>
    /// <response code="401">If the user is not authorized.</response>
    /// <response code="403">If the user is not allowed to access the resource.</response>
    /// <response code="404">If the resource is not found.</response>
    /// <response code="500">If an unexpected error occurs.</response>
    /// <response code="503">If the service is unavailable.</response>
    /// <response code="504">If the service times out.</response>
    /// <param name="page" default="1">The page number to return</param>
    /// <param name="pageSize" default="MaxInt">The size of the page to return</param>
    /// <param name="itemSeparator" example="', '">The string to place in between items when rendering the payload as a plain text value</param>
    /// <param name="orderBy" default="'Id'">The name of the property to use to sort the returned items</param>
    /// <param name="sortDirection" example="'ascending' / 'descending'">Whether to sort the items in ascending or descending order</param>
    [HttpGet]
    [SwaggerResponseHeader(Status206PartialContent, HttpResponseHeaderNames.ContentRange, "content-range", "The range of item indices returned by the API", "content-range")]
    // [ProducesResponseType(typeof(Pager<>), (int)Status206PartialContent)]
    // [ProducesResponseType(typeof(SingleItemPager<>), (int)Status206PartialContent)]
    // [ProducesResponseType(typeof(Pager), (int)Status206PartialContent)]
    // [ProducesResponseType(typeof(SingleItemPager), (int)Status206PartialContent)]
    public virtual async Task<Pager<TViewDto>> GetAll([RangeRequest] Payloads.Range range, [FromQuery] string itemSeparator = DefaultItemSeparator, [FromQuery] string? orderBy = null, [FromQuery] ListSortDirection sortDirection = ListSortDirection.Ascending)
    {
        var allItems = Db.Set<TModel>().AsQueryable();
        allItems = !IsNullOrEmpty(orderBy) ?
            sortDirection == ListSortDirection.Ascending ? allItems.OrderBy(item => EF.Property<object>(item, orderBy)) :
            allItems.OrderByDescending(item => EF.Property<object>(item, orderBy)) :
            allItems;
        var totalCount = await allItems.CountAsync();
        if(range.PageSize == 1)
        {
            var item = await allItems.Skip(range.PageNumber - 1).FirstOrDefaultAsync();
            if(item is null)
            {
                return Pager<TViewDto>.NotFound();
            }
            else
            {
                return new SingleItemPager<TViewDto>(Mapper.Map<TViewDto>(item), range.PageNumber, totalCount);
            }
        }
        else
        {
            var items = await allItems.Skip((range.PageNumber - 1) * range.PageSize).Take(range.PageSize).ToArrayAsync();
            return new Pager<TViewDto>(Mapper.Map<TViewDto[]>(items), range.PageNumber, range.PageSize, totalCount, itemSeparator: itemSeparator);
        }
    }


    /// <summary>Retrieves a single item.</summary>
    /// <returns>A list of items.</returns>
    /// <response code="200">Returns the requested item.</response>
    /// <response code="401">If the user is not authorized.</response>
    /// <response code="403">If the user is not allowed to access the resource.</response>
    /// <response code="404">If the item is not found.</response>
    /// <response code="500">If an unexpected error occurs.</response>
    /// <response code="503">If the service is unavailable.</response>
    /// <response code="504">If the service times out.</response>
    /// <param name="id" example="69">The unique ID of the item to return</param>
    [HttpGet("{id}")]
    [Produces(ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, ApplicationMediaTypeNames.Bson, ApplicationMediaTypeNames.MessagePack, TextMediaTypeNames.Plain)]
    public virtual async Task<ResponsePayload<TViewDto>> Get(TId id)
    {
        var model = await Db.Set<TModel>().FindAsync(id);
        if (model is null)
        {
            return ResponsePayload<TViewDto>.NotFound();
        }
        return new ResponsePayload<TViewDto>(Mapper.Map<TViewDto>(model));
    }

    /// <summary>Determines if the item exists.</summary>
    /// <returns>Nothing</returns>
    /// <response code="200">The item exists.</response>
    /// <response code="401">If the user is not authorized.</response>
    /// <response code="403">If the user is not allowed to access the resource.</response>
    /// <response code="404">If the item is not found.</response>
    /// <response code="500">If an unexpected error occurs.</response>
    /// <response code="503">If the service is unavailable.</response>
    /// <response code="504">If the service times out.</response>
    /// <param name="id" example="69">The unique ID of the item to look up</param>
    [HttpHead("{id}")]
    [Produces(ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, ApplicationMediaTypeNames.Bson, ApplicationMediaTypeNames.MessagePack, TextMediaTypeNames.Plain)]
    public virtual async Task<ResponsePayload<TViewDto>> Head([FromRoute] TId id)
         => (await Db.Set<TModel>().FindAsync(id)) is not null ?
         new ResponsePayload<TViewDto>() :
         ResponsePayload<TViewDto>.NotFound();

    /// <summary>Updates an item from a complete DTO</summary>
    [HttpPut("{id}")]
    [Produces(ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, ApplicationMediaTypeNames.Bson, ApplicationMediaTypeNames.MessagePack, TextMediaTypeNames.Plain)]
    public virtual async Task<ResponsePayload<TViewDto>> Put(TId id, TUpdateDto dto)
    {
        var model = await Db.Set<TModel>().FindAsync(id);
        if (model is null)
        {
            return ResponsePayload<TViewDto>.NotFound();
        }
        Mapper.Map(dto, model);
        Db.Entry(model).State = EntityState.Modified;
        try
        {
            await Db.SaveChangesAsync(default);
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ModelExists(id))
            {
                return ResponsePayload<TViewDto>.NotFound();
            }
            else
            {
                throw;
            }
        }
        return new ResponsePayload<TViewDto>(Mapper.Map<TViewDto>(model));
    }

    /// <summary>Creates a new item from a complete DTO</summary>
    [HttpPost]
    [Consumes(ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, ApplicationMediaTypeNames.Bson, ApplicationMediaTypeNames.MessagePack)]
    [Produces(ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, ApplicationMediaTypeNames.Bson, ApplicationMediaTypeNames.MessagePack, TextMediaTypeNames.Plain)]
    public virtual async Task<ResponsePayload<TViewDto>> Post(TInsertDto insertDto)
    {
        Logger.LogInformation("Inserting {Model}...", insertDto);
        var model = Mapper.Map<TModel>(insertDto);
       Db.Set<TModel>().Add(model);
        await Db.SaveChangesAsync(default);
        return ResponsePayload <TViewDto>.Created(Mapper.Map<TViewDto>(model));
    }

    /// <summary>Deletes the item with ID = <paramref name="id"/></summary>
    [HttpDelete("{id}")]
    [ProducesResponseType(Status204NoContent)]
    public virtual async Task<IActionResult> Delete([FromRoute] TId id)
    {
        var model = await Db.Set<TModel>().FindAsync(id);
        if (model == null)
        {
            return NotFound();
        }
        Db.Set<TModel>().Remove(model);
        await Db.SaveChangesAsync(default);
        return NoContent();
    }

    /// <summary>Executes a partial update on the item with ID = <paramref name="id"/></summary>
    [HttpPatch("{id}")]
    [Consumes(ApplicationMediaTypeNames.JsonPatch)]
    [Produces(ApplicationMediaTypeNames.Json, ApplicationMediaTypeNames.Xml, ApplicationMediaTypeNames.Bson, ApplicationMediaTypeNames.MessagePack, TextMediaTypeNames.Plain)]
    public virtual async Task<ResponsePayload<TViewDto>> Patch([FromRoute] TId id, [FromBody] JsonPatchDocument<TUpdateDto> patch)
    {
        if (!ModelExists(id))
        {
            return ResponsePayload<TViewDto>.NotFound();
        }
        var model = await Db.Set<TModel>().FindAsync(id);
        var dto = Mapper.Map<TUpdateDto>(model);
        patch.ApplyTo(dto);
        Mapper.Map(dto, model);

        Db.Entry(model).State = EntityState.Modified;
        try
        {
            await Db.SaveChangesAsync(default);
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ModelExists(id))
            {
                return ResponsePayload<TViewDto>.NotFound();
            }
            else
            {
                throw;
            }
        }

        return new ResponsePayload<TViewDto>(Mapper.Map<TViewDto>(model));
    }

    private bool ModelExists(TId id)
    {
        return Db.Set<TModel>().Any(e => e.Id.Equals(id));
    }

    protected virtual CreatedResponsePayload<TViewDto> Created(TModel model)
        => new CreatedResponsePayload<TViewDto>(Mapper.Map<TViewDto>(model), $"get/{model.Id}".ToUri());
}
