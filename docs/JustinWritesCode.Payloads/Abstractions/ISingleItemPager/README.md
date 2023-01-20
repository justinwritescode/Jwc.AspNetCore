# ISingleItemPager Interface

[Home](../../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a single\-item pager \(i\.e\., one item per page\)\.

```csharp
public interface ISingleItemPager : JustinWritesCode.Payloads.Abstractions.IPayload<object>,
    JustinWritesCode.Payloads.Abstractions.ISingleItemPager<object>
```

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\>
* JustinWritesCode\.Payloads\.Abstractions\.[ISingleItemPager](../ISingleItemPager-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\>
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../IResponsePayload/ContentTypes/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [HasNextPage](../ISingleItemPager-1/HasNextPage/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [HasPreviousPage](../ISingleItemPager-1/HasPreviousPage/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [IsLastPage](../ISingleItemPager-1/IsLastPage/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [IsSuccess](../IResponsePayload/IsSuccess/README.md) | If the request was successful \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Item](../ISingleItemPager-1/Item/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [Message](../IResponsePayload/Message/README.md) | An optional message with information about the response \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [OutputFormatters](../IResponsePayload/OutputFormatters/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Page](../ISingleItemPager-1/Page/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [PageEndIndex](../ISingleItemPager-1/PageEndIndex/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [PageSize](../ISingleItemPager-1/PageSize/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [PageStartIndex](../ISingleItemPager-1/PageStartIndex/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [StatusCode](../IResponsePayload/StatusCode/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [TotalPages](../ISingleItemPager-1/TotalPages/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [TotalRecords](../ISingleItemPager-1/TotalRecords/README.md) |  \(Inherited from [ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)\) |
| [Value](../IPayload-1/Value/README.md) | The strongly\-typed value of the payload \(Inherited from [IPayload\<T\>](../IPayload-1/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [BadRequest()](../IResponsePayload-1/BadRequest/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [ExecuteResultAsync(ActionContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult.executeresultasync) |  \(Inherited from [IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)\) |
| [NoContent()](../IResponsePayload-1/NoContent/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [NotFound()](../IResponsePayload-1/NotFound/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [OnFormatting(OutputFormatterWriteContext)](../IResponsePayload/OnFormatting/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |

