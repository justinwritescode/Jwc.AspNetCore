# HttpExceptionBase Constructors

[Home](../../../README.md)

**Containing Type**: Microsoft\.AspNetCore\.[HttpExceptionBase](../README.md)

**Assembly**: JustinWritesCode\.AspNetCore\.Exceptions\.dll

## Overloads

| Constructor | Summary |
| ----------- | ------- |
| [HttpExceptionBase()](#1531550744) | |
| [HttpExceptionBase(Int32, String, Exception)](#3811156269) | |
| [HttpExceptionBase(Int32, String)](#3244298213) | |

<a id="1531550744"></a>

## HttpExceptionBase\(\) 

```csharp
public HttpExceptionBase()
```

<a id="3811156269"></a>

## HttpExceptionBase\(Int32, String, Exception\) 

```csharp
public HttpExceptionBase(int statusCode, string message = "An error occurred while processing your request.", Exception inner = null)
```

### Parameters

**statusCode** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**message** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**inner** &ensp; [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<a id="3244298213"></a>

## HttpExceptionBase\(Int32, String\) 

```csharp
public HttpExceptionBase(int statusCode, string message = "An error occurred while processing your request.")
```

### Parameters

**statusCode** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**message** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)