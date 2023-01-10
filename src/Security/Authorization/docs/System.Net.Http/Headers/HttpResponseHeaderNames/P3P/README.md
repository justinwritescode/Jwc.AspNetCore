# HttpResponseHeaderNames\.P3P Field

[Home](../../../../README.md)

**Containing Type**: System\.Net\.Http\.Headers\.[HttpResponseHeaderNames](../README.md)

**Assembly**: JustinWritesCode\.Http\.dll

  
This header is supposed to set P3P policy, in the form of P3P:CP=your\_compact\_policy\. However, P3P did not take off,\[22\] most browsers have never fully implemented it, a lot of websites set this header with fake policy text, that was enough to fool browsers the existence of P3P policy and grant permissions for third party cookies\.

```csharp
public const string P3P = "P3P"
```

### Field Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

