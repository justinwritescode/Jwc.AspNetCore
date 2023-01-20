# IResponsePayload\.IsSuccess Property

[Home](../../../../README.md)

**Containing Type**: JustinWritesCode\.Payloads\.Abstractions\.[IResponsePayload](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
If the request was successful

```csharp
[System.Text.Json.Serialization.JsonPropertyName("success")]
bool IsSuccess { get; }
```

### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

 if the request was successful; otherwise, \.

### Attributes

* System\.Text\.Json\.Serialization\.[JsonPropertyNameAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonpropertynameattribute)

## Examples

true

## Remarks

Defaults to true