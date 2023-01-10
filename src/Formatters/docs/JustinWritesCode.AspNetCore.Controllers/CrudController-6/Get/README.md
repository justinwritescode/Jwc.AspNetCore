# CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>\.Get\(TId\) Method

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.AspNetCore\.Controllers\.[CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>](../README.md)

**Assembly**: JustinWritesCode\.AspNetCore\.Controllers\.dll

  
Retrieves a single item\.

```csharp
protected virtual System.Threading.Tasks.Task<JustinWritesCode.Payloads.ResponsePayload<TViewDto>> Get(TId id)
```

### Parameters

**id** &ensp; TId

The unique ID of the item to return

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<JustinWritesCode\.Payloads\.ResponsePayload\<TViewDto\>\>

A list of items\.