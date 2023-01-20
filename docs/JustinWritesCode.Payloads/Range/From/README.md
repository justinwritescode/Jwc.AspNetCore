# Range\.From Method

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.Payloads\.[Range](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [From(Int32, Int32)](#3981564189) | |
| [From(Range)](#3465847835) | Builds an instance from the provided underlying type\. |
| [From(RangeItemHeaderValue)](#2493552578) | |

<a id="3981564189"></a>

## From\(Int32, Int32\) 

```csharp
public static JustinWritesCode.Payloads.Range From(int pageNumber, int pageSize = 2147483647)
```

### Parameters

**pageNumber** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**pageSize** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

### Returns

JustinWritesCode\.Payloads\.[Range](../README.md)

<a id="3465847835"></a>

## From\(Range\) 

  
Builds an instance from the provided underlying type\.

```csharp
public static JustinWritesCode.Payloads.Range From(Range value)
```

### Parameters

**value** &ensp; [Range](https://docs.microsoft.com/en-us/dotnet/api/system.range)

The underlying type\.

### Returns

JustinWritesCode\.Payloads\.[Range](../README.md)

An instance of this type\.<a id="2493552578"></a>

## From\(RangeItemHeaderValue\) 

```csharp
public static JustinWritesCode.Payloads.Range From(Microsoft.Net.Http.Headers.RangeItemHeaderValue rangeHeader)
```

### Parameters

**rangeHeader** &ensp; Microsoft\.Net\.Http\.Headers\.[RangeItemHeaderValue](https://docs.microsoft.com/en-us/dotnet/api/microsoft.net.http.headers.rangeitemheadervalue)

### Returns

JustinWritesCode\.Payloads\.[Range](../README.md)

