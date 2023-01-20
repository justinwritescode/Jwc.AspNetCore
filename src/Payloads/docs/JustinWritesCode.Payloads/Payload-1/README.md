# Payload\<T\> Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Explicit Interface Implementations](#explicit-interface-implementations)

**Namespace**: [JustinWritesCode.Payloads](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

```csharp
public class Payload<T> : JustinWritesCode.Payloads.Abstractions.IPayload<T>
```

### Type Parameters

**T**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; Payload\<T\>

### Derived

* JustinWritesCode\.Payloads\.[ArrayPayload](../ArrayPayload/README.md)
* JustinWritesCode\.Payloads\.[ArrayPayload\<T\>](../ArrayPayload-1/README.md)
* JustinWritesCode\.Payloads\.[ArrayResponsePayload](../ArrayResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[ArrayResponsePayload\<T\>](../ArrayResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[BooleanResponsePayload](../BooleanResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[CreatedResponsePayload](../CreatedResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[CreatedResponsePayload\<T\>](../CreatedResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[IntPayload](../IntPayload/README.md)
* JustinWritesCode\.Payloads\.[IntResponsePayload](../IntResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[NumericPayload](../NumericPayload/README.md)
* JustinWritesCode\.Payloads\.[NumericResponsePayload](../NumericResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[Pager](../Pager/README.md)
* JustinWritesCode\.Payloads\.[Pager\<T\>](../Pager-1/README.md)
* JustinWritesCode\.Payloads\.[Payload](../Payload/README.md)
* JustinWritesCode\.Payloads\.[ResponsePayload](../ResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[ResponsePayload\<T\>](../ResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../SingleItemPager-1/README.md)
* JustinWritesCode\.Payloads\.[StringPayload](../StringPayload/README.md)
* JustinWritesCode\.Payloads\.[StringResponsePayload](../StringResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[StringWithRegexPayload](../StringWithRegexPayload/README.md)
* JustinWritesCode\.Payloads\.[UriPayload](../UriPayload/README.md)
* JustinWritesCode\.Payloads\.[UriResponsePayload](../UriResponsePayload/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../Abstractions/IPayload-1/README.md)\<T\>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [Payload()](-ctor/README.md#3471208027) | |
| [Payload(T, String)](-ctor/README.md#788994685) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [StringValue](StringValue/README.md) | |
| [Value](Value/README.md) |  \(Implements [IPayload\<T\>.Value](../Abstractions/IPayload-1/Value/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](ToString/README.md) |  \(Overrides [Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring)\) |

## Explicit Interface Implementations

| Member | Summary |
| ------ | ------- |
| [IPayload.Value](JustinWritesCode-Payloads-Abstractions-IPayload-Value/README.md) | |

