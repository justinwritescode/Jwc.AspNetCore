# ResponsePayloadExecutor\<T\> Class

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads.Infrastructure](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

```csharp
public class ResponsePayloadExecutor<T> : JustinWritesCode.Abstractions.ILog,
    Microsoft.AspNetCore.Mvc.Infrastructure.IActionResultExecutor<JustinWritesCode.Payloads.Abstractions.IResponsePayload<T>>
```

### Type Parameters

**T**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; ResponsePayloadExecutor\<T\>

### Implements

* JustinWritesCode\.Abstractions\.ILog
* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IActionResultExecutor](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.iactionresultexecutor-1)\<[IResponsePayload](../../Abstractions/IResponsePayload-1/README.md)\<T\>\>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ResponsePayloadExecutor(OutputFormatterSelector, ILogger\<ResponsePayloadExecutor\<T\>\>, IOptions\<MvcOptions\>)](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Logger](Logger/README.md) |  \(Implements ILog\.Logger\) |
| [WriterFactory](WriterFactory/README.md) | Gets the writer factory delegate\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ExecuteAsync(ActionContext, IResponsePayload\<T\>)](ExecuteAsync/README.md) | Executes the [ObjectResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.objectresult)\. \(Implements [IActionResultExecutor\<IResponsePayload\<T\>\>.ExecuteAsync](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.iactionresultexecutor-1.executeasync)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

