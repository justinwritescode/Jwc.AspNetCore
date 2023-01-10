# CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>\.Put\(TId, TUpdateDto\) Method

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.AspNetCore\.Controllers\.[CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>](../README.md)

**Assembly**: JustinWritesCode\.AspNetCore\.Controllers\.dll

  
Updates an item from a complete DTO

```csharp
protected virtual System.Threading.Tasks.Task<JustinWritesCode.Payloads.ResponsePayload<TViewDto>> Put(TId id, TUpdateDto dto)
```

### Parameters

**id** &ensp; TId

**dto** &ensp; TUpdateDto

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<JustinWritesCode\.Payloads\.ResponsePayload\<TViewDto\>\>

