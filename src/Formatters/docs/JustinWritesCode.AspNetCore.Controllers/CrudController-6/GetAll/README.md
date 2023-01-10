# CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>\.GetAll\(Range, Expression\<Func\<TViewDto, Boolean\>\>, String, String, ListSortDirection\) Method

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.AspNetCore\.Controllers\.[CrudController\<TModel, TInsertDto, TUpdateDto, TViewDto, TDbContext, TId\>](../README.md)

**Assembly**: JustinWritesCode\.AspNetCore\.Controllers\.dll

  
Retrieves a list of items\.

```csharp
protected virtual System.Threading.Tasks.Task<JustinWritesCode.Payloads.Pager<TViewDto>> GetAll(JustinWritesCode.Payloads.Range range, System.Linq.Expressions.Expression<Func<TViewDto, bool>> filter = null, string itemSeparator = "\r\n", string orderBy = null, System.ComponentModel.ListSortDirection sortDirection = Ascending)
```

### Parameters

**range** &ensp; JustinWritesCode\.Payloads\.Range

**filter** &ensp; System\.Linq\.Expressions\.[Expression](https://docs.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression-1)\<[Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2)\<TViewDto, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)\>\>

**itemSeparator** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The string to place in between items when rendering the payload as a plain text value

**orderBy** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The name of the property to use to sort the returned items

**sortDirection** &ensp; System\.ComponentModel\.[ListSortDirection](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.listsortdirection)

Whether to sort the items in ascending or descending order

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<JustinWritesCode\.Payloads\.Pager\<TViewDto\>\>

A list of items\.