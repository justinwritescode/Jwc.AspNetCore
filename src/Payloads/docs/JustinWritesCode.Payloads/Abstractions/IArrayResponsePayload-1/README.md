# IArrayResponsePayload\<T\> Interface

[Home](../../../README.md) &#x2022; [Examples](#examples) &#x2022; [Remarks](#remarks) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [See Also](#see-also)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a response payload with an array of values

```csharp
public interface IArrayResponsePayload<T> : JustinWritesCode.Payloads.Abstractions.IArrayPayload<T>,
    JustinWritesCode.Payloads.Abstractions.IResponsePayload<T[]>
```

### Type Parameters

**T**

The type of the values in the array

### Derived

* JustinWritesCode\.Payloads\.[ArrayResponsePayload](../../ArrayResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[ArrayResponsePayload\<T\>](../../ArrayResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[Pager](../../Pager/README.md)
* JustinWritesCode\.Payloads\.[Pager\<T\>](../../Pager-1/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../../SingleItemPager-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayResponsePayload](../IArrayResponsePayload/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IArrayPayload](../IArrayPayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload-1/README.md)\<T\[\]\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload-1/README.md)\<T\[\]\>
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Examples

```
var payload = new ArrayResponsePayload<int>(new[] { 1,2,3,4,5 });
```

## Remarks

  

   [IArrayResponsePayload\<T\>](./README.md) is a **IResponsePayload\<T\[\]\>** with an array of values\.
 


  

   [ArrayResponsePayload\<T\>](../../ArrayResponsePayload-1/README.md) is a **ResponsePayload\<T\[\]\>** with an array of values\.
 

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../IResponsePayload/ContentTypes/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Count](../IArrayPayload-1/Count/README.md) | The number of values in the array \(Inherited from [IArrayPayload\<T\>](../IArrayPayload-1/README.md)\) |
| [IsSuccess](../IResponsePayload/IsSuccess/README.md) | If the request was successful \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Message](../IResponsePayload/Message/README.md) | An optional message with information about the response \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [OutputFormatters](../IResponsePayload/OutputFormatters/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [StatusCode](../IResponsePayload/StatusCode/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [Value](../IPayload-1/Value/README.md) | The strongly\-typed value of the payload \(Inherited from [IPayload\<T\>](../IPayload-1/README.md)\) |
| [Values](../IArrayPayload-1/Values/README.md) | The array of values \(Inherited from [IArrayPayload\<T\>](../IArrayPayload-1/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [BadRequest()](../IResponsePayload-1/BadRequest/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [ExecuteResultAsync(ActionContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult.executeresultasync) |  \(Inherited from [IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)\) |
| [NoContent()](../IResponsePayload-1/NoContent/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [NotFound()](../IResponsePayload-1/NotFound/README.md) |  \(Inherited from [IResponsePayload\<T\>](../IResponsePayload-1/README.md)\) |
| [OnFormatting(OutputFormatterWriteContext)](../IResponsePayload/OnFormatting/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |

## See Also

* JustinWritesCode\.Payloads\.Abstractions\.[IArrayPayload\<T\>](../IArrayPayload-1/README.md)
