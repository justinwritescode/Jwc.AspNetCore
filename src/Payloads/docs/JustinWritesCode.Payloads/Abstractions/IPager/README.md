# IPager Interface

[Home](../../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a response payload that supports paging

```csharp
public interface IPager : JustinWritesCode.Payloads.Abstractions.IResponsePayload
```

### Derived

* JustinWritesCode\.Payloads\.[Pager](../../Pager/README.md)
* JustinWritesCode\.Payloads\.[Pager\<T\>](../../Pager-1/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../../SingleItemPager-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPager\<T\>](../IPager-1/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload/README.md)
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../IResponsePayload/ContentTypes/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [HasNextPage](HasNextPage/README.md) | Whether the current page has a previous page |
| [HasPreviousPage](HasPreviousPage/README.md) | Whether the current page is the last page in the resultset |
| [IsLastPage](IsLastPage/README.md) | Whether the current page is the first page in the resultset |
| [IsSuccess](../IResponsePayload/IsSuccess/README.md) | If the request was successful \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Items](Items/README.md) | The array of items in the current page |
| [Message](../IResponsePayload/Message/README.md) | An optional message with information about the response \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [OutputFormatters](../IResponsePayload/OutputFormatters/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Page](Page/README.md) | The 1\-based index of the current page |
| [PageEndIndex](PageEndIndex/README.md) | The 0\-based index of the last record in the current page |
| [PageSize](PageSize/README.md) | The size of the page, i\.e\., the maximum number of records in the page |
| [PageStartIndex](PageStartIndex/README.md) | The 0\-based index of the first record in the current page |
| [StatusCode](../IResponsePayload/StatusCode/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [TotalPages](TotalPages/README.md) | The total number of pages in the resultset |
| [TotalRecords](TotalRecords/README.md) | The total number of records in the entire resultset |
| [Value](../IPayload/Value/README.md) | The value of the payload \(Inherited from [IPayload](../IPayload/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [ExecuteResultAsync(ActionContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult.executeresultasync) |  \(Inherited from [IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)\) |
| [OnFormatting(OutputFormatterWriteContext)](../IResponsePayload/OnFormatting/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |

