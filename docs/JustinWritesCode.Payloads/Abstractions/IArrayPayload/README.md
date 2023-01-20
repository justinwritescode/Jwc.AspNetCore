# IArrayPayload Interface

[Home](../../../README.md) &#x2022; [Examples](#examples) &#x2022; [Remarks](#remarks) &#x2022; [Properties](#properties)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a payload with an array of values

```csharp
public interface IArrayPayload : JustinWritesCode.Payloads.Abstractions.IArrayPayload<object>,
    JustinWritesCode.Payloads.Abstractions.IPayload<object[]>
```

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IArrayPayload](../IArrayPayload-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\>
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload-1/README.md)\<[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]\>

## Examples

 

```
 var payload = new ArrayPayload<int>();
 payload.Values = new int[] { 1, 2, 3 };
 payload.Count = 3;
```

## Remarks

 [IArrayPayload\<T\>](../IArrayPayload-1/README.md) is a **IPayload\<T\[\]\>** with an array of values\.

## Properties

| Property | Summary |
| -------- | ------- |
| [Count](../IArrayPayload-1/Count/README.md) | The number of values in the array \(Inherited from [IArrayPayload\<T\>](../IArrayPayload-1/README.md)\) |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [Value](../IPayload-1/Value/README.md) | The strongly\-typed value of the payload \(Inherited from [IPayload\<T\>](../IPayload-1/README.md)\) |
| [Values](../IArrayPayload-1/Values/README.md) | The array of values \(Inherited from [IArrayPayload\<T\>](../IArrayPayload-1/README.md)\) |

