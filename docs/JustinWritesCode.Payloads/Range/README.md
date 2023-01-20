# Range Struct

[Home](../../README.md) &#x2022; [Fields](#fields) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators)

**Namespace**: [JustinWritesCode.Payloads](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

```csharp
[System.CodeDom.Compiler.GeneratedCode("Vogen", "3.0.0.0")]
[System.ComponentModel.TypeConverter(typeof(JustinWritesCode.Payloads.Range.RangeTypeConverter))]
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[System.Text.Json.Serialization.JsonConverter(typeof(JustinWritesCode.Payloads.Range.RangeSystemTextJsonConverter))]
[Vogen.ValueObject(typeof(Range), Vogen.Conversions.Default, null, Vogen.Customizations.None, Vogen.DeserializationStrictness.AllowValidAndKnownInstances)]
public record struct Range : IEquatable<JustinWritesCode.Payloads.Range>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; Range

### Attributes

* System\.CodeDom\.Compiler\.[GeneratedCodeAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.codedom.compiler.generatedcodeattribute)
* System\.ComponentModel\.[TypeConverterAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.typeconverterattribute)
* System\.Diagnostics\.CodeAnalysis\.[ExcludeFromCodeCoverageAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute)
* System\.Text\.Json\.Serialization\.[JsonConverterAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverterattribute)
* Vogen\.ValueObjectAttribute

### Implements

* [IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[Range](./README.md)\>

## Fields

| Field | Summary |
| ----- | ------- |
| [All](All/README.md) | |
| [AllString](AllString/README.md) |  \(Value = "items 0\-\*"\) |
| [Items](Items/README.md) |  \(Value = "items"\) |
| [RegexString](RegexString/README.md) |  \(Value = "items\\\\s\(?\<Start\>\[0\-9\]\+\)\\\\\-\(?:\(?\<End\>\[0\-9\]\+\)?\|\[\\\\\*\]\)"\) |

## Properties

| Property | Summary |
| -------- | ------- |
| [End](End/README.md) | |
| [PageNumber](PageNumber/README.md) | |
| [PageSize](PageSize/README.md) | |
| [Start](Start/README.md) | |
| [Value](Value/README.md) | Gets the underlying [Range](https://docs.microsoft.com/en-us/dotnet/api/system.range) value if set, otherwise a ValueObjectValidationException is thrown\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.equals) |  \(Inherited from [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype)\) |
| [From(Int32, Int32)](From/README.md#3981564189) | |
| [From(Range)](From/README.md#3465847835) | Builds an instance from the provided underlying type\. |
| [From(RangeItemHeaderValue)](From/README.md#2493552578) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.gethashcode) |  \(Inherited from [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Parse(String)](Parse/README.md) | |
| [Regex()](Regex/README.md) | |
| [ToString()](ToString/README.md) | Returns the string representation of the underlying [Range](https://docs.microsoft.com/en-us/dotnet/api/system.range)\. \(Overrides [ValueType.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring)\) |
| [Validate(Range)](Validate/README.md) | |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Explicit(Range to Range)](op_Explicit/README.md#653421190) | |
| [Explicit(Range to Range)](op_Explicit/README.md#487321268) | |

