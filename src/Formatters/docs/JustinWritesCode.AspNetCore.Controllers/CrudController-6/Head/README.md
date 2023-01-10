# CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>\.Head\(TId\) Method

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.AspNetCore\.Controllers\.[CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>](../README.md)

**Assembly**: JustinWritesCode\.AspNetCore\.Controllers\.dll

  
Determines if the item exists\.

```csharp
protected virtual System.Threading.Tasks.Task<JustinWritesCode.Payloads.ResponsePayload<TViewDto>> Head(TId id)
```

### Parameters

**id** &ensp; TId

The unique ID of the item to look up

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<JustinWritesCode\.Payloads\.ResponsePayload\<TViewDto\>\>

Nothing