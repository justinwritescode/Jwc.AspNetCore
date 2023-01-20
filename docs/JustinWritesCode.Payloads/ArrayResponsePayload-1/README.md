# ArrayResponsePayload\<T\> Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a strongly\-typed response payload of type **T**\.

```csharp
public class ArrayResponsePayload<T> : JustinWritesCode.Payloads.ResponsePayload<T[]>,
    JustinWritesCode.Payloads.Abstractions.IArrayResponsePayload<T>
```

### Type Parameters

**T**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [Payload\<T\>](../Payload-1/README.md) &#x2192; [ResponsePayload\<T\>](../ResponsePayload-1/README.md) &#x2192; ArrayResponsePayload\<T\>

### Derived

* JustinWritesCode\.Payloads\.[ArrayResponsePayload](../ArrayResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[Pager](../Pager/README.md)
* JustinWritesCode\.Payloads\.[Pager\<T\>](../Pager-1/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../SingleItemPager-1/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IArrayPayload](../Abstractions/IArrayPayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayResponsePayload](../Abstractions/IArrayResponsePayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload-1/README.md)\<T\[\]\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../Abstractions/IResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../Abstractions/IResponsePayload-1/README.md)\<T\[\]\>
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ArrayResponsePayload()](-ctor/README.md#3042905097) | |
| [ArrayResponsePayload(T\[\], String, String, String)](-ctor/README.md#2521348082) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../ResponsePayload-1/ContentTypes/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [Count](Count/README.md) | The number of items in the array |
| [IsSuccess](../ResponsePayload-1/IsSuccess/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [ItemSeparator](ItemSeparator/README.md) | |
| [Message](../ResponsePayload-1/Message/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [OutputFormatters](../ResponsePayload-1/OutputFormatters/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [StatusCode](../ResponsePayload-1/StatusCode/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [StringValue](StringValue/README.md) | The string representation of the array, which defaults to the string values of each of the elements separared by the [ArrayResponsePayload\<T\>.ItemSeparator](ItemSeparator/README.md) \(Overrides [Payload\<T\[\]\>.StringValue](../Payload-1/StringValue/README.md)\) |
| [Value](Value/README.md) |  \(Overrides [Payload\<T\[\]\>.Value](../Payload-1/Value/README.md)\) |
| [Values](Values/README.md) | The arrray of values |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ExecuteResultAsync(ActionContext)](../ResponsePayload-1/ExecuteResultAsync/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [OnFormatting(OutputFormatterWriteContext)](../ResponsePayload-1/OnFormatting/README.md) |  \(Inherited from [ResponsePayload\<T\>](../ResponsePayload-1/README.md)\) |
| [ToString()](ToString/README.md) |  \(Overrides [Payload\<T\[\]\>.ToString](../Payload-1/ToString/README.md)\) |

