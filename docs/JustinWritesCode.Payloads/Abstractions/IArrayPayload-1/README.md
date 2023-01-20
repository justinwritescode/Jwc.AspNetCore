# IArrayPayload\<T\> Interface

[Home](../../../README.md) &#x2022; [Examples](#examples) &#x2022; [Remarks](#remarks) &#x2022; [Properties](#properties)

**Namespace**: [JustinWritesCode.Payloads.Abstractions](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
Represents a payload with an array of values

```csharp
public interface IArrayPayload<T> : JustinWritesCode.Payloads.Abstractions.IPayload<T[]>
```

### Type Parameters

**T**

The type of the values in the array

### Derived

* JustinWritesCode\.Payloads\.[ArrayPayload](../../ArrayPayload/README.md)
* JustinWritesCode\.Payloads\.[ArrayPayload\<T\>](../../ArrayPayload-1/README.md)
* JustinWritesCode\.Payloads\.[ArrayResponsePayload](../../ArrayResponsePayload/README.md)
* JustinWritesCode\.Payloads\.[ArrayResponsePayload\<T\>](../../ArrayResponsePayload-1/README.md)
* JustinWritesCode\.Payloads\.[Pager](../../Pager/README.md)
* JustinWritesCode\.Payloads\.[Pager\<T\>](../../Pager-1/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager](../../SingleItemPager/README.md)
* JustinWritesCode\.Payloads\.[SingleItemPager\<T\>](../../SingleItemPager-1/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayPayload](../IArrayPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayResponsePayload](../IArrayResponsePayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IArrayResponsePayload\<T\>](../IArrayResponsePayload-1/README.md)

### Implements

* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload/README.md)
* JustinWritesCode\.Payloads\.Abstractions\.[IPayload](../IPayload-1/README.md)\<T\[\]\>

## Examples

 

```
 var payload = new ArrayPayload<int>();
 payload.Values = new int[] { 1, 2, 3 };
 payload.Count = 3;
```

## Remarks

 [IArrayPayload\<T\>](./README.md) is a **IPayload\<T\[\]\>** with an array of values\.

## Properties

| Property | Summary |
| -------- | ------- |
| [Count](Count/README.md) | The number of values in the array |
| [StringValue](../IPayload/StringValue/README.md) | The value of the payload as a string \(Inherited from [IPayload](../IPayload/README.md)\) |
| [Value](../IPayload-1/Value/README.md) | The strongly\-typed value of the payload \(Inherited from [IPayload\<T\>](../IPayload-1/README.md)\) |
| [Values](Values/README.md) | The array of values |

