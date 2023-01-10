# HttpResponseHeaderNames Class

[Home](../../../README.md) &#x2022; [Fields](#fields)

**Namespace**: [System.Net.Http.Headers](../README.md)

**Assembly**: JustinWritesCode\.Http\.dll

  
    Contains the standard set of headers applicable to an HTTP response\.
    

```csharp
public static class HttpResponseHeaderNames
```

## Fields

| Field | Summary |
| ----- | ------- |
| [AcceptPatch](AcceptPatch/README.md) | HTTP header that advertises which patch document formats this server supports \(Value = "Accept\-Patch"\) |
| [AcceptRanges](AcceptRanges/README.md) | What partial content range types this server supports \(Value = "Accept\-Ranges"\) |
| [Age](Age/README.md) | The age the object has been in a proxy cache in seconds \(Value = "Age"\) |
| [Allow](Allow/README.md) | Valid actions for a specified resource\. To be used for a 405 Method not allowed \(Value = "Allow"\) |
| [CacheControl](CacheControl/README.md) | Tells all caching mechanisms from server to client whether they may cache this object\. It is measured in seconds \(Value = "Cache\-Control"\) |
| [Connection](Connection/README.md) | Options that are desired for the connection\[17\] \(Value = "Connection"\) |
| [ContentDisposition](ContentDisposition/README.md) | An opportunity to raise a File Download dialogue box for a known MIME type with binary format or suggest a filename for dynamic content\. Quotes are necessary with special characters\. \(Value = "Content\-Disposition"\) |
| [ContentEncoding](ContentEncoding/README.md) | The type of encoding used on the data\. See HTTP compression\. \(Value = "Content\-Encoding"\) |
| [ContentLanguage](ContentLanguage/README.md) | The language the content is in \(Value = "Content\-Language"\) |
| [ContentLength](ContentLength/README.md) | The length of the response body in octets \(8\-bit bytes\) \(Value = "Content\-Length"\) |
| [ContentLocation](ContentLocation/README.md) | An alternate location for the returned data \(Value = "Content\-Location"\) |
| [ContentMD5](ContentMD5/README.md) | A Base64\-encoded binary MD5 sum of the content of the response \(Value = "Content\-MD5"\) |
| [ContentRange](ContentRange/README.md) | Where in a full body message this partial message belongs \(Value = "Content\-Range"\) |
| [ContentType](ContentType/README.md) | The MIME type of this content \(Value = "Content\-Type"\) |
| [Date](Date/README.md) | The date and time that the message was sent \(Value = "Date"\) |
| [ETag](ETag/README.md) | An identifier for a specific version of a resource, often a message digest \(Value = "ETag"\) |
| [Expires](Expires/README.md) | Gives the date/time after which the response is considered stale \(Value = "Expires"\) |
| [LastModified](LastModified/README.md) | The last modified date for the requested object, inRFC 2822 format \(Value = "Last\-Modified"\) |
| [Link](Link/README.md) | Used to express a typed relationship with another resource, where the relation type is defined by RFC 5988 \(Value = "Link"\) |
| [Location](Location/README.md) | Used in redirection, or when a new resource has been created\. \(Value = "Location"\) |
| [P3P](P3P/README.md) | This header is supposed to set P3P policy, in the form of P3P:CP=your\_compact\_policy\. However, P3P did not take off,\[22\] most browsers have never fully implemented it, a lot of websites set this header with fake policy text, that was enough to fool browsers the existence of P3P policy and grant permissions for third party cookies\. \(Value = "P3P"\) |
| [Pragma](Pragma/README.md) | Implementation\-specific headers that may have various effects anywhere along the request\-response chain\. \(Value = "Pragma"\) |
| [ProxyAuthenticate](ProxyAuthenticate/README.md) | Request authentication to access the proxy\. \(Value = "Proxy\-Authenticate"\) |
| [Refresh](Refresh/README.md) | Used in redirection, or when a new resource has been created\. This refresh redirects after 5 seconds\. This is a proprietary, non\-standard header extension introduced by Netscape and supported by most web browsers\. \(Value = "Refresh"\) |
| [RetryAfter](RetryAfter/README.md) | If an entity is temporarily unavailable, this instructs the client to try again after a specified period of time \(seconds\)\. \(Value = "Retry\-After"\) |
| [Server](Server/README.md) | A name for the server \(Value = "Server"\) |
| [SetCookie](SetCookie/README.md) | an HTTP cookie \(Value = "Set\-Cookie"\) |
| [StrictTransportSecurity](StrictTransportSecurity/README.md) | A HSTS Policy informing the HTTP client how long to cache the HTTPS only policy and whether this applies to subdomains\. \(Value = "Strict\-Transport\-Security"\) |
| [Trailer](Trailer/README.md) | The Trailer general field value indicates that the given set of header fields is present in the trailer of a message encoded with chunked transfer\-coding\. \(Value = "Trailer"\) |
| [TransferEncoding](TransferEncoding/README.md) | The form of encoding used to safely transfer the entity to the user\. Currently defined methods are:chunked, compress, deflate, gzip, identity\. \(Value = "Transfer\-Encoding"\) |
| [Vary](Vary/README.md) | Tells downstream proxies how to match future request headers to decide whether the cached response can be used rather than requesting a fresh one from the origin server\. \(Value = "Vary"\) |
| [Via](Via/README.md) | Informs the client of proxies through which the response was sent\. \(Value = "Via"\) |
| [Warning](Warning/README.md) | A general warning about possible problems with the entity body\. \(Value = "Warning"\) |
| [WWWAuthenticate](WWWAuthenticate/README.md) | Indicates the authentication scheme that should be used to access the requested entity\. \(Value = "WWW\-Authenticate"\) |
| [XEndIndex](XEndIndex/README.md) | The index of the last record in the page \(Value = "x\-end\-index"\) |
| [XFailed](XFailed/README.md) | Indicates that the request has failed \(Value = "x\-failed"\) |
| [XHasNextPage](XHasNextPage/README.md) | Whether there is a next page \(Value = "x\-has\-next\-page"\) |
| [XHasPreviousPage](XHasPreviousPage/README.md) | Whether there is a previous page \(Value = "x\-has\-previous\-page"\) |
| [XIsLastPage](XIsLastPage/README.md) | Whether this is the last page \(Value = "x\-is\-last\-page"\) |
| [XPageNumber](XPageNumber/README.md) | The number of the page being returned \(Value = "X\-Page\-Number"\) |
| [XPageSize](XPageSize/README.md) | The size of the page being returned \(Value = "X\-Page\-Size"\) |
| [XProblemDetail](XProblemDetail/README.md) |  \(Value = "x\-problem\-detail"\) |
| [XProblemInstance](XProblemInstance/README.md) |  \(Value = "x\-problem\-instance"\) |
| [XProblemTitle](XProblemTitle/README.md) |  \(Value = "x\-problem\-title"\) |
| [XProblemType](XProblemType/README.md) |  \(Value = "x\-problem\-type"\) |
| [XStartIndex](XStartIndex/README.md) | The index of the first record in the page \(Value = "x\-start\-index"\) |
| [XTotalPages](XTotalPages/README.md) | The total number of pages in the dataset \(Value = "X\-Total\-Pages"\) |
| [XTotalRecords](XTotalRecords/README.md) | The total number of records in the dataset \(Value = "x\-total\-records"\) |

