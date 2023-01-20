# Pager Class

[Home](../../README.md) &#x2022; [Remarks](#remarks) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

```csharp
public class Pager : JustinWritesCode.Payloads.Pager<object>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [Payload\<T\>](../Payload-1/README.md) &#x2192; [ResponsePayload\<T\>](../ResponsePayload-1/README.md) &#x2192; [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md) &#x2192; [Pager\<T\>](../Pager-1/README.md) &#x2192; Pager

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IArrayPayload](../Abstractions/IArrayPayload-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\>
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayResponsePayload](../Abstractions/IArrayResponsePayload-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\>
* JustinWritesCode\.Payloads\.Abstractions\.[IPager](../Abstractions/IPager/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPager](../Abstractions/IPager-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\>
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../Abstractions/IResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../Abstractions/IResponsePayload-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]\>
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Remarks

Items are of type \.

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [Pager()](-ctor/README.md#870412334) | |
| [Pager(IEnumerable, Int32, Int32, Int32)](-ctor/README.md#506638939) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../ResponsePayload-1/ContentTypes/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [Count](../ArrayResponsePayload-1/Count/README.md) | The number of items in the array \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |
| [HasNextPage](../Pager-1/HasNextPage/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [HasPreviousPage](../Pager-1/HasPreviousPage/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [IsLastPage](../Pager-1/IsLastPage/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [IsSuccess](../ResponsePayload-1/IsSuccess/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [Items](../Pager-1/Items/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [ItemSeparator](../ArrayResponsePayload-1/ItemSeparator/README.md) |  \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |
| [Message](../ResponsePayload-1/Message/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [OutputFormatters](../ResponsePayload-1/OutputFormatters/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [Page](../Pager-1/Page/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [PageEndIndex](../Pager-1/PageEndIndex/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [PageSize](../Pager-1/PageSize/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [PageStartIndex](../Pager-1/PageStartIndex/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [StatusCode](../Pager-1/StatusCode/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [StringValue](../ArrayResponsePayload-1/StringValue/README.md) | The string representation of the array, which defaults to the string values of each of the elements separared by the [ArrayResponsePayload\<T\>.ItemSeparator](../ArrayResponsePayload-1/ItemSeparator/README.md) \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |
| [TotalPages](../Pager-1/TotalPages/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [TotalRecords](../Pager-1/TotalRecords/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |
| [Value](../ArrayResponsePayload-1/Value/README.md) |  \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |
| [Values](../Pager-1/Values/README.md) |  \(Inherited from [Pager\<T\>](../Pager-1/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [BadRequest()](BadRequest/README.md) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ExecuteResultAsync(ActionContext)](../ResponsePayload-1/ExecuteResultAsync/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [NoContent()](NoContent/README.md) | |
| [NotFound()](NotFound/README.md) | |
| [OnFormatting(OutputFormatterWriteContext)](../ResponsePayload-1/OnFormatting/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [ToString()](../ArrayResponsePayload-1/ToString/README.md) |  \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |

