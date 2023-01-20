# ResponsePayloadConverter\<T\> Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

```csharp
public class ResponsePayloadConverter<T> : System.Text.Json.Serialization.JsonConverter<JustinWritesCode.Payloads.ResponsePayload<T>>
```

### Type Parameters

**T**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [JsonConverter](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter) &#x2192; [JsonConverter\<T\>](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1) &#x2192; ResponsePayloadConverter\<T\>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ResponsePayloadConverter()](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [HandleNull](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1.handlenull) |  \(Inherited from [JsonConverter\<T\>](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [CanConvert(Type)](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1.canconvert) |  \(Inherited from [JsonConverter\<T\>](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Read(Utf8JsonReader, Type, JsonSerializerOptions)](Read/README.md) |  \(Overrides [JsonConverter\<ResponsePayload\<T\>\>.Read](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1.read)\) |
| [ReadAsPropertyName(Utf8JsonReader, Type, JsonSerializerOptions)](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1.readaspropertyname) |  \(Inherited from [JsonConverter\<T\>](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Write(Utf8JsonWriter, ResponsePayload\<T\>, JsonSerializerOptions)](Write/README.md) |  \(Overrides [JsonConverter\<ResponsePayload\<T\>\>.Write](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1.write)\) |
| [WriteAsPropertyName(Utf8JsonWriter, ResponsePayload\<T\>, JsonSerializerOptions)](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1.writeaspropertyname) |  \(Inherited from [JsonConverter\<T\>](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1)\) |

