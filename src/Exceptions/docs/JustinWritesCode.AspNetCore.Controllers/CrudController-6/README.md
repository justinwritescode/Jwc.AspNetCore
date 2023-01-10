# CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\> Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Fields](#fields) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.AspNetCore.Controllers](../README.md)

**Assembly**: JustinWritesCode\.AspNetCore\.Controllers\.dll

```csharp
public abstract class CrudController<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId> : JustinWritesCode.AspNetCore.Controllers.ApiControllerBase<TDbContext>,
    JustinWritesCode.Abstractions.ILog,
    Microsoft.EntityFrameworkCore.Abstractions.IHaveADbContext<TDbContext>
    where TModel : class, JustinWritesCode.Abstractions.IIdentifiable<TId> 
    where TUpdateDto : class 
    where TDbContext : Microsoft.EntityFrameworkCore.Abstractions.IDbContext, Microsoft.EntityFrameworkCore.Abstractions.IDbContext<TDbContext> 
    where TId : IComparable, IEquatable<TId>
```

### Type Parameters

**TModel**

**TInsertDto**

**TUpdateDto**

**TViewDto**

**TDbContext**

**TId**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase) &#x2192; [ApiControllerBase](../ApiControllerBase/README.md) &#x2192; [ApiControllerBase\<TDbContext\>](../ApiControllerBase-1/README.md) &#x2192; CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>

### Attributes

* JustinWritesCode\.AspNetCore\.Mvc\.Produces400ErrorAttribute \(Inherited from [ApiControllerBase](../ApiControllerBase/README.md)\)
* JustinWritesCode\.AspNetCore\.Mvc\.Produces401ErrorAttribute \(Inherited from [ApiControllerBase](../ApiControllerBase/README.md)\)
* JustinWritesCode\.AspNetCore\.Mvc\.Produces403ErrorAttribute \(Inherited from [ApiControllerBase](../ApiControllerBase/README.md)\)
* JustinWritesCode\.AspNetCore\.Mvc\.Produces404ErrorAttribute \(Inherited from [ApiControllerBase](../ApiControllerBase/README.md)\)
* JustinWritesCode\.AspNetCore\.Mvc\.Produces500ErrorAttribute \(Inherited from [ApiControllerBase](../ApiControllerBase/README.md)\)
* Microsoft\.AspNetCore\.Mvc\.[ApiControllerAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.apicontrollerattribute) \(Inherited from [ApiControllerBase](../ApiControllerBase/README.md)\)
* Microsoft\.AspNetCore\.Mvc\.[ControllerAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerattribute) \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\)
* Microsoft\.AspNetCore\.Mvc\.[RouteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.routeattribute) \(Inherited from [ApiControllerBase](../ApiControllerBase/README.md)\)

### Derived

* JustinWritesCode\.AspNetCore\.Controllers\.[CrudController\<TModel, TDbContext, TId\>](../CrudController-3/README.md)
* JustinWritesCode\.AspNetCore\.Controllers\.[CrudController\<TModel, TDto, TDbContext, TId\>](../CrudController-4/README.md)
* JustinWritesCode\.AspNetCore\.Controllers\.[CrudController\<TModel, TInsertDto, TDto, TDbContext, TId\>](../CrudController-5/README.md)

### Implements

* JustinWritesCode\.Abstractions\.ILog
* Microsoft\.EntityFrameworkCore\.Abstractions\.[IHaveADbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.abstractions.ihaveadbcontext)
* Microsoft\.EntityFrameworkCore\.Abstractions\.[IHaveADbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.abstractions.ihaveadbcontext-1)\<TDbContext\>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [CrudController(TDbContext, ILogger, IMapper, IMediator)](-ctor/README.md) | |

## Fields

| Field | Summary |
| ----- | ------- |
| [DefaultItemSeparator](DefaultItemSeparator/README.md) |  \(Value = "\\r\\n"\) |

## Properties

| Property | Summary |
| -------- | ------- |
| [ControllerContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.controllercontext) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Db](../ApiControllerBase-1/Db/README.md) |  \(Inherited from [ApiControllerBase\<TDbContext\>](../ApiControllerBase-1/README.md)\) |
| [HttpContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.httpcontext) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Logger](../ApiControllerBase/Logger/README.md) |  \(Inherited from [ApiControllerBase](../ApiControllerBase/README.md)\) |
| [Mapper](Mapper/README.md) | |
| [Mediator](Mediator/README.md) | |
| [MetadataProvider](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.metadataprovider) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ModelBinderFactory](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.modelbinderfactory) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ModelState](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.modelstate) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ObjectValidator](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.objectvalidator) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ProblemDetailsFactory](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.problemdetailsfactory) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Request](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.request) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Response](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.response) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RouteData](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.routedata) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Url](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.url) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [User](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.user) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Accepted()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Accepted(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Accepted(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Accepted(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Accepted(Uri, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Accepted(Uri)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtAction(String, Object, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtAction(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtAction(String, String, Object, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtAction(String, String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtAction(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtAction(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtRoute(Object, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtRoute(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtRoute(String, Object, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtRoute(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [AcceptedAtRoute(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [BadRequest()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.badrequest) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [BadRequest(ModelStateDictionary)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.badrequest) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [BadRequest(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.badrequest) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Challenge()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.challenge) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Challenge(AuthenticationProperties, String\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.challenge) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Challenge(AuthenticationProperties)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.challenge) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Challenge(String\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.challenge) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Conflict()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.conflict) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Conflict(ModelStateDictionary)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.conflict) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Conflict(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.conflict) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Content(String, MediaTypeHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.content) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Content(String, String, Encoding)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.content) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Content(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.content) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Content(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.content) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Created(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.created) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Created(TModel)](Created/README.md) | |
| [Created(Uri, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.created) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [CreatedAtAction(String, Object, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [CreatedAtAction(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [CreatedAtAction(String, String, Object, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdataction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [CreatedAtRoute(Object, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdatroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [CreatedAtRoute(String, Object, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdatroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [CreatedAtRoute(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdatroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Delete(TId)](Delete/README.md) | Deletes the item with ID = **id** |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [File(Byte\[\], String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Byte\[\], String, DateTimeOffset?, EntityTagHeaderValue, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Byte\[\], String, DateTimeOffset?, EntityTagHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Byte\[\], String, String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Byte\[\], String, String, DateTimeOffset?, EntityTagHeaderValue, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Byte\[\], String, String, DateTimeOffset?, EntityTagHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Byte\[\], String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Byte\[\], String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Stream, String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Stream, String, DateTimeOffset?, EntityTagHeaderValue, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Stream, String, DateTimeOffset?, EntityTagHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Stream, String, String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Stream, String, String, DateTimeOffset?, EntityTagHeaderValue, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Stream, String, String, DateTimeOffset?, EntityTagHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Stream, String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(Stream, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(String, String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(String, String, DateTimeOffset?, EntityTagHeaderValue, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(String, String, DateTimeOffset?, EntityTagHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(String, String, String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(String, String, String, DateTimeOffset?, EntityTagHeaderValue, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(String, String, String, DateTimeOffset?, EntityTagHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(String, String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [File(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Forbid()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.forbid) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Forbid(AuthenticationProperties, String\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.forbid) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Forbid(AuthenticationProperties)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.forbid) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Forbid(String\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.forbid) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Get(TId)](Get/README.md) | Retrieves a single item\. |
| [GetAll(Range, Expression\<Func\<TViewDto, Boolean\>\>, String, String, ListSortDirection)](GetAll/README.md) | Retrieves a list of items\. |
| [GetAllHead(Range, String, String, ListSortDirection)](GetAllHead/README.md) | Retrieves a list of items\. |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Head(TId)](Head/README.md) | Determines if the item exists\. |
| [LocalRedirect(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.localredirect) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [LocalRedirectPermanent(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.localredirectpermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [LocalRedirectPermanentPreserveMethod(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.localredirectpermanentpreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [LocalRedirectPreserveMethod(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.localredirectpreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [NoContent()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.nocontent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [NotFound()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.notfound) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [NotFound(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.notfound) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Ok()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.ok) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Ok(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.ok) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Patch(TId, JsonPatchDocument\<TUpdateDto\>)](Patch/README.md) | Executes a partial update on the item with ID = **id** |
| [PhysicalFile(String, String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [PhysicalFile(String, String, DateTimeOffset?, EntityTagHeaderValue, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [PhysicalFile(String, String, DateTimeOffset?, EntityTagHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [PhysicalFile(String, String, String, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [PhysicalFile(String, String, String, DateTimeOffset?, EntityTagHeaderValue, Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [PhysicalFile(String, String, String, DateTimeOffset?, EntityTagHeaderValue)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [PhysicalFile(String, String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [PhysicalFile(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Post(TInsertDto)](Post/README.md) | Creates a new item from a complete DTO |
| [Problem(String, String, Int32?, String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.problem) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Put(TId, TUpdateDto)](Put/README.md) | Updates an item from a complete DTO |
| [Redirect(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirect) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectPermanent(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirectpermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectPermanentPreserveMethod(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirectpermanentpreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectPreserveMethod(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirectpreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToAction()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToAction(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToAction(String, String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToAction(String, String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToAction(String, String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToAction(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToAction(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToActionPermanent(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToActionPermanent(String, String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToActionPermanent(String, String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToActionPermanent(String, String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToActionPermanent(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToActionPermanent(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToActionPermanentPreserveMethod(String, String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanentpreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToActionPreserveMethod(String, String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPage(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPage(String, String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPage(String, String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPage(String, String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPage(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPage(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPagePermanent(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPagePermanent(String, String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPagePermanent(String, String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPagePermanent(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPagePermanent(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPagePermanentPreserveMethod(String, String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanentpreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToPagePreserveMethod(String, String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoute(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoute(String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoute(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoute(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoute(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoutePermanent(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoutePermanent(String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoutePermanent(String, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoutePermanent(String, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoutePermanent(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoutePermanentPreserveMethod(String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanentpreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [RedirectToRoutePreserveMethod(String, Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepreservemethod) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [SignIn(ClaimsPrincipal, AuthenticationProperties, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signin) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [SignIn(ClaimsPrincipal, AuthenticationProperties)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signin) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [SignIn(ClaimsPrincipal, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signin) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [SignIn(ClaimsPrincipal)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signin) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [SignOut()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signout) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [SignOut(AuthenticationProperties, String\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signout) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [SignOut(AuthenticationProperties)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signout) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [SignOut(String\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signout) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [StatusCode(Int32, Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.statuscode) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [StatusCode(Int32)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.statuscode) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [TryUpdateModelAsync(Object, Type, String, IValueProvider, Func\<ModelMetadata, Boolean\>)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryUpdateModelAsync(Object, Type, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryUpdateModelAsync\<TModel\>(TModel, String, Expression\<Func\<TModel, Object\>\>\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryUpdateModelAsync\<TModel\>(TModel, String, Func\<ModelMetadata, Boolean\>)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryUpdateModelAsync\<TModel\>(TModel, String, IValueProvider, Expression\<Func\<TModel, Object\>\>\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryUpdateModelAsync\<TModel\>(TModel, String, IValueProvider, Func\<ModelMetadata, Boolean\>)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryUpdateModelAsync\<TModel\>(TModel, String, IValueProvider)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryUpdateModelAsync\<TModel\>(TModel, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryUpdateModelAsync\<TModel\>(TModel)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryValidateModel(Object, String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryvalidatemodel) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [TryValidateModel(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryvalidatemodel) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Unauthorized()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unauthorized) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [Unauthorized(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unauthorized) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [UnprocessableEntity()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unprocessableentity) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [UnprocessableEntity(ModelStateDictionary)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unprocessableentity) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [UnprocessableEntity(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unprocessableentity) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ValidationProblem()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ValidationProblem(ModelStateDictionary)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ValidationProblem(String, String, Int32?, String, String, ModelStateDictionary)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |
| [ValidationProblem(ValidationProblemDetails)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem) |  \(Inherited from [ControllerBase](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase)\) |

