# HttpRequestHeaderName Struct

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Fields](#fields) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Operators](#operators) &#x2022; [Explicit Interface Implementations](#explicit-interface-implementations) &#x2022; [Classes](#classes)

**Namespace**: [System.Net.Http.Headers](../README.md)

**Assembly**: JustinWritesCode\.Http\.dll

  
    Contains the standard set of headers applicable to an HTTP request\.
    

```csharp
[System.CodeDom.Compiler.GeneratedCode("JustinWritesCode.Enumerations.CodeGeneration.V2", "0.0.1.0")]
public record struct HttpRequestHeaderName : IComparable,
    IComparable<System.Net.Http.Headers.HttpRequestHeaderName>,
    IConvertible,
    IEquatable<System.Net.Http.Headers.HttpRequestHeaderName>,
    IFormattable,
    JustinWritesCode.Enumerations.Abstractions.IEnumeration<System.Net.Http.Headers.HttpRequestHeaderName, int>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; HttpRequestHeaderName

### Attributes

* System\.CodeDom\.Compiler\.[GeneratedCodeAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.codedom.compiler.generatedcodeattribute)

### Implements

* [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable)
* [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1)\<[HttpRequestHeaderName](./README.md)\>
* [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)
* [IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[HttpRequestHeaderName](./README.md)\>
* [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)
* JustinWritesCode\.Abstractions\.IHaveADescription
* JustinWritesCode\.Abstractions\.IHaveAName
* JustinWritesCode\.Abstractions\.IHaveAValue
* JustinWritesCode\.Abstractions\.IIdentifiable
* JustinWritesCode\.Enumerations\.Abstractions\.IEnumeration
* JustinWritesCode\.Enumerations\.Abstractions\.IEnumeration\<HttpRequestHeaderName, Int32\>
* JustinWritesCode\.Enumerations\.Abstractions\.IEnumeration\<HttpRequestHeaderName\>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [HttpRequestHeaderName(HttpRequestHeaderNameEnum, Int32, String, String)](-ctor/README.md) | |

## Fields

| Field | Summary |
| ----- | ------- |
| [All](All/README.md) | |
| [Count](Count/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Description](Description/README.md) | |
| [DisplayName](DisplayName/README.md) | |
| [FieldInfo](FieldInfo/README.md) | |
| [GroupName](GroupName/README.md) | |
| [Id](Id/README.md) | |
| [Name](Name/README.md) | |
| [Order](Order/README.md) | |
| [Prompt](Prompt/README.md) | |
| [ShortName](ShortName/README.md) | |
| [Uri](Uri/README.md) | |
| [Value](Value/README.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [CompareTo(HttpRequestHeaderName)](CompareTo/README.md#3847323109) |  \(Implements [IComparable\<HttpRequestHeaderName\>.CompareTo](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1.compareto)\) |
| [CompareTo(Object)](CompareTo/README.md#3189291534) |  \(Implements [IComparable.CompareTo](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable.compareto)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.equals) |  \(Inherited from [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype)\) |
| [FromDescription(String, Boolean)](FromDescription/README.md#3127795949) | |
| [FromDescription(String)](FromDescription/README.md#2509867026) | |
| [FromId(Int32, Boolean)](FromId/README.md#853940068) | |
| [FromId(Int32)](FromId/README.md#2693735658) | |
| [FromName(String, Boolean)](FromName/README.md#850939339) | |
| [FromName(String)](FromName/README.md#328253484) | |
| [FromShortName(String, Boolean)](FromShortName/README.md#3521804542) | |
| [FromShortName(String)](FromShortName/README.md#1926903090) | |
| [FromValue(HttpRequestHeaderNameEnum, Boolean)](FromValue/README.md#2911139130) | |
| [FromValue(HttpRequestHeaderNameEnum)](FromValue/README.md#476543028) | |
| [GetAll()](GetAll/README.md) | |
| [GetAllExcept(HttpRequestHeaderName\[\])](GetAllExcept/README.md#4185451777) | |
| [GetAllExcept(HttpRequestHeaderNameEnum\[\])](GetAllExcept/README.md#4120704566) | |
| [GetAllExcept(Int32\[\])](GetAllExcept/README.md#1747635590) | |
| [GetAllExcept(String\[\])](GetAllExcept/README.md#2990616228) | |
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
| [ToString()](ToString/README.md#2865347793) |  \(Overrides [ValueType.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring)\) |
| [ToString(IFormatProvider)](ToString/README.md#3902417242) |  \(Implements [IConvertible.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.tostring)\) |
| [ToString(String, IFormatProvider)](ToString/README.md#1765425075) |  \(Implements [IFormattable.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable.tostring)\) |
| [ToType(Type, IFormatProvider)](ToType/README.md) |  \(Implements [IConvertible.ToType](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.totype)\) |
| [ToUInt16(IFormatProvider)](ToUInt16/README.md) |  \(Implements [IConvertible.ToUInt16](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.touint16)\) |
| [ToUInt32(IFormatProvider)](ToUInt32/README.md) |  \(Implements [IConvertible.ToUInt32](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.touint32)\) |
| [ToUInt64(IFormatProvider)](ToUInt64/README.md) |  \(Implements [IConvertible.ToUInt64](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible.touint64)\) |
| [TryFromDescription(String, HttpRequestHeaderName, Boolean)](TryFromDescription/README.md#4175708985) | |
| [TryFromDescription(String, HttpRequestHeaderName)](TryFromDescription/README.md#486526901) | |
| [TryFromId(Int32, HttpRequestHeaderName, Boolean)](TryFromId/README.md#1294070288) | |
| [TryFromId(Int32, HttpRequestHeaderName)](TryFromId/README.md#1641723093) | |
| [TryFromName(String, HttpRequestHeaderName, Boolean)](TryFromName/README.md#1647213295) | |
| [TryFromName(String, HttpRequestHeaderName)](TryFromName/README.md#777760528) | |
| [TryFromShortName(String, HttpRequestHeaderName, Boolean)](TryFromShortName/README.md#1873241121) | |
| [TryFromShortName(String, HttpRequestHeaderName)](TryFromShortName/README.md#1503184380) | |
| [TryFromValue(HttpRequestHeaderNameEnum, HttpRequestHeaderName, Boolean)](TryFromValue/README.md#4199453442) | |
| [TryFromValue(HttpRequestHeaderNameEnum, HttpRequestHeaderName)](TryFromValue/README.md#2494361213) | |
| [TryParse(String, HttpRequestHeaderName)](TryParse/README.md#4128537229) | |
| [TryParse(String, IFormatProvider, HttpRequestHeaderName)](TryParse/README.md#1120956572) | |

## Operators

| Operator | Summary |
| -------- | ------- |
| [GreaterThan(HttpRequestHeaderName, HttpRequestHeaderName)](op_GreaterThan/README.md) | |
| [GreaterThanOrEqual(HttpRequestHeaderName, HttpRequestHeaderName)](op_GreaterThanOrEqual/README.md) | |
| [LessThan(HttpRequestHeaderName, HttpRequestHeaderName)](op_LessThan/README.md) | |
| [LessThanOrEqual(HttpRequestHeaderName, HttpRequestHeaderName)](op_LessThanOrEqual/README.md) | |

## Explicit Interface Implementations

| Member | Summary |
| ------ | ------- |
| [IHaveAValue.Value](JustinWritesCode-Abstractions-IHaveAValue-Value/README.md) | |
| [IIdentifiable.Id](JustinWritesCode-Abstractions-IIdentifiable-Id/README.md) | |

## Classes

| Class | Summary |
| ----- | ------- |
| [Accept](Accept/README.md) | Accept |
| [AcceptCharset](AcceptCharset/README.md) | Accept\-Charset |
| [AcceptDatetime](AcceptDatetime/README.md) | Accept\-Datetime |
| [AcceptEncoding](AcceptEncoding/README.md) | Accept\-Encoding |
| [AcceptLanguage](AcceptLanguage/README.md) | Accept\-Language |
| [Authorization](Authorization/README.md) | Authorization |
| [CacheControl](CacheControl/README.md) | Cache\-Control |
| [Connection](Connection/README.md) | Connection |
| [ContentLength](ContentLength/README.md) | Content\-Length |
| [ContentMD5](ContentMD5/README.md) | Content\-MD5 |
| [ContentType](ContentType/README.md) | Content\-Type |
| [Cookie](Cookie/README.md) | Cookie |
| [Date](Date/README.md) | Date |
| [Expect](Expect/README.md) | Expect |
| [From](From/README.md) | From |
| [Host](Host/README.md) | Host |
| [IfMatch](IfMatch/README.md) | If\-Match |
| [IfModifiedSince](IfModifiedSince/README.md) | If\-Modified\-Since |
| [IfNoneMatch](IfNoneMatch/README.md) | If\-None\-Match |
| [IfRange](IfRange/README.md) | If\-Range |
| [IfUnmodifiedSince](IfUnmodifiedSince/README.md) | If\-Unmodified\-Since |
| [MaxForwards](MaxForwards/README.md) | Max\-Forwards |
| [Pragma](Pragma/README.md) | Pragma |
| [ProxyAuthorization](ProxyAuthorization/README.md) | Proxy\-Authorization |
| [Range](Range/README.md) | Range |
| [Referersic](Referersic/README.md) | Referer\[sic\] |
| [TE](TE/README.md) | TE |
| [Upgrade](Upgrade/README.md) | Upgrade |
| [UserAgent](UserAgent/README.md) | User\-Agent |
| [Via](Via/README.md) | Via |
| [Warning](Warning/README.md) | Warning |
| [XForwardedFor](XForwardedFor/README.md) | X\-Forwarded\-For |
| [XPageNumber](XPageNumber/README.md) | X\-Page\-Number |
| [XPageSize](XPageSize/README.md) | X\-Page\-Size |

