# HttpRequestHeaderNames\.Host Field

[Home](../../../../README.md)

**Containing Type**: System\.Net\.Http\.Headers\.[HttpRequestHeaderNames](../README.md)

**Assembly**: JustinWritesCode\.Http\.dll

  
The domain name of the server \(for virtual hosting\), mandatory since HTTP/1\.1\. Although domain name are specified as case\-insensitive\[5\]\[6\], it is not specified whether the contents of the Host field should be interpreted in a case\-insensitive manner\[7\] and in practice some implementations of virtual hosting interpret the contents of the Host field in a case\-sensitive manner\.\[citation needed\]

```csharp
public const string Host = "Host"
```

### Field Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

