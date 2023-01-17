# ApplicationMediaType Struct

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Fields](#fields) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators) &#x2022; [Explicit Interface Implementations](#explicit-interface-implementations) &#x2022; [Classes](#classes)

**Namespace**: [System.Net.Mime.MediaTypes](../README.md)

**Assembly**: System\.Net\.Mime\.MediaTypeNames\.dll

```csharp
[System.CodeDom.Compiler.GeneratedCode("JustinWritesCode.Enumerations.CodeGeneration.V2", "0.0.1.0")]
public record struct ApplicationMediaType : IComparable,
    IComparable<System.Net.Mime.MediaTypes.ApplicationMediaType>,
    IConvertible,
    IEquatable<System.Net.Mime.MediaTypes.ApplicationMediaType>,
    IFormattable,
    System.Net.Mime.MediaTypes.IMediaType,
    JustinWritesCode.Enumerations.Abstractions.IEnumeration<System.Net.Mime.MediaTypes.ApplicationMediaType, int>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; ApplicationMediaType

### Attributes

* System\.CodeDom\.Compiler\.[GeneratedCodeAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.codedom.compiler.generatedcodeattribute)

### Implements

* [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable)
* [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1)\<[ApplicationMediaType](./README.md)\>
* [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)
* [IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[ApplicationMediaType](./README.md)\>
* [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)
* System\.Net\.Mime\.MediaTypes\.[IMediaType](../IMediaType/README.md)
* JustinWritesCode\.Abstractions\.IHaveADescription
* JustinWritesCode\.Abstractions\.IHaveAName
* JustinWritesCode\.Abstractions\.IHaveAValue
* JustinWritesCode\.Abstractions\.IIdentifiable
* JustinWritesCode\.Enumerations\.Abstractions\.IEnumeration
* JustinWritesCode\.Enumerations\.Abstractions\.IEnumeration\<ApplicationMediaType, Int32\>
* JustinWritesCode\.Enumerations\.Abstractions\.IEnumeration\<ApplicationMediaType\>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ApplicationMediaType(ApplicationMediaTypesEnum, Int32, String, String)](-ctor/README.md) | |

## Fields

| Field | Summary |
| ----- | ------- |
| [All](All/README.md) | |
| [Count](Count/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Description](Description/README.md) |  \(Implements [IMediaType.Description](../IMediaType/Description/README.md)\) |
| [DisplayName](DisplayName/README.md) |  \(Implements [IMediaType.DisplayName](../IMediaType/DisplayName/README.md)\) |
| [FieldInfo](FieldInfo/README.md) | |
| [GroupName](GroupName/README.md) |  \(Implements [IMediaType.GroupName](../IMediaType/GroupName/README.md)\) |
| [Id](Id/README.md) |  \(Implements [IMediaType.Id](../IMediaType/Id/README.md)\) |
| [Name](Name/README.md) |  \(Implements [IMediaType.Name](../IMediaType/Name/README.md)\) |
| [Order](Order/README.md) |  \(Implements [IMediaType.Order](../IMediaType/Order/README.md)\) |
| [Prompt](Prompt/README.md) |  \(Implements [IMediaType.Prompt](../IMediaType/Prompt/README.md)\) |
| [ShortName](ShortName/README.md) |  \(Implements [IMediaType.ShortName](../IMediaType/ShortName/README.md)\) |
| [Uri](Uri/README.md) |  \(Implements [IMediaType.Uri](../IMediaType/Uri/README.md)\) |
| [Value](Value/README.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [CompareTo(ApplicationMediaType)](CompareTo/README.md#295676538) |  \(Implements [IComparable\<ApplicationMediaType\>.CompareTo](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1.compareto)\) |
| [CompareTo(Object)](CompareTo/README.md#583479169) |  \(Implements [IComparable.CompareTo](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable.compareto)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.equals) |  \(Inherited from [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype)\) |
| [FromDescription(String, Boolean)](FromDescription/README.md#40899690) | |
| [FromDescription(String)](FromDescription/README.md#1536018693) | |
| [FromId(Int32, Boolean)](FromId/README.md#1329124020) | |
| [FromId(Int32)](FromId/README.md#4144075226) | |
| [FromName(String, Boolean)](FromName/README.md#2744462284) | |
| [FromName(String)](FromName/README.md#2911380011) | |
| [FromShortName(String, Boolean)](FromShortName/README.md#2714733846) | |
| [FromShortName(String)](FromShortName/README.md#869875290) | |
| [FromValue(ApplicationMediaTypesEnum, Boolean)](FromValue/README.md#1668621102) | |
| [FromValue(ApplicationMediaTypesEnum)](FromValue/README.md#2487834702) | |
| [GetAll()](GetAll/README.md) | |
| [GetAllExcept(ApplicationMediaType\[\])](GetAllExcept/README.md#3486578849) | |
| [GetAllExcept(ApplicationMediaTypesEnum\[\])](GetAllExcept/README.md#1201102524) | |
| [GetAllExcept(Int32\[\])](GetAllExcept/README.md#181261790) | |
| [GetAllExcept(String\[\])](GetAllExcept/README.md#2405153812) | |
| [GetCustomAttribute\<TAttribute\>()](GetCustomAttribute/README.md) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.gethashcode) |  \(Inherited from [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetTypeCode()](GetTypeCode/README.md) |  \(Implements [IConvertible.GetTypeCode](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.gettypecode)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Parse(String, IFormatProvider)](Parse/README.md) | |
| [ToBoolean(IFormatProvider)](ToBoolean/README.md) |  \(Implements [IConvertible.ToBoolean](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.toboolean)\) |
| [ToByte(IFormatProvider)](ToByte/README.md) |  \(Implements [IConvertible.ToByte](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.tobyte)\) |
| [ToChar(IFormatProvider)](ToChar/README.md) |  \(Implements [IConvertible.ToChar](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.tochar)\) |
| [ToDateTime(IFormatProvider)](ToDateTime/README.md) |  \(Implements [IConvertible.ToDateTime](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.todatetime)\) |
| [ToDecimal(IFormatProvider)](ToDecimal/README.md) |  \(Implements [IConvertible.ToDecimal](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.todecimal)\) |
| [ToDouble(IFormatProvider)](ToDouble/README.md) |  \(Implements [IConvertible.ToDouble](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.todouble)\) |
| [ToInt16(IFormatProvider)](ToInt16/README.md) |  \(Implements [IConvertible.ToInt16](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.toint16)\) |
| [ToInt32(IFormatProvider)](ToInt32/README.md) |  \(Implements [IConvertible.ToInt32](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.toint32)\) |
| [ToInt64(IFormatProvider)](ToInt64/README.md) |  \(Implements [IConvertible.ToInt64](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.toint64)\) |
| [ToSByte(IFormatProvider)](ToSByte/README.md) |  \(Implements [IConvertible.ToSByte](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.tosbyte)\) |
| [ToSingle(IFormatProvider)](ToSingle/README.md) |  \(Implements [IConvertible.ToSingle](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.tosingle)\) |
| [ToString()](ToString/README.md#3194910521) |  \(Overrides [ValueType.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring)\) \(Implements [IMediaType.ToString](../IMediaType/ToString/README.md)\) |
| [ToString(IFormatProvider)](ToString/README.md#2236974194) |  \(Implements [IConvertible.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.tostring)\) |
| [ToString(String, IFormatProvider)](ToString/README.md#63233435) |  \(Implements [IFormattable.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable.tostring)\) |
| [ToType(Type, IFormatProvider)](ToType/README.md) |  \(Implements [IConvertible.ToType](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.totype)\) |
| [ToUInt16(IFormatProvider)](ToUInt16/README.md) |  \(Implements [IConvertible.ToUInt16](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.touint16)\) |
| [ToUInt32(IFormatProvider)](ToUInt32/README.md) |  \(Implements [IConvertible.ToUInt32](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.touint32)\) |
| [ToUInt64(IFormatProvider)](ToUInt64/README.md) |  \(Implements [IConvertible.ToUInt64](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.touint64)\) |
| [TryFromDescription(String, ApplicationMediaType, Boolean)](TryFromDescription/README.md#2683803449) | |
| [TryFromDescription(String, ApplicationMediaType)](TryFromDescription/README.md#3655697482) | |
| [TryFromId(Int32, ApplicationMediaType, Boolean)](TryFromId/README.md#3196451567) | |
| [TryFromId(Int32, ApplicationMediaType)](TryFromId/README.md#2186403946) | |
| [TryFromName(String, ApplicationMediaType, Boolean)](TryFromName/README.md#223507663) | |
| [TryFromName(String, ApplicationMediaType)](TryFromName/README.md#1508340592) | |
| [TryFromShortName(String, ApplicationMediaType, Boolean)](TryFromShortName/README.md#3895824126) | |
| [TryFromShortName(String, ApplicationMediaType)](TryFromShortName/README.md#3516167523) | |
| [TryFromValue(ApplicationMediaTypesEnum, ApplicationMediaType, Boolean)](TryFromValue/README.md#1218847184) | |
| [TryFromValue(ApplicationMediaTypesEnum, ApplicationMediaType)](TryFromValue/README.md#2120023473) | |
| [TryParse(String, ApplicationMediaType)](TryParse/README.md#471660498) | |
| [TryParse(String, IFormatProvider, ApplicationMediaType)](TryParse/README.md#785269692) | |

## Operators

| Operator | Summary |
| -------- | ------- |
| [GreaterThan(ApplicationMediaType, ApplicationMediaType)](op_GreaterThan/README.md) | |
| [GreaterThanOrEqual(ApplicationMediaType, ApplicationMediaType)](op_GreaterThanOrEqual/README.md) | |
| [LessThan(ApplicationMediaType, ApplicationMediaType)](op_LessThan/README.md) | |
| [LessThanOrEqual(ApplicationMediaType, ApplicationMediaType)](op_LessThanOrEqual/README.md) | |

## Explicit Interface Implementations

| Member | Summary |
| ------ | ------- |
| [IHaveAValue.Value](JustinWritesCode-Abstractions-IHaveAValue-Value/README.md) | |
| [IIdentifiable.Id](JustinWritesCode-Abstractions-IIdentifiable-Id/README.md) | |

## Classes

| Class | Summary |
| ----- | ------- |
| [Any](Any/README.md) | application/\* |
| [Base](Base/README.md) | application |
| [Bson](Bson/README.md) | application/bson |
| [Example](Example/README.md) | application/example |
| [FormUrlEncoded](FormUrlEncoded/README.md) | application/x\-www\-formurlencoded |
| [Json](Json/README.md) | application/json |
| [JsonPatch](JsonPatch/README.md) | application/json\-patch\+json |
| [MessagePack](MessagePack/README.md) | application/x\-msgpack |
| [OctetStream](OctetStream/README.md) | application/octet\-stream |
| [Pdf](Pdf/README.md) | application/pdf |
| [ProblemJson](ProblemJson/README.md) | application/json\+problem |
| [Rtf](Rtf/README.md) | application/rtf |
| [Soap](Soap/README.md) | application/soap\+xml |
| [Xml](Xml/README.md) | application/xml |
| [Zip](Zip/README.md) | application/zip |

