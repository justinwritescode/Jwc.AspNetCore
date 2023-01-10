# HttpRequestHeaderNames Class

[Home](../../../README.md) &#x2022; [Fields](#fields)

**Namespace**: [System.Net.Http.Headers](../README.md)

**Assembly**: JustinWritesCode\.Http\.dll

  
    Contains the standard set of headers applicable to an HTTP request\.
    

```csharp
public static class HttpRequestHeaderNames
```

## Fields

| Field | Summary |
| ----- | ------- |
| [Accept](Accept/README.md) | Content\-Types that are acceptable \(Value = "Accept"\) |
| [AcceptCharset](AcceptCharset/README.md) | Character sets that are acceptable \(Value = "Accept\-Charset"\) |
| [AcceptDatetime](AcceptDatetime/README.md) | Acceptable version in time \(Value = "Accept\-Datetime"\) |
| [AcceptEncoding](AcceptEncoding/README.md) | Acceptable encodings\. See HTTP compression\. \(Value = "Accept\-Encoding"\) |
| [AcceptLanguage](AcceptLanguage/README.md) | Acceptable languages for response \(Value = "Accept\-Language"\) |
| [Authorization](Authorization/README.md) | Authentication credentials for HTTP authentication \(Value = "Authorization"\) |
| [CacheControl](CacheControl/README.md) | Used to specify directives that MUST be obeyed by all caching mechanisms along the request/response chain \(Value = "Cache\-Control"\) |
| [Connection](Connection/README.md) | What type of connection the user\-agent would prefer \(Value = "Connection"\) |
| [ContentLength](ContentLength/README.md) | The length of the request body in octets \(8\-bit bytes\) \(Value = "Content\-Length"\) |
| [ContentMD5](ContentMD5/README.md) | A Base64\-encoded binary MD5 sum of the content of the request body \(Value = "Content\-MD5"\) |
| [ContentType](ContentType/README.md) | The MIME type of the body of the request \(used with POST and PUT requests\) \(Value = "Content\-Type"\) |
| [Cookie](Cookie/README.md) | an HTTP cookie previously sent by the server with Set\-Cookie \(below\) \(Value = "Cookie"\) |
| [Date](Date/README.md) | The date and time that the message was sent \(Value = "Date"\) |
| [Expect](Expect/README.md) | Indicates that particular server behaviors are required by the client \(Value = "Expect"\) |
| [From](From/README.md) | The email address of the user making the request \(Value = "From"\) |
| [Host](Host/README.md) | The domain name of the server \(for virtual hosting\), mandatory since HTTP/1\.1\. Although domain name are specified as case\-insensitive\[5\]\[6\], it is not specified whether the contents of the Host field should be interpreted in a case\-insensitive manner\[7\] and in practice some implementations of virtual hosting interpret the contents of the Host field in a case\-sensitive manner\.\[citation needed\] \(Value = "Host"\) |
| [IfMatch](IfMatch/README.md) | Only perform the action if the client supplied entity matches the same entity on the server\. This is mainly for methods like PUT to only update a resource if it has not been modified since the user last updated it\. \(Value = "If\-Match"\) |
| [IfModifiedSince](IfModifiedSince/README.md) | Allows a 304 Not Modified to be returned if content is unchanged \(Value = "If\-Modified\-Since"\) |
| [IfNoneMatch](IfNoneMatch/README.md) | Allows a 304 Not Modified to be returned if content is unchanged, see HTTP ETag \(Value = "If\-None\-Match"\) |
| [IfRange](IfRange/README.md) | If the entity is unchanged, send me the part\(s\) that I am missing; otherwise, send me the entire new entity \(Value = "If\-Range"\) |
| [IfUnmodifiedSince](IfUnmodifiedSince/README.md) | Only send the response if the entity has not been modified since a specific time\. \(Value = "If\-Unmodified\-Since"\) |
| [MaxForwards](MaxForwards/README.md) | Limit the number of times the message can be forwarded through proxies or gateways\. \(Value = "Max\-Forwards"\) |
| [Pragma](Pragma/README.md) | Implementation\-specific headers that may have various effects anywhere along the request\-response chain\. \(Value = "Pragma"\) |
| [ProxyAuthorization](ProxyAuthorization/README.md) | Authorization credentials for connecting to a proxy\. \(Value = "Proxy\-Authorization"\) |
| [Range](Range/README.md) | Request only part of an entity\. Bytes are numbered from 0\. \(Value = "Range"\) |
| [Referersic](Referersic/README.md) | This is the address of the previous web page from which a link to the currently requested page was followed\. \(The word “referrer” is misspelled in the RFC as well as in most implementations\.\) \(Value = "Referer\[sic\]"\) |
| [TE](TE/README.md) | The transfer encodings the user agent is willing to accept: the same values as for the response header Transfer\-Encoding can be used, plus the trailers value \(related to the chunked transfer method\) to notify the server it expects to receive additional headers \(the trailers\) after the last, zero\-sized, chunk\. \(Value = "TE"\) |
| [Upgrade](Upgrade/README.md) | Ask the server to upgrade to another protocol\. \(Value = "Upgrade"\) |
| [UserAgent](UserAgent/README.md) | The user agent string of the user agent \(Value = "User\-Agent"\) |
| [Via](Via/README.md) | Informs the server of proxies through which the request was sent\. \(Value = "Via"\) |
| [Warning](Warning/README.md) | A general warning about possible problems with the entity body\. \(Value = "Warning"\) |
| [XForwardedFor](XForwardedFor/README.md) | Contains the original source address of the request\. \(Value = "X\-Forwarded\-For"\) |
| [XPageNumber](XPageNumber/README.md) | The number of the page being requested \(Value = "X\-Page\-Number"\) |
| [XPageSize](XPageSize/README.md) | The size of the page being requested \(Value = "X\-Page\-Size"\) |

