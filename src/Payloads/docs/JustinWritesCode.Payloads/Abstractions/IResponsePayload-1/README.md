# IResponsePayload\<T\> Interface

[Home](../../../README.md) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a strongly\-typed response payload of type **T**\.

```csharp
public interface IResponsePayload<T> : JustinWritesCode.Payloads.Abstractions.IPayload<T>,
    JustinWritesCode.Payloads.Abstractions.IResponsePayload
```

### Type Parameters

**T**

### Derived

* JustinWritesCode\.Payloads\.[ArrayResponsePayload](../../ArrayResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[ArrayResponsePayload\<T\>](../../ArrayResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[BooleanResponsePayload](../../BooleanResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[CreatedResponsePayload](../../CreatedResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[CreatedResponsePayload\<T\>](../../CreatedResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[IntResponsePayload](../../IntResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[NumericResponsePayload](../../NumericResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[Pager](../../Pager/README.md)
* JustinWritesCode\.Payloads\.[Pager\<T\>](../../Pager-1/README.md)
* JustinWritesCode\.Payloads\.[ResponsePayload](../../ResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[ResponsePayload\<T\>](../../ResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../../SingleItemPager-1/README.md)
* JustinWritesCode\.Payloads\.[StringResponsePayload](../../StringResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[UriResponsePayload](../../UriResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayResponsePayload](../IArrayResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayResponsePayload\<T\>](../IArrayResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IErrorResponsePayload](../IErrorResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IErrorResponsePayload\<T\>](../IErrorResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPager\<T\>](../IPager-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[ISingleItemPager](../ISingleItemPager/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../IResponsePayload/README.md)
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](../IResponsePayload/ContentTypes/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [IsSuccess](../IResponsePayload/IsSuccess/README.md) | If the request was successful \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [Message](../IResponsePayload/Message/README.md) | An optional message with information about the response \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [OutputFormatters](../IResponsePayload/OutputFormatters/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [StatusCode](../IResponsePayload/StatusCode/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [Value](../IPayload-1/Value/README.md) | The strongly\-typed value of the payload \(Inherited from [IPayload\<T\>](../IPayload-1/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [BadRequest()](BadRequest/README.md) | |
| [ExecuteResultAsync(ActionContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult.executeresultasync) |  \(Inherited from [IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)\) |
| [NoContent()](NoContent/README.md) | |
| [NotFound()](NotFound/README.md) | |
| [OnFormatting(OutputFormatterWriteContext)](../IResponsePayload/OnFormatting/README.md) |  \(Inherited from [IResponsePayload](../IResponsePayload/README.md)\) |

