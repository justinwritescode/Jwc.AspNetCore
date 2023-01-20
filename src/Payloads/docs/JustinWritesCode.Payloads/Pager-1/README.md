# Pager\<T\> Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators) &#x2022; [Explicit Interface Implementations](#explicit-interface-implementations)

**Namespace**: [JustinWritesCode.Payloads](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a strongly\-typed response payload of type **T**\.

```csharp
public class Pager<T> : JustinWritesCode.Payloads.ArrayResponsePayload<T>,
    JustinWritesCode.Payloads.Abstractions.IPager,
    JustinWritesCode.Payloads.Abstractions.IPager<T>,
    JustinWritesCode.Payloads.Abstractions.IPayload,
    JustinWritesCode.Payloads.Abstractions.IPayload<T[]>
```

### Type Parameters

**T**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [Payload\<T\>](../Payload-1/README.md) &#x2192; [ResponsePayload\<T\>](../ResponsePayload-1/README.md) &#x2192; [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md) &#x2192; Pager\<T\>

### Derived

* JustinWritesCode\.Payloads\.[Pager](../Pager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../SingleItemPager-1/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IArrayPayload](../Abstractions/IArrayPayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayResponsePayload](../Abstractions/IArrayResponsePayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IPager](../Abstractions/IPager/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPager](../Abstractions/IPager-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload-1/README.md)\<T\[\]\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../Abstractions/IResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../Abstractions/IResponsePayload-1/README.md)\<T\[\]\>
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [Pager()](-ctor/README.md#1475148317) | |
| [Pager(IQueryable\<T\>, Range, String, String, Int32?)](-ctor/README.md#3171484300) | |
| [Pager(T\[\], Int32, Int32, Int32, String, String)](-ctor/README.md#540838811) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../ResponsePayload-1/ContentTypes/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [Count](../ArrayResponsePayload-1/Count/README.md) | The number of items in the array \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |
| [HasNextPage](HasNextPage/README.md) |  \(Implements [IPager.HasNextPage](../Abstractions/IPager/HasNextPage/README.md)\) |
| [HasPreviousPage](HasPreviousPage/README.md) |  \(Implements [IPager.HasPreviousPage](../Abstractions/IPager/HasPreviousPage/README.md)\) |
| [IsLastPage](IsLastPage/README.md) |  \(Implements [IPager.IsLastPage](../Abstractions/IPager/IsLastPage/README.md)\) |
| [IsSuccess](../ResponsePayload-1/IsSuccess/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [Items](Items/README.md) |  \(Implements [IPager\<T\>.Items](../Abstractions/IPager-1/Items/README.md)\) |
| [ItemSeparator](../ArrayResponsePayload-1/ItemSeparator/README.md) |  \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |
| [Message](../ResponsePayload-1/Message/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [OutputFormatters](../ResponsePayload-1/OutputFormatters/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [Page](Page/README.md) |  \(Implements [IPager.Page](../Abstractions/IPager/Page/README.md)\) |
| [PageEndIndex](PageEndIndex/README.md) |  \(Implements [IPager.PageEndIndex](../Abstractions/IPager/PageEndIndex/README.md)\) |
| [PageSize](PageSize/README.md) |  \(Implements [IPager.PageSize](../Abstractions/IPager/PageSize/README.md)\) |
| [PageStartIndex](PageStartIndex/README.md) |  \(Implements [IPager.PageStartIndex](../Abstractions/IPager/PageStartIndex/README.md)\) |
| [StatusCode](StatusCode/README.md) |  \(Overrides [ResponsePayload\<T\[\]\>.StatusCode](../ResponsePayload-1/StatusCode/README.md)\) |
| [StringValue](../ArrayResponsePayload-1/StringValue/README.md) | The string representation of the array, which defaults to the string values of each of the elements separared by the [ArrayResponsePayload\<T\>.ItemSeparator](../ArrayResponsePayload-1/ItemSeparator/README.md) \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |
| [TotalPages](TotalPages/README.md) |  \(Implements [IPager.TotalPages](../Abstractions/IPager/TotalPages/README.md)\) |
| [TotalRecords](TotalRecords/README.md) |  \(Implements [IPager.TotalRecords](../Abstractions/IPager/TotalRecords/README.md)\) |
| [Value](../ArrayResponsePayload-1/Value/README.md) |  \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |
| [Values](Values/README.md) |  \(Overrides [ArrayResponsePayload\<T\>.Values](../ArrayResponsePayload-1/Values/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [BadRequest()](BadRequest/README.md) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ExecuteResultAsync(ActionContext)](../ResponsePayload-1/ExecuteResultAsync/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetOpenApiSchema()](GetOpenApiSchema/README.md) | |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [NoContent()](NoContent/README.md) | |
| [NotFound()](NotFound/README.md) | |
| [OnFormatting(OutputFormatterWriteContext)](../ResponsePayload-1/OnFormatting/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [ToString()](../ArrayResponsePayload-1/ToString/README.md) |  \(Inherited from [ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)\) |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Implicit T\[\](Pager\<T\>)](op_Implicit/README.md#563074494) | |
| [Implicit\<T to Pager\>(T\[\])](op_Implicit/README.md#3830846023) | |

## Explicit Interface Implementations

| Member | Summary |
| ------ | ------- |
| [IPager.Items](JustinWritesCode-Payloads-Abstractions-IPager-Items/README.md) | |
| [IPayload.Value](JustinWritesCode-Payloads-Abstractions-IPayload-Value/README.md) | |

