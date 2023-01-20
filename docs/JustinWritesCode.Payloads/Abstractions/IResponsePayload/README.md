# IResponsePayload Interface

[Home](../../../README.md) &#x2022; [Remarks](#remarks) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a response payload

```csharp
public interface IResponsePayload : JustinWritesCode.Payloads.Abstractions.IPayload,
    Microsoft.AspNetCore.Mvc.Infrastructure.IStatusCodeActionResult
```

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
* JustinWritesCode\.Payloads\.Abstractions\.[IPager](../IPager/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPager\<T\>](../IPager-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload\<T\>](../IResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[ISingleItemPager](../ISingleItemPager/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[ISingleItemPager\<T\>](../ISingleItemPager-1/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Remarks

The type of the payload is \.

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](ContentTypes/README.md) | |
| [IsSuccess](IsSuccess/README.md) | If the request was successful |
| [Message](Message/README.md) | An optional message with information about the response |
| [OutputFormatters](OutputFormatters/README.md) | |
| [StatusCode](StatusCode/README.md) | |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [Value](../IPayload/Value/README.md) | The value of the payload \(Inherited from [IPayload](../IPayload/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [ExecuteResultAsync(ActionContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult.executeresultasync) |  \(Inherited from [IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)\) |
| [OnFormatting(OutputFormatterWriteContext)](OnFormatting/README.md) | |

