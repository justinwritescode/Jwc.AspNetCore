# BsonOutputFormatter Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.AspNetCore.Formatters](../README.md)

**Assembly**: JustinWritesCode\.AspNetCore\.Formatters\.dll

```csharp
public class BsonOutputFormatter : Microsoft.AspNetCore.Mvc.Formatters.OutputFormatter
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter) &#x2192; BsonOutputFormatter

### Implements

* Microsoft\.AspNetCore\.Mvc\.ApiExplorer\.[IApiResponseTypeMetadataProvider](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.apiexplorer.iapiresponsetypemetadataprovider)
* Microsoft\.AspNetCore\.Mvc\.Formatters\.[IOutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.ioutputformatter)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [BsonOutputFormatter()](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [SerializerSettings](SerializerSettings/README.md) | |
| [SupportedMediaTypes](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.supportedmediatypes) |  \(Inherited from [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [CanRead(InputFormatterContext)](CanRead/README.md) | |
| [CanWriteResult(OutputFormatterCanWriteContext)](CanWriteResult/README.md) |  \(Overrides [OutputFormatter.CanWriteResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.canwriteresult)\) |
| [CanWriteType(Type)](CanWriteType/README.md) |  \(Overrides [OutputFormatter.CanWriteType](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.canwritetype)\) |
| [CreateDefaultSerializerSettings()](CreateDefaultSerializerSettings/README.md) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetSupportedContentTypes(String, Type)](GetSupportedContentTypes/README.md) |  \(Overrides [OutputFormatter.GetSupportedContentTypes](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.getsupportedcontenttypes)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [WriteAsync(OutputFormatterWriteContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.writeasync) |  \(Inherited from [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter)\) |
| [WriteResponseBodyAsync(OutputFormatterWriteContext)](WriteResponseBodyAsync/README.md) |  \(Overrides [OutputFormatter.WriteResponseBodyAsync](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.writeresponsebodyasync)\) |
| [WriteResponseHeaders(OutputFormatterWriteContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.writeresponseheaders) |  \(Inherited from [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter)\) |

