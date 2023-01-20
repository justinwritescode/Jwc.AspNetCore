# ArrayPayload\<T\> Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Fields](#fields) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Explicit Interface Implementations](#explicit-interface-implementations)

**Namespace**: [JustinWritesCode.Payloads](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

```csharp
public class ArrayPayload<T> : JustinWritesCode.Payloads.Payload<T[]>,
    JustinWritesCode.Payloads.Abstractions.IArrayPayload<T>,
    JustinWritesCode.Payloads.Abstractions.IPayload<T[]>
```

### Type Parameters

**T**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [Payload\<T\>](../Payload-1/README.md) &#x2192; ArrayPayload\<T\>

### Derived

* JustinWritesCode\.Payloads\.[ArrayPayload](../ArrayPayload/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IArrayPayload](../Abstractions/IArrayPayload-1/README.md)\<T\>
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload-1/README.md)\<T\[\]\>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ArrayPayload()](-ctor/README.md#846806095) | |
| [ArrayPayload(IEnumerable\<T\>, String, String)](-ctor/README.md#3328206305) | |

## Fields

| Field | Summary |
| ----- | ------- |
| [DefaultItemSeparator](DefaultItemSeparator/README.md) |  \(Value = ", "\) |

## Properties

| Property | Summary |
| -------- | ------- |
| [Count](Count/README.md) |  \(Implements [IArrayPayload\<T\>.Count](../Abstractions/IArrayPayload-1/Count/README.md)\) |
| [ItemSeparator](ItemSeparator/README.md) | |
| [StringValue](StringValue/README.md) |  \(Overrides [Payload\<T\[\]\>.StringValue](../Payload-1/StringValue/README.md)\) |
| [Value](Value/README.md) |  \(Overrides [Payload\<T\[\]\>.Value](../Payload-1/Value/README.md)\) \(Implements [IPayload\<T\[\]\>.Value](../Abstractions/IPayload-1/Value/README.md)\) |
| [Values](Values/README.md) |  \(Implements [IArrayPayload\<T\>.Values](../Abstractions/IArrayPayload-1/Values/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](ToString/README.md) |  \(Overrides [Payload\<T\[\]\>.ToString](../Payload-1/ToString/README.md)\) |

## Explicit Interface Implementations

| Member | Summary |
| ------ | ------- |
| [IPayload.Value](JustinWritesCode-Payloads-Abstractions-IPayload-Value/README.md) | |

