# ApplicationMediaType\.ToString Method

[Home](../../../README.md)

**Containing Type**: System\.Net\.Mime\.MediaTypes\.[ApplicationMediaType](../README.md)

**Assembly**: System\.Net\.Mime\.MediaTypeNames\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ToString()](#3194910521) |  \(Overrides [ValueType.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring)\) \(Implements [IMediaType.ToString](../../IMediaType/ToString/README.md)\) |
| [ToString(IFormatProvider)](#2236974194) |  \(Implements [IConvertible.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.tostring)\) |
| [ToString(String, IFormatProvider)](#63233435) |  \(Implements [IFormattable.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable.tostring)\) |

<a id="3194910521"></a>

## ToString\(\) 

```csharp
public override string ToString()
```

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Implements

* System\.Net\.Mime\.MediaTypes\.[IMediaType.ToString](../../IMediaType/ToString/README.md)
<a id="2236974194"></a>

## ToString\(IFormatProvider\) 

```csharp
public string ToString(IFormatProvider provider)
```

### Parameters

**provider** &ensp; [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Implements

* [IConvertible.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.tostring)
<a id="63233435"></a>

## ToString\(String, IFormatProvider\) 

```csharp
public string ToString(string format, IFormatProvider formatProvider)
```

### Parameters

**format** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**formatProvider** &ensp; [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)

### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Implements

* [IFormattable.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable.tostring)
