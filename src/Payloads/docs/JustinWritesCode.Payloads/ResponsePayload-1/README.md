# ResponsePayload\<T\> Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators) &#x2022; [Explicit Interface Implementations](#explicit-interface-implementations)

**Namespace**: [JustinWritesCode.Payloads](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a strongly\-typed response payload of type **T**\.

```csharp
public class ResponsePayload<T> : JustinWritesCode.Payloads.Payload<T>,
    JustinWritesCode.Payloads.Abstractions.IPayload,
    JustinWritesCode.Payloads.Abstractions.IResponsePayload<T>
```

### Type Parameters

**T**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [Payload\<T\>](../Payload-1/README.md) &#x2192; ResponsePayload\<T\>

### Derived

* JustinWritesCode\.Payloads\.[ArrayResponsePayload](../ArrayResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[BooleanResponsePayload](../BooleanResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[CreatedResponsePayload](../CreatedResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[CreatedResponsePayload\<T\>](../CreatedResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[IntResponsePayload](../IntResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[NumericResponsePayload](../NumericResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[Pager](../Pager/README.md)
* JustinWritesCode\.Payloads\.[Pager\<T\>](../Pager-1/README.md)
* JustinWritesCode\.Payloads\.[ResponsePayload](../ResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../SingleItemPager-1/README.md)
* JustinWritesCode\.Payloads\.[StringResponsePayload](../StringResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[UriResponsePayload](../UriResponsePayload/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../Abstractions/IResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../Abstractions/IResponsePayload-1/README.md)\<T\>
* Microsoft\.AspNetCore\.Mvc\.[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IStatusCodeActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.istatuscodeactionresult)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ResponsePayload()](-ctor/README.md#2021198461) | |
| [ResponsePayload(T, String, String, HttpStatusCode)](-ctor/README.md#4126597076) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [ContentTypes](ContentTypes/README.md) | |
| [IsSuccess](IsSuccess/README.md) | |
| [Message](Message/README.md) | |
| [OutputFormatters](OutputFormatters/README.md) | |
| [StatusCode](StatusCode/README.md) | |
| [StringValue](../Payload-1/StringValue/README.md) |  \(Inherited from [Payload\<T\>](../Payload-1/README.md)\) |
| [Value](../Payload-1/Value/README.md) |  \(Inherited from [Payload\<T\>](../Payload-1/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [BadRequest(String)](BadRequest/README.md) | |
| [Created(T, String, uri)](Created/README.md) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ExecuteResultAsync(ActionContext)](ExecuteResultAsync/README.md) | |
| [Forbidden(String)](Forbidden/README.md) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetOpenApiSchema()](GetOpenApiSchema/README.md) | |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [InternalServerError(String)](InternalServerError/README.md) | |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [NoContent(String)](NoContent/README.md) | |
| [NotFound(String)](NotFound/README.md) | |
| [OnFormatting(OutputFormatterWriteContext)](OnFormatting/README.md) | |
| [Problem(String, HttpStatusCode)](Problem/README.md) | |
| [ToString()](../Payload-1/ToString/README.md) |  \(Inherited from [Payload\<T\>](../Payload-1/README.md)\) |
| [Unauthorized(String)](Unauthorized/README.md) | |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Implicit(ResponsePayload to T\<T\>)](op_Implicit/README.md#3658546681) | |
| [Implicit\<T to ResponsePayload\>(T)](op_Implicit/README.md#2315518155) | |

## Explicit Interface Implementations

| Member | Summary |
| ------ | ------- |
| [IPayload.Value](JustinWritesCode-Payloads-Abstractions-IPayload-Value/README.md) | |
| [IPayload\<T\>.Value](JustinWritesCode-Payloads-Abstractions-IPayload-T--Value/README.md) | |
| [IResponsePayload.StatusCode](JustinWritesCode-Payloads-Abstractions-IResponsePayload-StatusCode/README.md) | |

