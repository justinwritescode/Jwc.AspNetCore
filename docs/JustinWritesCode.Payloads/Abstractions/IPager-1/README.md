# IPager\<T\> Interface

[Home](../../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a srrongly\-typed response payload with a page of items of type **T**

```csharp
public interface IPager<T> : JustinWritesCode.Payloads.Abstractions.IPager,
    JustinWritesCode.Payloads.Abstractions.IResponsePayload<T[]>
```

### Type Parameters

**T**

### Derived

* JustinWritesCode\.Payloads\.[Pager](../../Pager/README.md)
* JustinWritesCode\.Payloads\.[Pager\<T\>](../../Pager-1/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../../SingleItemPager-1/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPager](../IPager/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload-1/README.md)\<T\[\]\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload-1/README.md)\<T\[\]\>
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../IResponsePayload/ContentTypes/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [HasNextPage](../IPager/HasNextPage/README.md) | Whether the current page has a previous page \(Inherited from [IPager](../IPager/README.md)\) |
| [HasPreviousPage](../IPager/HasPreviousPage/README.md) | Whether the current page is the last page in the resultset \(Inherited from [IPager](../IPager/README.md)\) |
| [IsLastPage](../IPager/IsLastPage/README.md) | Whether the current page is the first page in the resultset \(Inherited from [IPager](../IPager/README.md)\) |
| [IsSuccess](../IResponsePayload/IsSuccess/README.md) | If the request was successful \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Items](Items/README.md) | The array of items in the current page |
| [Message](../IResponsePayload/Message/README.md) | An optional message with information about the response \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [OutputFormatters](../IResponsePayload/OutputFormatters/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Page](../IPager/Page/README.md) | The 1\-based index of the current page \(Inherited from [IPager](../IPager/README.md)\) |
| [PageEndIndex](../IPager/PageEndIndex/README.md) | The 0\-based index of the last record in the current page \(Inherited from [IPager](../IPager/README.md)\) |
| [PageSize](../IPager/PageSize/README.md) | The size of the page, i\.e\., the maximum number of records in the page \(Inherited from [IPager](../IPager/README.md)\) |
| [PageStartIndex](../IPager/PageStartIndex/README.md) | The 0\-based index of the first record in the current page \(Inherited from [IPager](../IPager/README.md)\) |
| [StatusCode](../IResponsePayload/StatusCode/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [TotalPages](../IPager/TotalPages/README.md) | The total number of pages in the resultset \(Inherited from [IPager](../IPager/README.md)\) |
| [TotalRecords](../IPager/TotalRecords/README.md) | The total number of records in the entire resultset \(Inherited from [IPager](../IPager/README.md)\) |
| [Value](../IPayload-1/Value/README.md) | The strongly\-typed value of the payload \(Inherited from [IPayload\<T\>](../IPayload-1/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [BadRequest()](../IResponsePayload-1/BadRequest/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [ExecuteResultAsync(ActionContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult.executeresultasync) |  \(Inherited from [IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)\) |
| [NoContent()](../IResponsePayload-1/NoContent/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [NotFound()](../IResponsePayload-1/NotFound/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [OnFormatting(OutputFormatterWriteContext)](../IResponsePayload/OnFormatting/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |

