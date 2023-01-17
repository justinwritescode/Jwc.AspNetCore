# HttpRequestHeaderNames\.TE Field

[Home](../../../../README.md)

**Containing Type**: System\.Net\.Http\.Headers\.[HttpRequestHeaderNames](../README.md)

**Assembly**: JustinWritesCode\.Http\.dll

  
The transfer encodings the user agent is willing to accept: the same values as for the response header Transfer\-Encoding can be used, plus the trailers value \(related to the chunked transfer method\) to notify the server it expects to receive additional headers \(the trailers\) after the last, zero\-sized, chunk\.

```csharp
public const string TE = "TE"
```

### Field Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

