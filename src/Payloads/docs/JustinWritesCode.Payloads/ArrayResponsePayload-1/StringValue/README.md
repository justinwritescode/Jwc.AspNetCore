# ArrayResponsePayload\<T\>\.StringValue Property

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.Payloads\.[ArrayResponsePayload\<T\>](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

  
The string representation of the array, which defaults to the string values of each of the elements separared by the [ArrayResponsePayload\<T\>.ItemSeparator](../ItemSeparator/README.md)

```csharp
[System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
[System.Text.Json.Serialization.JsonPropertyName("stringValue")]
[System.Xml.Serialization.XmlAttribute("stringValue")]
public override string StringValue { get; set; }
```

### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Attributes

* System\.Text\.Json\.Serialization\.[JsonIgnoreAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonignoreattribute)
* System\.Text\.Json\.Serialization\.[JsonPropertyNameAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonpropertynameattribute)
* System\.Xml\.Serialization\.[XmlAttributeAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute)

## Examples

Foo, Bar, Baz