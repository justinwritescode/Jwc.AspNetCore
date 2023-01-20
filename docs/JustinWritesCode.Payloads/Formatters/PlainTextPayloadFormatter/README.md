# PlainTextPayloadFormatter Class

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [JustinWritesCode.Payloads.Formatters](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

```csharp
public class PlainTextPayloadFormatter : Microsoft.AspNetCore.Mvc.Formatters.OutputFormatter
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter) &#x2192; PlainTextPayloadFormatter

### Implements

* Microsoft\.AspNetCore\.Mvc\.ApiExplorer\.[IApiResponseTypeMetadataProvider](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.apiexplorer.iapiresponsetypemetadataprovider)
* Microsoft\.AspNetCore\.Mvc\.Formatters\.[IOutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.ioutputformatter)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [PlainTextPayloadFormatter()](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [SupportedMediaTypes](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.supportedmediatypes) |  \(Inherited from [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [CanWriteResult(OutputFormatterCanWriteContext)](CanWriteResult/README.md) |  \(Overrides [OutputFormatter.CanWriteResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.canwriteresult)\) |
| [CanWriteType(Type)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.canwritetype) |  \(Inherited from [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetSupportedContentTypes(String, Type)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.getsupportedcontenttypes) |  \(Inherited from [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [WriteAsync(OutputFormatterWriteContext)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.writeasync) |  \(Inherited from [OutputFormatter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter)\) |
| [WriteResponseBodyAsync(OutputFormatterWriteContext)](WriteResponseBodyAsync/README.md) |  \(Overrides [OutputFormatter.WriteResponseBodyAsync](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.writeresponsebodyasync)\) |
| [WriteResponseHeaders(OutputFormatterWriteContext)](WriteResponseHeaders/README.md) |  \(Overrides [OutputFormatter.WriteResponseHeaders](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.formatters.outputformatter.writeresponseheaders)\) |

