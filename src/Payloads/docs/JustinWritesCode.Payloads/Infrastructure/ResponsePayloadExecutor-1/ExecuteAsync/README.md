# ResponsePayloadExecutor\<T\>\.ExecuteAsync\(ActionContext, IResponsePayload\<T\>\) Method

[Home](../../../../README.md)

**Containing Type**: JustinWritesCode\.Payloads\.Infrastructure\.[ResponsePayloadExecutor\<T\>](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Executes the [ObjectResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.objectresult)\.

```csharp
public System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Mvc.ActionContext context, JustinWritesCode.Payloads.Abstractions.IResponsePayload<T> payload)
```

### Parameters

**context** &ensp; Microsoft\.AspNetCore\.Mvc\.[ActionContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.actioncontext)

The [ActionContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.actioncontext) for the current request\.

**payload** &ensp; JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../../../Abstractions/IResponsePayload-1/README.md)\<T\>

The [IResponsePayload](../../../Abstractions/IResponsePayload/README.md)\.

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)

A [Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task) which will complete once the [IResponsePayload](../../../Abstractions/IResponsePayload/README.md) is written to the response\.

### Implements

* Microsoft\.AspNetCore\.Mvc\.Infrastructure\.[IActionResultExecutor\<IResponsePayload\<T\>\>.ExecuteAsync](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.iactionresultexecutor-1.executeasync)
