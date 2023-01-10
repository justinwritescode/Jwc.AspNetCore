# HttpRequestHeaderNameEnum Enum

[Home](../../../README.md) &#x2022; [Fields](#fields)

**Namespace**: [System.Net.Http.Headers](../README.md)

**Assembly**: JustinWritesCode\.Http\.dll

  
Contains the standard set of headers applicable to an HTTP request\.

```csharp
[GenerateEnumerationRecordStruct("HttpRequestHeaderName", null)]
public enum HttpRequestHeaderNameEnum
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) &#x2192; HttpRequestHeaderNameEnum

### Attributes

* [GenerateEnumerationRecordStructAttribute](../../../Global/GenerateEnumerationRecordStructAttribute/README.md)

## Fields

| Name | Value | Summary |
| ---- | ----- | ------- |
| XPageNumber | 0 | The number of the page being requested |
| XPageSize | 1 | The size of the page being requested |
| Accept | 2 | Content\-Types that are acceptable |
| AcceptCharset | 3 | Character sets that are acceptable |
| AcceptEncoding | 4 | Acceptable encodings\. See HTTP compression\. |
| AcceptLanguage | 5 | Acceptable languages for response |
| AcceptDatetime | 6 | Acceptable version in time |
| Authorization | 7 | Authentication credentials for HTTP authentication |
| CacheControl | 8 | Used to specify directives that MUST be obeyed by all caching mechanisms along the request/response chain |
| Connection | 9 | What type of connection the user\-agent would prefer |
| Cookie | 10 | an HTTP cookie previously sent by the server with Set\-Cookie \(below\) |
| ContentLength | 11 | The length of the request body in octets \(8\-bit bytes\) |
| ContentMD5 | 12 | A Base64\-encoded binary MD5 sum of the content of the request body |
| ContentType | 13 | The MIME type of the body of the request \(used with POST and PUT requests\) |
| Date | 14 | The date and time that the message was sent |
| Expect | 15 | Indicates that particular server behaviors are required by the client |
| From | 16 | The email address of the user making the request |
| Host | 17 | The domain name of the server \(for virtual hosting\), mandatory since HTTP/1\.1\. Although domain name are specified as case\-insensitive\[5\]\[6\], it is not specified whether the contents of the Host field should be interpreted in a case\-insensitive manner\[7\] and in practice some implementations of virtual hosting interpret the contents of the Host field in a case\-sensitive manner\.\[citation needed\] |
| IfMatch | 18 | Only perform the action if the client supplied entity matches the same entity on the server\. This is mainly for methods like PUT to only update a resource if it has not been modified since the user last updated it\. |
| IfModifiedSince | 19 | Allows a 304 Not Modified to be returned if content is unchanged |
| IfNoneMatch | 20 | Allows a 304 Not Modified to be returned if content is unchanged, see HTTP ETag |
| IfRange | 21 | If the entity is unchanged, send me the part\(s\) that I am missing, otherwise, send me the entire new entity |
| IfUnmodifiedSince | 22 | Only send the response if the entity has not been modified since a specific time\. |
| MaxForwards | 23 | Limit the number of times the message can be forwarded through proxies or gateways\. |
| Pragma | 24 | Implementation\-specific headers that may have various effects anywhere along the request\-response chain\. |
| ProxyAuthorization | 25 | Authorization credentials for connecting to a proxy\. |
| Range | 26 | Request only part of an entity\. Bytes are numbered from 0\. |
| Referersic | 27 | This is the address of the previous web page from which a link to the currently requested page was followed\. \(The word “referrer” is misspelled in the RFC as well as in most implementations\.\) |
| TE | 28 | The transfer encodings the user agent is willing to accept: the same values as for the response header Transfer\-Encoding can be used, plus the trailers value \(related to the chunked transfer method\) to notify the server it expects to receive additional headers \(the trailers\) after the last, zero\-sized, chunk\. |
| Upgrade | 29 | Ask the server to upgrade to another protocol\. |
| UserAgent | 30 | The user agent string of the user agent |
| Via | 31 | Informs the server of proxies through which the request was sent\. |
| Warning | 32 | A general warning about possible problems with the entity body\. |
| XForwardedFor | 33 | Contains the original source address of the request\. |

