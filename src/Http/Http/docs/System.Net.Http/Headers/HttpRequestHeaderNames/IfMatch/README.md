# HttpRequestHeaderNames\.IfMatch Field

[Home](../../../../README.md)

**Containing Type**: System\.Net\.Http\.Headers\.[HttpRequestHeaderNames](../README.md)

**Assembly**: JustinWritesCode\.Http\.dll

  
Only perform the action if the client supplied entity matches the same entity on the server\. This is mainly for methods like PUT to only update a resource if it has not been modified since the user last updated it\.

```csharp
public const string IfMatch = "If-Match"
```

### Field Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

