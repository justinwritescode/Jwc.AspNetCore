# SingleItemPager\<T\> Constructors

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

## Overloads

| Constructor | Summary |
| ----------- | ------- |
| [SingleItemPager()](#999670316) | |
| [SingleItemPager(IQueryable\<T\>, Int32)](#2914570455) | |
| [SingleItemPager(T, Int32, Int32)](#837098535) | |

<a id="999670316"></a>

## SingleItemPager\(\) 

```csharp
public SingleItemPager()
```

<a id="2914570455"></a>

## SingleItemPager\(IQueryable\<T\>, Int32\) 

```csharp
public SingleItemPager(System.Linq.IQueryable<T> items, int itemNumber)
```

### Parameters

**items** &ensp; System\.Linq\.[IQueryable](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1)\<T\>

**itemNumber** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<a id="837098535"></a>

## SingleItemPager\(T, Int32, Int32\) 

```csharp
public SingleItemPager(T value, int pageNumber, int totalRecords)
```

### Parameters

**value** &ensp; T

**pageNumber** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**totalRecords** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)