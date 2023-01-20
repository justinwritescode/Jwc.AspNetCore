# ISingleItemPager\<T\> Interface

[Home](../../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a strongly\-typed single\-item pager \(i\.e\., one item per page\) of items of type **T**\.

```csharp
public interface ISingleItemPager<T> : JustinWritesCode.Payloads.Abstractions.IResponsePayload<T>
```

### Type Parameters

**T**

### Derived

* JustinWritesCode\.Payloads\.[SingleItemPager](../../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../../SingleItemPager-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[ISingleItemPager](../ISingleItemPager/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload-1/README.md)\<T\>
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../IResponsePayload/ContentTypes/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [HasNextPage](HasNextPage/README.md) | |
| [HasPreviousPage](HasPreviousPage/README.md) | |
| [IsLastPage](IsLastPage/README.md) | |
| [IsSuccess](../IResponsePayload/IsSuccess/README.md) | If the request was successful \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Item](Item/README.md) | |
| [Message](../IResponsePayload/Message/README.md) | An optional message with information about the response \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [OutputFormatters](../IResponsePayload/OutputFormatters/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Page](Page/README.md) | |
| [PageEndIndex](PageEndIndex/README.md) | |
| [PageSize](PageSize/README.md) | |
| [PageStartIndex](PageStartIndex/README.md) | |
| [StatusCode](../IResponsePayload/StatusCode/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [TotalPages](TotalPages/README.md) | |
| [TotalRecords](TotalRecords/README.md) | |
| [Value](../IPayload-1/Value/README.md) | The strongly\-typed value of the payload \(Inherited from [IPayload\<T\>](../IPayload-1/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [BadRequest()](../IResponsePayload-1/BadRequest/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [ExecuteResultAsync(ActionContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult.executeresultasync) |  \(Inherited from [IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)\) |
| [NoContent()](../IResponsePayload-1/NoContent/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [NotFound()](../IResponsePayload-1/NotFound/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [OnFormatting(OutputFormatterWriteContext)](../IResponsePayload/OnFormatting/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |

