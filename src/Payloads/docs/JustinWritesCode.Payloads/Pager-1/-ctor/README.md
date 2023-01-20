# Pager\<T\> Constructors

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.Payloads\.[Pager\<T\>](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

## Overloads

| Constructor | Summary |
| ----------- | ------- |
| [Pager()](#1475148317) | |
| [Pager(IQueryable\<T\>, Range, String, String, Int32?)](#3171484300) | |
| [Pager(T\[\], Int32, Int32, Int32, String, String)](#540838811) | |

<a id="1475148317"></a>

## Pager\(\) 

```csharp
public Pager()
```

<a id="3171484300"></a>

## Pager\(IQueryable\<T\>, Range, String, String, Int32?\) 

```csharp
public Pager(System.Linq.IQueryable<T> items, JustinWritesCode.Payloads.Range ramge, string message = null, string itemSeparator = ", ", int? statusCode = null)
```

### Parameters

**items** &ensp; System\.Linq\.[IQueryable](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1)\<T\>

**ramge** &ensp; JustinWritesCode\.Payloads\.[Range](../../Range/README.md)

**message** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**itemSeparator** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**statusCode** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)?<a id="540838811"></a>

## Pager\(T\[\], Int32, Int32, Int32, String, String\) 

```csharp
public Pager(T[] items, int page, int pageSize, int totalRecords, string message = null, string itemSeparator = ", ")
```

### Parameters

**items** &ensp; T\[\]

**page** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**pageSize** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**totalRecords** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**message** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**itemSeparator** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)