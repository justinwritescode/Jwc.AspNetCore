# BsonInputFormatter Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.AspNetCore.Formatters](../README.md)

**Assembly**: JustinWritesCode\.AspNetCore\.Formatters\.dll

```csharp
public class BsonInputFormatter : Microsoft.AspNetCore.Mvc.Formatters.InputFormatter
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [InputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter) &#x2192; BsonInputFormatter

### Implements

* Microsoft\.AspNetCore\.Mvc\.ApiExplorer\.[IApiRequestFormatMetadataProvider](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.apiexplorer.iapirequestformatmetadataprovider)
* Microsoft\.AspNetCore\.Mvc\.Formatters\.[IInputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.iinputformatter)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [BsonInputFormatter()](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [SerializerSettings](SerializerSettings/README.md) | |
| [SupportedMediaTypes](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter.supportedmediatypes) |  \(Inherited from [InputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [CanRead(InputFormatterContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter.canread) |  \(Inherited from [InputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter)\) |
| [CanReadType(Type)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter.canreadtype) |  \(Inherited from [InputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter)\) |
| [CreateDefaultSerializerSettings()](CreateDefaultSerializerSettings/README.md) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetDefaultValueForType(Type)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter.getdefaultvaluefortype) |  \(Inherited from [InputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetSupportedContentTypes(String, Type)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter.getsupportedcontenttypes) |  \(Inherited from [InputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ReadAsync(InputFormatterContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter.readasync) |  \(Inherited from [InputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter)\) |
| [ReadRequestBodyAsync(InputFormatterContext)](ReadRequestBodyAsync/README.md) |  \(Overrides [InputFormatter.ReadRequestBodyAsync](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.inputformatter.readrequestbodyasync)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

